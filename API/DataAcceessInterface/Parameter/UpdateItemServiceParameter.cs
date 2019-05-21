using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcceessInterface.Parameter
{
    public class UpdateItemServiceParameter
    {
        public int id { get; set; }
        public string tenDichVu { get; set; }
        public string donViTinh { get; set; }
        public int gia { get; set; }
        public string imgDichVu { get; set; }
    }
}
