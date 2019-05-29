using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicInterface.Dtos
{
    public class GetListServiceTicketDTO
    {
        public int ID { get; set; }
        public System.DateTime NgayDat { get; set; }
        public int SoLuong { get; set; }
        public decimal Tong { get; set; }
        public int TinhTrang { get; set; }
        public int idNv { get; set; }
        public int SoPhong { get; set; }
        public decimal Gia { get; set; }
        public string TenDichVu { get; set; }
        public string imgDichVu { get; set; }
    }
}
