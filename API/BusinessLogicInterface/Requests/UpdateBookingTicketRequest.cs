namespace BusinessLogicInterface.Requests
{
    public class UpdateBookingTicketRequest
    {
        public int ID { get; set; }
        public int TinhTrang { get; set; }
        public int TinhTrangDatPhong { get; set; }
    }
}