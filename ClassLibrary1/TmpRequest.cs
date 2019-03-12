using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Network.Packets;

namespace ClassLibrary1
{
    public class TmpRequest : RequestPacket
    {
        public TmpRequest()
        {
            
        }

        public Result Result { get; set; }
    }
}
