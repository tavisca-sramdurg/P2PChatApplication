using System;
using System.Collections.Generic;
using System.Text;

namespace P2PChatAppication
{
    public class Display
    {
        public static bool DisplayMessage(string friendsName,string friendsMessage)
        {
            Console.WriteLine("{0} : {1}".PadLeft(150), friendsName, friendsMessage);

            return true;
        }
    }
}
