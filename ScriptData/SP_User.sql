--Login 
CREATE PROC [dbo].[USER_LOGIN]
  @UserName character(50),
  @Password character(50)
AS
BEGIN
  select TenNhanVien,UserName,CMND,idLoaiNV,SDT,Address 
  from NhanVien where UserName=@UserName and Password=@Password
END

--Register user
CREATE PROC [dbo].[USER_REGISTER]
  @TenNhanVien character(200),
  @UserName character(50),
  @Password character(20),
  @CMND character(20),
  @idLoaiNV int,
  @SDT character(20),
  @Address character(15)
AS
BEGIN
   insert into NhanVien(TenNhanVien,UserName,Password,CMND,idLoaiNV,SDT,Address) 
   values(@TenNhanVien,@UserName,@Password,@CMND,@idLoaiNV,@SDT,@Address)
END