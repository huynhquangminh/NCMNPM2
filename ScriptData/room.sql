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