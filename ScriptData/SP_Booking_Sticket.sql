CREATE PROC [dbo].[INSERT_BOOKING_STICKET]
 @SoPhong int,
 @NgayVao character(50),
 @NgayRa character(50),
 @TinhTrang int,
 @idKhachHang character(20)
AS
BEGIN
	insert into PhieuDatPhongKhachSan(SoPhong,NgayVao,NgayRa,TinhTrang,idKhachHang)
	values(@SoPhong,@NgayVao,@NgayRa,0,@idKhachHang)
END
--Cập nhật trạng thái của phiếu đặt phòng
CREATE PROC [dbo].[UPDATE_STATUS_BOOKING_STICKET]
 @ID int,
 @TinhTrang int
AS
BEGIN
	update PhieuDatPhongKhachSan set TinhTrang=1
END