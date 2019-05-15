using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicInterface.Dtos
{
    public class GetListRoomDTO
    {
        public int ID { get; set; }
        public string TenLoaiPhong { get; set; }
        public decimal GiaPhong { get; set; }
        public string imgLoaiPhong { get; set; }
    }
}
