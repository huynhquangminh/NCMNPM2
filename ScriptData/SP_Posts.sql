CREATE PROC GET_LIST_POSTS
AS
BEGIN
  select id,TenBaiViet,NoiDung,NoiDungChiTiet,NgayTao,HinhAnh from BaiViet 
END