using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using System.Net.Sockets;
using System.Threading;
using System.Net.Http;
using System.Collections.Concurrent;

namespace PedalPal
{
    class Networking
    {
        private int receivePort = 53544;
        private IPAddress destinationAddress;

        VJoy vjoy;

        UdpClient listener;
        Thread receiveThread;
        Thread keepAliveThread;

        ConcurrentQueue<byte[]> sendQueue = new ConcurrentQueue<byte[]>();

        public Networking(VJoy vjoy, string ipAddress)
        {
            this.vjoy = vjoy;
            destinationAddress = IPAddress.Parse(ipAddress);
            KeepConnection();
        }

        public void Destroy()
        {
            if (receiveThread != null && receiveThread.IsAlive)
            {
                receiveThread.Abort();
            }
            if (keepAliveThread != null && keepAliveThread.IsAlive)
            {
                keepAliveThread.Abort();
            }
            if (listener != null)
            {
                listener.Close();
            }
        }

        private void KeepConnection()
        {
            receiveThread = new Thread(() =>
            {
                listener = new UdpClient();
                listener.Client.Bind(new IPEndPoint(IPAddress.Parse("0.0.0.0"), receivePort));

                keepAliveThread = new Thread(() =>
                {
                    while (true)
                    {
                        if (sendQueue.TryDequeue(out byte[] sendData))
                        {
                            listener.Client.SendTo(sendData, new IPEndPoint(destinationAddress, receivePort));
                        }
                        else
                        {
                            listener.Client.SendTo(new byte[] { 1, 0, 0, 0, 0 }, new IPEndPoint(destinationAddress, receivePort));
                            Thread.Sleep(10);
                        }
                    }
                });
                keepAliveThread.Start();

                byte[] buffer = new byte[5];

                while (true)
                {
                    int bufferSize = listener.Client.Receive(buffer);
                    if (buffer[0] == 0)
                    {
                        var brake = BitConverter.ToUInt16(buffer, 1);
                        var throttle = BitConverter.ToUInt16(buffer, 3);
                        vjoy.SetVJoyAxes(brake, throttle);
                    }
                }
            });
            receiveThread.Start();
        }

        public void SendData(UInt16 brake, UInt16 throttle)
        {
            byte[] sendData = new byte[] { 0 }.Concat(BitConverter.GetBytes(brake)).Concat(BitConverter.GetBytes(throttle)).ToArray();
            sendQueue.Enqueue(sendData);
        }

        public static async Task<string> GetPublicIP()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Get the public IP from ipify.org
                    HttpResponseMessage response = await client.GetAsync("https://api.ipify.org");
                    response.EnsureSuccessStatusCode();

                    string ipAddress = await response.Content.ReadAsStringAsync();
                    return ipAddress;
                }
                catch (Exception ex)
                {
                    return $"Error: {ex.Message}";
                }
            }
        }
    }
}
