using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace P2PChatAppication
{
    class NetworkHostListener
    {
        static Socket listenerSocket;
        static IPEndPoint endPoint;

        public static void AcceptConnection(IPAddress ipAddr, int myPortNumber, string friendsName)
        {
            listenerSocket = Connection.GetSocket();
            endPoint = Connection.GetEndPoint(ipAddr, myPortNumber);

            listenerSocket.Bind(endPoint);
            listenerSocket.Listen(10);

            Socket peerSocket = Connection.GetPeerSocket();
            try
            {
                peerSocket = listenerSocket.Accept();
                bool ifMessageReceived = Conversation.ReceiveMessage(peerSocket, friendsName);
            }
            catch
            {
                Console.WriteLine("Error: Unable to connect to Client!");
            }
        }
    }
}
