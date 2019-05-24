using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicInterface.Dtos
{
    public class GetInfoFromRoomNoDTO
    {
        public int SoPhong { get; set; }
        public int Tang { get; set; }
        public string imgPhong { get; set; }
        public bool TinhTrang { get; set; }
        public string MoTaPhong { get; set; }
        public string TenLoaiPhong { get; set; }
        public Nullable<decimal> GiaPhong { get; set; }
    }
}
