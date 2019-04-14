using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Network;
using Network.Attributes;
using Network.Packets;

namespace ClassLibrary1
{
    [PacketRequest(typeof(TmpRequest))]
    public class TmpResponse : ResponsePacket
    {
        public TmpResponse(TmpRequest request, List<string> test) : base(request)
        {
            Test = test;
        }

        public Result Result { get; set; }
        public List<string> Test { get; set; }
    }
}
