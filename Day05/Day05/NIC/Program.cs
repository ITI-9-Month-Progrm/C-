using System;

namespace NetworkInterfaceCard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            NIC nic1 = NIC.createNIC;
            NIC nic2 = NIC.createNIC;
            Console.WriteLine("nic1 : " + nic1.GetHashCode());
            Console.WriteLine("nic2 : " + nic2.GetHashCode());
        }
    }
}
