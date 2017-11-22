create database tourdulich

--tour

create table loaihinhdulich
( 
	id int primary key identity(1,1),
	tenloaihinh nvarchar(100)
)

create table tinhthanh
(
	id int primary key identity(1,1),
	matt nvarchar(50) unique,
	tentt nvarchar(100),

)

create table tour
(
	id int primary key identity(1,1),
	tentour nvarchar(100),
	dacdiem nvarchar(100),
	idlh int,
	
	foreign key (idlh) references loaihinhdulich(id)
)

create table diadiem
(
	id int primary key identity(1,1),
	tendiadiem nvarchar(100),
	idtt int,

	foreign key (idtt) references tinhthanh(id)
)

create table giatour
(
	id int primary key identity(1,1),
	idtour int,
	gia decimal(10,0),
	tungay datetime,
	denngay datetime,

	foreign key (idtour) references tour(id)
)

create table chitietdiemthamquan
(
	id int primary key identity(1,1),
	idtour int, 
	iddiadiem int,

	foreign key (idtour) references tour(id),
	foreign key (iddiadiem) references diadiem(id)
)

--doan du lich
create table gioitinh
(
	id int primary key identity(1,1),
	tengioitinh nvarchar(20)
)

insert into gioitinh values (N'Nam')
insert into gioitinh values (N'Nữ')

create table khachhang
(
	id int primary key identity(1,1),
	tenkhachhang nvarchar(100),
	socmnd nvarchar(100),
	diachi nvarchar(200),
	gioitinh int,
	sodienthoai nvarchar(20)

	foreign key (gioitinh) references gioitinh(id)
)

create table nhanvien
(
	id int primary key identity(1,1),
	tennhanvien nvarchar(100),
	socmnd nvarchar(100),
	diachi nvarchar(200),
	gioitinh int,
	sodienthoai nvarchar(20),
	

	foreign key (gioitinh) references gioitinh(id)
)

create table doandulich
(
	id int primary key identity(1,1),
	idtour int,
	ngaykhoihanh datetime,
	ngayketthuc datetime,
	chuongtrinhthamquan nvarchar(max),

	foreign key (idtour) references tour(id)
)

create table chitietdoandulich
(
	id int primary key identity(1,1),
	iddoandulich int,
	idkhachhang int,

	foreign key (iddoandulich) references doandulich(id),
	foreign key (idkhachhang) references khachhang(id)
)

create table nhiemvu
(
	id int primary key identity(1,1),
	tennhiemvu nvarchar(100)
)

create table phancong
(
	id int primary key identity(1,1),
	idnhanvien int,
	idnhiemvu int,
	iddoandulich int,

	foreign key (idnhiemvu) references nhiemvu(id),
	foreign key (idnhanvien) references nhanvien(id),
	foreign key (iddoandulich) references doandulich(id),
)

create table loaiphieu
(
	id int primary key identity(1,1),
	tenloaiphieu nvarchar(100)
)

insert into loaiphieu values (N'Phiếu thanh toán cho khách sạn')
insert into loaiphieu values (N'Phiếu thanh toán cho các bữa ăn')
insert into loaiphieu values (N'Phiếu thanh toán cho các phương tiện')
insert into loaiphieu values (N'Phiếu thanh toán cho chi phí khác')

create table phieuthanhtoan
(
	id int primary key identity(1,1),
	tenphieu nvarchar(100),
	idloaiphieu int,
	iddoandulich int,
	ngaytao datetime,

	foreign key (idloaiphieu) references loaiphieu(id),
	foreign key (iddoandulich) references doandulich(id)
)

create table chitietthanhtoan
(
	id int primary key identity(1,1),
	idphieuthanhtoan int,
	idchitiet int,
	tenchiphi nvarchar(100),
	soluong int,
	gia decimal(10,0),

	foreign key (idphieuthanhtoan) references phieuthanhtoan(id)

)

alter table doandulich add tendoan nvarchar(200)