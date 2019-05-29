using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcceessInterface.Parameter
{
    public class UpdateServiceSticketParameter
    {
        public int ID { get; set; }
        public int idDatPhong { get; set; }
        public string NgayDat { get; set; }
        public int idDichVu { get; set; }
        public int SoLuong { get; set; }
        public int Gia { get; set; }
        public int TinhTrang { get; set; }
        public int idNV { get; set; }
    }
}
