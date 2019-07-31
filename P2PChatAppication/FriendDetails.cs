using System;
using System.Collections.Generic;
using System.Text;

namespace P2PChatAppication
{
    class FriendDetails
    {
        static string friendsAddress;
        static string friendsName;
        static string friendsIpAddress;
        static string friendsPortNumber;

        public static string[] GetFriendDetails()
        {
            Console.Write("Friend's Address :");
            friendsAddress = Console.ReadLine();

            string[] friendsDetails = AddressParser.ParseAddress(friendsAddress);
            return friendsDetails;
        }
    }
}
