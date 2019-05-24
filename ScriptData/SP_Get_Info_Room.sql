-- get info from room no
CREATE PROC [dbo].[GET_INFO_FROM_ROOM_NO]
 @RoomNo int
AS
BEGIN
   select p.SoPhong,p.Tang,p.imgPhong,p.TinhTrang,p.MoTaPhong,l.TenLoaiPhong,l.GiaPhong
   from Phong p
   left join LoaiPhong l on p.idLoaiPhong=l.ID  
   where p.SoPhong=@RoomNo
END

-- get list order from identity card
CREATE PROC [dbo].[GET_LIST_ORDER_FROM_IDENTITYCARD]
   @CMND character(20)
AS
BEGIN
   select k.CMND,k.UserName,k.SDT,k.Address,k.imgKhachHang,p.SoPhong,p.NgayVao,p.NgayRa,p.TinhTrang,p.idKhachHang 
   from KhachHang k
   left join PhieuDatPhongKhachSan p on k.CMND = p.ID
END