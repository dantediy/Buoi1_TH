using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Dns.GetHostName();
            IPHostEntry ip = Dns.GetHostByName(name);
            foreach (IPAddress i in ip.AddressList)
            {
                Console.WriteLine(" " + i.ToString());
            }
        }
    }
}
