namespace BusinessLogicInterface.Dtos
{
    public class GetListRoomFromDateDTO
    {
        public int SoPhong { get; set; }
        public int idLoaiPhong { get; set; }
        public int Tang { get; set; }
        public string imgPhong { get; set; }
        public bool TinhTrang { get; set; }
        public string MoTaPhong { get; set; }
        public decimal GiaPhong { get; set; }
        public string TenLoaiPhong { get; set; }
    }
}