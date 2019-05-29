using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicInterface.Dtos
{
    public class GetListRoomFromDateDTO
    {
        public int SoPhong { get; set; }
        public int idLoaiPhong { get; set; }
        public int Tang { get; set; }
        public string imgPhong { get; set; }
        public bool TinhTrang { get; set; }
        public string MoTaPhong { get; set; }
    }
}
