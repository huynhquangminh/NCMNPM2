using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicInterface.Dtos
{
    public class GetListPostsDTO
    {
        public int id { get; set; }
        public string TenBaiViet { get; set; }
        public string NoiDung { get; set; }
        public string NoiDungChiTiet { get; set; }
        public System.DateTime NgayTao { get; set; }
        public string HinhAnh { get; set; }
    }
}
