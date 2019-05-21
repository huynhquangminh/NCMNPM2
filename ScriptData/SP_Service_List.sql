
--Add list item service
CREATE PROC [dbo].[ADD_LIST_SERVICE](
 @TenDichVu character(200),
 @DonViTinh character(20),
 @Gia int,
 @imgDichVu character(20) 
)
AS
BEGIN
  insert into LoaiDichVu(TenDichVu,DonViTinh,Gia,imgDichVu) values(@TenDichVu,@DonViTinh,@Gia,@imgDichVu)
END

--Delete item service
CREATE PROC [dbo].[DELETE_ITEM_SERVICE](
 @ID int 
)
AS
BEGIN
  delete from LoaiDichVu where ID=@ID
END

--Update item service
CREATE PROC [dbo].[UPDATE_ITEM_SERVICE](
	 @ID int,
	 @TenDichVu character(200),
	 @DonViTinh character(20),
	 @Gia int,
	 @imgDichVu character(20) 
)
AS
BEGIN
  update LoaiDichVu set TenDichVu=@TenDichVu,DonViTinh=@DonViTinh,Gia=@Gia,imgDichVu=@imgDichVu where ID=@ID
END