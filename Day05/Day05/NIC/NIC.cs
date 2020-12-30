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
        //singleton design pattern
        NIC(string _manufacture,string _macAddress,Type _kind) {
            manufacture = _manufacture;
            macAddress = _macAddress;
            kind = _kind;
        }
        public static NIC createNIC { get; } = new NIC("IEEE", "111",Type.Ethernet);




    }
}
