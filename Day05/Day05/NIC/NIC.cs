using System;
using System.Collections.Generic;
using System.Text;

namespace NetworkInterfaceCard
{
    enum Type { Ethernet , TokenRang}
    class NIC
    {
        Type kind;
        string macAddress;
        string manufacture;


        //public static NIC NICard { get; } = new NIC("IEEE","xxx123456789","");
        public string Manufacture
        {
            set { manufacture = value; }
            get { return manufacture; }
        }



    }
}
