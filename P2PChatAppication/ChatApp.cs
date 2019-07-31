using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace P2PChatAppication
{
    class ChatApp
    {
        string myName;
        int myPortNumber;

        string friendsName;
        string friendsIPAddress;
        int friendsPortNumber;

        IPHostEntry ipHost;
        IPAddress ipAddress;

        public ChatApp()
        {
            ipHost = Dns.GetHostEntry(Dns.GetHostName());
            ipAddress = ipHost.AddressList[1];
        }

        public void StartApp()
        {
            Console.WriteLine("Your Ip Address : " + ipAddress);     
            
            string[] yourDetails = YourDetails.GetYourDetails();
            myName = yourDetails[0];
            myPortNumber = int.Parse(yourDetails[1]);

            string[] friendsDetails = FriendDetails.GetFriendDetails();
            friendsName = friendsDetails[0];
            friendsIPAddress = friendsDetails[1];
            friendsPortNumber = int.Parse(friendsDetails[2]);

            Thread senderThread = new Thread(new ThreadStart(() => NetworkHostSender.Send(friendsIPAddress, friendsPortNumber)));
            senderThread.Start();
            Thread listenerThread = new Thread(new ThreadStart(() => NetworkHostListener.Listen(ipAddress, myPortNumber, friendsName)));
            listenerThread.Start();
        }
        
    }
}
