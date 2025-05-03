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
        private int sourcePort = 27000;
        private int destinationPort = 27001;
        private IPAddress destinationAddress;

        public Networking(string ipAddress)
        {
            destinationAddress = IPAddress.Parse(ipAddress);
            KeepConnection();
        }

        private void KeepConnection()
        {
            var vjoy = new VJoy();

            new Thread(() =>
            {
                UdpClient listener = new UdpClient();
                listener.Client.Bind(new IPEndPoint(IPAddress.Parse("0.0.0.0"), sourcePort));

                new Thread(() =>
                {
                    while (true)
                    {
                        listener.Client.SendTo(new byte[] { 2, 4, 6, 8 }, new IPEndPoint(destinationAddress, destinationPort));
                        Thread.Sleep(3000);
                    }
                }).Start();

                byte[] buffer = new byte[4];

                while (true)
                {
                    int bufferSize = listener.Client.Receive(buffer);
                    Console.WriteLine("Received Message:");
                    var brake = BitConverter.ToUInt16(buffer, 0);
                    var throttle = BitConverter.ToUInt16(buffer, 2);
                    vjoy.SetVJoyAxes(brake, throttle);
                }
            }).Start();
        }

        public void SendData(UInt16 brake, UInt16 throttle)
        {
            UdpClient sender2 = new UdpClient();
            sender2.Client.Bind(new IPEndPoint(IPAddress.Parse("0.0.0.0"), destinationPort));
            byte[] sendData = BitConverter.GetBytes(brake).Concat(BitConverter.GetBytes(throttle)).ToArray();
            sender2.Client.SendTo(sendData, new IPEndPoint(destinationAddress, sourcePort));
            sender2.Close();
        }

        public async Task<string> GetPublicIP()
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
