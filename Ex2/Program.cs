using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("0: Nhap ten mien hoac 1: IP: ");
            int n = int.Parse(Console.ReadLine());

            if (n == 0)
            {
                Console.Write("Nhap ten mien: ");
                string name = Console.ReadLine();

                IPHostEntry iphe = Dns.Resolve(name);
                foreach (IPAddress i in iphe.AddressList)
                {
                    Console.Write(" " + i);
                }
            }
            else
            {
                Console.Write("Nhap IP: ");
                string ip = Console.ReadLine();

                IPHostEntry iphe = Dns.Resolve(ip);
                foreach (char i in iphe.HostName)
                {
                    Console.Write(" " + i.ToString());
                }
            }

        }
    }
}
