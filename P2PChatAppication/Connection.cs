using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace P2PChatAppication
{
    public class Connection
    {
        public static Socket GetSocket()
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            return socket;
        }

        public static IPEndPoint GetEndPoint(IPAddress ipAddr, int myPortNumber)
        {
            IPEndPoint endPoint = new IPEndPoint(ipAddr, myPortNumber);
            return endPoint;
        }

        public static Socket GetPeerSocket()
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            return socket;
        }

    }
}
