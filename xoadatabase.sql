delete from chitietthanhtoan
delete from phieuthanhtoan
delete from phancong
delete from nhiemvu
delete from doandulich
delete from nhanvien
delete from khachhang
delete from chitietdiemthamquan
delete from giatour
delete from diadiem
delete from tour
delete from tinhthanh
delete from loaihinhdulich

DBCC CHECKIDENT ('[chitietthanhtoan]', RESEED, 0);
DBCC CHECKIDENT ('[phieuthanhtoan]', RESEED, 0);
DBCC CHECKIDENT ('[phancong]', RESEED, 0);
DBCC CHECKIDENT ('[doandulich]', RESEED, 0);
DBCC CHECKIDENT ('[nhanvien]', RESEED, 0);
DBCC CHECKIDENT ('[khachhang]', RESEED, 0);
DBCC CHECKIDENT ('[chitietdiemthamquan]', RESEED, 0);
DBCC CHECKIDENT ('[giatour]', RESEED, 0);
DBCC CHECKIDENT ('[diadiem]', RESEED, 0);
DBCC CHECKIDENT ('[tour]', RESEED, 0);
DBCC CHECKIDENT ('[tinhthanh]', RESEED, 0);
DBCC CHECKIDENT ('[loaihinhdulich]', RESEED, 0);


