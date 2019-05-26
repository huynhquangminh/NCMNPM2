--Đặt phòng
CREATE PROC [dbo].[SET_BOOKING_ROOM]
 @SoPhong int,
 @NgayVao character(50),
 @NgayRa character(50),
 @TenKhachHang character(50),
 @CMND character(50),
 @idNV character(50)
AS
BEGIN
	insert into DatPhong(SoPhong,NgayVao,NgayRa,TenKhachHang,CMND,idNV)
	values(@SoPhong,@NgayVao,@NgayRa,@TenKhachHang,@CMND,@idNV)
END

--Cập nhật đặt phòng
CREATE PROC [dbo].[UPDATE_BOOKING_ROOM]
 @ID int,
 @SoPhong int,
 @NgayVao character(50),
 @NgayRa character(50),
 @TenKhachHang character(50),
 @CMND character(50),
 @idNV character(50)
AS
BEGIN
	update DatPhong 
	set SoPhong=@SoPhong,
		NgayVao=@NgayVao,
		NgayRa=@NgayRa,
		TenKhachHang=@TenKhachHang,
		CMND=@CMND,
		idNV=@idNV
	where ID=@ID
END
