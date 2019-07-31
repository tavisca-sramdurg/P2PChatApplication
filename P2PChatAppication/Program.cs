using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;


namespace P2PChatAppication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== ChatApp =====");
            ChatApp chatApp = new ChatApp();
            chatApp.StartApp();



            //Console.WriteLine(_[0]);
            //Console.WriteLine(__[0]);
            //Console.WriteLine(__[1]);
        }
    }
}
