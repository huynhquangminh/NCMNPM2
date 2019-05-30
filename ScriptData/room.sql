CREATE PROC [dbo].[GET_LIST_ROOM_FROM_DATE]
  @NgayVao character(20),
  @NgayRa character(20)
AS
BEGIN
   select p.SoPhong,p.idLoaiPhong,p.Tang,p.imgPhong,p.TinhTrang,p.MoTaPhong
   from Phong p
   where SoPhong Not in (
         select pd.SoPhong 
		 from PhieuDatPhongKhachSan pd
		 where (CONVERT(date,@NgayVao) BETWEEN  pd.NgayVao AND pd.NgayRa) AND (CONVERT(date,@NgayRa) NOT BETWEEN  pd.NgayVao AND pd.NgayRa)
		 UNION 
		 Select d.SoPhong 
		 from DatPhong d
		 where (CONVERT(date,@NgayVao) BETWEEN  d.NgayVao AND d.NgayRa) AND (CONVERT(date,@NgayRa) NOT BETWEEN  d.NgayVao AND d.NgayRa))
END

CREATE PROC [dbo].[TINH_TIEN_PHONG](
   @ID int,
   @SoPhong int,
   @NgayVao character(20),
   @NgayRa character(20)
)
AS
BEGIN
      select d.SoPhong,d.NgayVao,d.NgayRa,(DATEDIFF(DAY,d.NgayRa,d.NgayVao)*l.GiaPhong) as 'TienPhong',
		 dbo.[dbo.TINH_TIEN_DICH_VU](@ID) as 'TienDichVu',0 as 'PhuThu',(DATEDIFF(DAY,d.NgayRa,d.NgayVao)*l.GiaPhong)+dbo.[dbo.TINH_TIEN_DICH_VU](@ID) as 'TongTien',0 as TinhTrang,'' as GhiChu,d.idNv
	from DatPhong d
	left join Phong p on d.SoPhong = p.SoPhong
	left join LoaiPhong l on p.idLoaiPhong = l.ID
	where d.ID=@ID
END



CREATE PROC [dbo].[NHAP_HOA_DON](
   @ID int,
   @SoPhong int,
   @NgayVao character(20),
   @NgayRa character(20),
   @TienPhong character(20),
   @TienDichVu character(20),
   @PhuThu character(20),
   @TongTien int,
   @TinhTrang int,
   @GhiChu character(50),
   @idNV int
)
AS
BEGIN
    insert into HoaDon(SoPhong,NgayVao,NgayRa,TienPhong,TienDichVu,PhuThu,TongTien,TinhTrang,GhiChu,idNV) 
	values(@SoPhong,@NgayRa,@NgayVao,@TienPhong,@TienDichVu,@PhuThu,@TongTien,@TinhTrang,@GhiChu,@idNV)  
END

CREATE FUNCTION [dbo].[dbo.TINH_TIEN_DICH_VU] (
 @ID int
)
RETURNS INTEGER AS
BEGIN
     DECLARE @data INTEGER
     select @data = SUM(Gia) 
     from PhieuDichVu
     where idDatPhong = @ID
    RETURN @data
END