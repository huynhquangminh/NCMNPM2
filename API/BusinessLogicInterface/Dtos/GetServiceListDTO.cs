using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicInterface.Dtos
{
    public class GetServiceListDTO
    {
            public int ID { get; set; }
            public string TenDichVu { get; set; }
            public string DonViTinh { get; set; }
            public string Gia { get; set; }
            public decimal imgDichVu { get; set; }
    }
}
