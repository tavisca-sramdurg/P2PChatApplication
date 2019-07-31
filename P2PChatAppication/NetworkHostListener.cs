using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace P2PChatAppication
{
    class NetworkHostListener
    {
        public static void Listen(IPAddress ipAddr, int myPortNumber, string friendsName)
        {
            Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint endPoint = new IPEndPoint(ipAddr, myPortNumber);
            listener.Bind(endPoint);
            listener.Listen(10);
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                socket = listener.Accept();
                while (true)
                {
                    var messageRecieved = new byte[1024];
                    var byteRecieved = socket.Receive(messageRecieved);
                    Console.WriteLine(friendsName + ": " + Encoding.ASCII.GetString(messageRecieved, 0, byteRecieved));
                }
            }
            catch
            {
                Console.WriteLine("Error: Unable to connect to Client!");
            }
            //socket.Shutdown(SocketShutdown.Both);
            //socket.Close();

        }
    }
}
