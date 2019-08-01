using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace P2PChatAppication
{
    class NetworkHostClient
    {
        public static void Connect(string friendsIPAddress, int friendsPortNumber)
        {
            Socket senderSocket = Connection.GetSocket();
            IPEndPoint endPoint = Connection.GetEndPoint(IPAddress.Parse(friendsIPAddress), friendsPortNumber);

            try
            {
                var flag = true;
                while (flag)
                {
                    try
                    {
                        senderSocket.Connect(endPoint);
                        flag = false;
                        Console.WriteLine("Connected!");
                        Console.WriteLine("----------------------------------------------------------------");
                        Console.WriteLine("BEGIN CHAT");
                        Console.WriteLine("----------------------------------------------------------------");
                    }
                    catch
                    {}
                }

                bool ifMessageSent = Conversation.SendMessage(senderSocket);
            }
            catch
            {
                Console.WriteLine("Error: Unable to connect to Server!");
            }
        }
    }
}
