using System;
using System.Collections.Generic;
using System.Text;

namespace P2PChatAppication
{
    class UserDetails
    {
        static string yourName;
        static string yourPortNumber;

        static string friendsAddress;
        static string friendsName;
        static string friendsIpAddress;
        static string friendsPortNumber;

        public static string[] GetYourDetails()
        {
            Console.Write("Enter your Name : ");
            yourName = Console.ReadLine();
            Console.Write("Enter your Port : ");
            yourPortNumber = Console.ReadLine();

            string[] yourDetails = new string[2] { yourName, yourPortNumber };

            return yourDetails;
        }

        public static string[] GetFriendDetails()
        {
            Console.Write("Friend's Address :");
            friendsAddress = Console.ReadLine();

            string[] friendsDetails = NetworkHostAddress.ParseAddress(friendsAddress);
            return friendsDetails;
        }
    }
}
