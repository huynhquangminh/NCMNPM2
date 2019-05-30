CREATE PROC [dbo].[GET_LIST_SERVICE_TICKET]
AS
BEGIN
   select p.ID,p.NgayDat,p.SoLuong,p.Gia as 'Tong',p.TinhTrang,p.idNv,d.SoPhong,l.Gia,l.TenDichVu,l.imgDichVu
   from PhieuDichVu p,LoaiDichVu l,DatPhong d
   where p.idDatPhong = d.id and p.idDichVu = l.ID
END

CREATE PROC [dbo].[FIND_SERVICE_TICKET]
  @SoPhong int 
AS
BEGIN
   select p.ID,p.NgayDat,p.SoLuong,p.Gia as 'Tong',p.TinhTrang,p.idNv,d.SoPhong,l.Gia,l.TenDichVu,l.imgDichVu
   from PhieuDichVu p,LoaiDichVu l,DatPhong d
   where p.idDatPhong = d.id and p.idDichVu = l.ID
         and d.SoPhong=@SoPhong
END

CREATE PROC [dbo].[DELETE_SERVICE_TICKET]
  @ID int 
AS
BEGIN
   delete from PhieuDichVu where ID = @ID
END

CREATE PROC [dbo].[UPDATE_SERVICE_TICKET]
  @ID int ,
  @IdDatPhong int,
  @NgayDat character(50),
  @idDichVu int,
  @SoLuong int,
  @Gia int,
  @TinhTrang int,
  @idNv int
AS
BEGIN
   update PhieuDichVu
   set idDatPhong=@IdDatPhong,NgayDat=@NgayDat,idDichVu=idDichVu,SoLuong=@SoLuong,Gia=@Gia,TinhTrang=@TinhTrang,idNv=@idNv
   where ID =@ID
END

CREATE PROC [dbo].[NHAP_PHIEU_DICH_VU] (
 @idDatPhong int,
 @NgayDat character(20),
 @idDichVu int,
 @SoLuong int,
 @Gia int,
 @TinhTrang int,
 @idNv int
) AS
BEGIN
   insert into PhieuDichVu(idDatPhong,NgayDat,idDichVu,SoLuong,Gia,0,idNv)
    values(@idDatPhong,@NgayDat,@idDichVu,@SoLuong,@Gia,@TinhTrang,@idNv)
END

CREATE PROC [dbo].[LAY_DANH_SACH_PHIEU_DICH_VU]  
AS
BEGIN
   select ID,idDatPhong,NgayDat,idDichVu,SoLuong,Gia,TinhTrang,idNv
   from PhieuDichVu
   where TinhTrang=0
END

CREATE PROC [dbo].[TIM_DANH_SACH_PHIEU_DICH_VU] 
  @idDatPhong int 
AS
BEGIN
   select ID,idDatPhong,NgayDat,idDichVu,SoLuong,Gia,TinhTrang,idNv
   from PhieuDichVu
   where idDatPhong =@idDatPhong
END