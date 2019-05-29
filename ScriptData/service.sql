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