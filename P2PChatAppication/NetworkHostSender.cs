using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace P2PChatAppication
{
    class NetworkHostSender
    {
        public static void Send(string friendsIPAddress, int friendsPortNumber)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(friendsIPAddress), friendsPortNumber);

            try
            {
                var flag = true;
                while (flag)
                {
                    try
                    {
                        socket.Connect(endPoint);
                        flag = false;
                        Console.WriteLine("Connected!");
                    }
                    catch
                    {
                        //Console.WriteLine("Waiting for friend to connect");
                    }
                }

                while (true)
                {
                    //Console.WriteLine("You: ");
                    var message = Console.ReadLine();
                    var messageToBeSent = Encoding.ASCII.GetBytes(message);
                    socket.Send(messageToBeSent);
                }
            }
            catch
            {
                Console.WriteLine("Error: Unable to connect to Server!");
            }
            //socket.Shutdown(SocketShutdown.Both);
            //socket.Close();

        }
    }
}
