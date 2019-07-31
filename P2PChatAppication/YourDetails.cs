using System;
using System.Collections.Generic;
using System.Text;

namespace P2PChatAppication
{
    class YourDetails
    {
        static string yourName;
        //static string yourIpAddress;
        static string yourPortNumber;

        public static string[] GetYourDetails()
        {
            Console.Write("Enter your Name :");
            yourName = Console.ReadLine();
            Console.Write("Enter your Port : ");
            yourPortNumber = Console.ReadLine();

            string[] yourDetails = new string[2] { yourName, yourPortNumber };

            return yourDetails;
        }
    }
}
