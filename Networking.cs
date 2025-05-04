using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using System.Net.Sockets;
using System.Threading;
using System.Net.Http;

namespace PedalPal
{
    class Networking
    {
        private int receivePort = 27000;
        private int sendPort = 27001;
        private IPAddress destinationAddress;

        VJoy vjoy;

        UdpClient listener;
        Thread receiveThread;
        Thread keepAliveThread;

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
                        listener.Client.SendTo(new byte[] { 1, 0, 0, 0, 0 }, new IPEndPoint(destinationAddress, sendPort));
                        Thread.Sleep(1500);
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
            UdpClient sender2 = new UdpClient();
            sender2.Client.Bind(new IPEndPoint(IPAddress.Parse("0.0.0.0"), sendPort));
            byte[] sendData = new byte[] { 0 }.Concat(BitConverter.GetBytes(brake)).Concat(BitConverter.GetBytes(throttle)).ToArray();
            sender2.Client.SendTo(sendData, new IPEndPoint(destinationAddress, receivePort));
            sender2.Close();
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
