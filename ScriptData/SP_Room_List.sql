
--Add room

CREATE PROC [dbo].[ADD_LIST_ROOM](
 @TenLoaiPhong character(200),
 @GiaPhong int,
 @imgLoaiPhong character(20) 
)
AS
BEGIN
  insert into LoaiPhong(TenLoaiPhong,GiaPhong,imgLoaiPhong) values(@TenLoaiPhong,@GiaPhong,@imgLoaiPhong)
END

--Delete room

CREATE PROC [dbo].[DELETE_ITEM_ROOM](
	@ID int
)
AS
BEGIN
  delete LoaiPhong where ID=@ID
END


--Update room
CREATE PROC [dbo].[UPDATE_ITEM_ROOM](
	 @ID int,
	 @TenLoaiPhong character(200),
	 @GiaPhong int,
	 @imgLoaiPhong character(20) 
)
AS
BEGIN
  update LoaiPhong set TenLoaiPhong=@TenLoaiPhong,GiaPhong=@GiaPhong,imgLoaiPhong=@imgLoaiPhong where ID=@ID
END