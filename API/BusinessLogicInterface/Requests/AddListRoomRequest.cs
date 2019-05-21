using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicInterface.Requests
{
    public class AddListRoomRequest
    {
        public string tenLoaiPhong { get; set; }
        public int giaPhong { get; set; }
        public string imgLoaiPhong { get; set; }
    }
}
