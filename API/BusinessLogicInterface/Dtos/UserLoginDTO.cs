using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicInterface.Dtos
{
    public class UserLoginDTO
    {
        public string TenNhanVien { get; set; }
        public string UserName { get; set; }
        public string CMND { get; set; }
        public int idLoaiNV { get; set; }
        public string SDT { get; set; }
        public string Address { get; set; }
    }
}
