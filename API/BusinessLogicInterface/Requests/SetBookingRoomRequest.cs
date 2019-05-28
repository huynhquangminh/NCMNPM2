namespace BusinessLogicInterface.Requests
{
    public class SetBookingRoomRequest
    {
        public int soPhong { get; set; }
        public string ngayVao { get; set; }
        public string ngayRa { get; set; }
        public string tenKhachHang { get; set; }
        public string cMND { get; set; }
        public string idNV { get; set; }
    }
}