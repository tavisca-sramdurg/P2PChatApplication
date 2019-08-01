using System;
using System.Collections.Generic;
using System.Text;

namespace P2PChatAppication
{
    public class NetworkHostAddress
    {
        public static string[] ParseAddress(string address)
        {
            string name;
            string ipAddress;
            string portNumber;

            var temporaryVariable1 = address.Split('@');
            var temporaryVariable2 = temporaryVariable1[1].Split(':');

            name = temporaryVariable1[0];
            ipAddress = temporaryVariable2[0];
            portNumber = temporaryVariable2[1];

            string[] userDetails = new string[3] { name, ipAddress, portNumber };

            return userDetails;
        }
    }
}
