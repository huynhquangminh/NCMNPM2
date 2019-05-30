namespace BusinessLogicInterface.Dtos
{
    public class GetListBookingTicketDTO
    {
        public int ID { get; set; }
        public int SoPhong { get; set; }
        public System.DateTime NgayVao { get; set; }
        public System.DateTime NgayRa { get; set; }
        public int TinhTrang { get; set; }
        public string CMND { get; set; }
        public bool TinhTrangDatPhong { get; set; }
    }
}