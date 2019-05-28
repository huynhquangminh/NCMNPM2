namespace BusinessLogicInterface.Requests
{
    public class InsertBookingTicketRequest
    {
        public int SoPhong { get; set; }
        public string NgayVao { get; set; }
        public string NgayRa { get; set; }
        public int TinhTrang { get; set; }
        public string idKhachHang { get; set; }
    }
}