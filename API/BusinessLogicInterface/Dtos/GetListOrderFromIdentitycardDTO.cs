using System;

namespace BusinessLogicInterface.Dtos
{
    public class GetListOrderFromIdentitycardDTO
    {
        public string CMND { get; set; }
        public string UserName { get; set; }
        public string SDT { get; set; }
        public string Address { get; set; }
        public string imgKhachHang { get; set; }
        public Nullable<int> SoPhong { get; set; }
        public Nullable<System.DateTime> NgayVao { get; set; }
        public Nullable<System.DateTime> NgayRa { get; set; }
        public Nullable<int> TinhTrang { get; set; }
        public string idKhachHang { get; set; }
    }
}