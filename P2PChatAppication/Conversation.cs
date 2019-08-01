using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace P2PChatAppication
{
    public class Conversation
    {
        public static bool SendMessage(Socket socket)
        {
            while (true)
            {
                //Console.WriteLine("You: ");
                var message = Console.ReadLine();
                var messageToBeSent = Encoding.ASCII.GetBytes(message);
                socket.Send(messageToBeSent);
                if (message == "quit")
                {
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("Connection Closed");
                    Console.WriteLine("----------------------------------------------------------------");
                    break;
                }                    
            }

            return true;
        }

        public static bool ReceiveMessage(Socket peerSocket, string friendsName)
        {
            while (true)
            {
                var message = new byte[1024];
                var numberOfBytes = peerSocket.Receive(message);
                string receivedMessage = Encoding.ASCII.GetString(message, 0, numberOfBytes);
                bool ifDisplayed = Display.DisplayMessage(friendsName, receivedMessage);

                if (receivedMessage == "quit")
                {
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("Connection Closed");
                    Console.WriteLine("----------------------------------------------------------------");
                    peerSocket.Shutdown(SocketShutdown.Both);
                    peerSocket.Close();
                    break;
                }
            }
            return true;
        }
    }
}
