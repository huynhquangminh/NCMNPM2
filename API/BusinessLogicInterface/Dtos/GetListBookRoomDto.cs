namespace BusinessLogicInterface.Dtos
{
    public class GetListBookRoomDto
    {
        public int ID { get; set; }
        public int SoPhong { get; set; }
        public System.DateTime NgayVao { get; set; }
        public System.DateTime NgayRa { get; set; }
        public string TenKhachHang { get; set; }
        public string CMND { get; set; }
        public int idNV { get; set; }
        public bool TinhTrang { get; set; }
    }
}