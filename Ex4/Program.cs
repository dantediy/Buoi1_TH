using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            string ip = null;
            string name = Dns.GetHostName();
            IPHostEntry iphe = Dns.GetHostByName(name);
            foreach (IPAddress k in iphe.AddressList)
            {
                ip = k.ToString();
            }
            //cat IP
            //string[] a = ip.Split('.');
            //foreach (string n in a)
            //{
            //    Console.WriteLine(n);
            //}

            //Tim dau cham cuoi cung trong day IP
            int pos = ip.LastIndexOf('.');
            //Remove dau sau dau cham cuoi cung
            string newIP = ip.Remove(pos + 1);
            Console.WriteLine(newIP);

            for (int i = 1; i <= 10; i++)
            {
                string z = newIP + i;
                //Console.WriteLine(z);
                IPHostEntry iphe2 = Dns.Resolve(z);
                foreach (char x in iphe2.HostName)
                {
                    Console.Write(" " + x);
                }
            }
        }
    }
}