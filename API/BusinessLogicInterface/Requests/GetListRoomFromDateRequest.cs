using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicInterface.Requests
{
    public class GetListRoomFromDateRequest
    {
        public string NgayVao { get; set; }
        public string NgayRa { get; set; }
    }
}
