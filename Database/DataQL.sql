create database QuanLyBanGiay
go
use QuanLyBanGiay
go
create table KhachHang
(
	idkh varchar(10) primary key,
	tenkh nvarchar(100),
	gioitinhkh bit,
	diachikh nvarchar(100),
	sdtkh varchar(10),
)

create table NhaCungCap
(
	idncc varchar(10) primary key,
	tenncc nvarchar(100),
	diachi nvarchar(100),
	email nvarchar(100)
)

create table SanPham
(
	idsp varchar(10) primary key,
	tensp nvarchar(100),
	size int,
	soluongtrongkho int,
	dongiaban money,
)

create table NhanVien
(
	idnv varchar(10) primary key,
	tennv nvarchar(100),
	gioitinhnv bit,
	tuoi int,
	diachi nvarchar(100),
	sdtnv varchar(10)
)

create table DonHangNhap
(
	idnhap int identity(1,1) primary key,
	idnv varchar(10),
	foreign key(idnv) references NhanVien(idnv) on delete cascade,
	idncc varchar(10),
	foreign key(idncc) references NhaCungCap(idncc) on delete cascade,
	ngaynhap date,
	tongtiennhap money,
)

create table DonHangBan
(
	idban int identity(1,1) primary key,
	idnv varchar(10),
	foreign key(idnv) references NhanVien(idnv) on delete cascade,
	idkh varchar(10),
	foreign key(idkh) references KhachHang(idkh) on delete cascade,
	ngayban date,
	tongtienban money,
)

create table ChiTietNhap
(
	idnhap int ,
	foreign key(idnhap) references DonHangNhap(idnhap) on delete cascade,
	idsp varchar(10),
	foreign key(idsp) references SanPham(idsp) on delete cascade,
	dongianhap money,
	soluongnhap int,
)

create table ChiTietBan
(
	idban int,
	foreign key(idban) references DonHangBan(idban) on delete cascade,
	idsp varchar(10),
	foreign key(idsp) references SanPham(idsp) on delete cascade,
	soluongban int
)

create table HinhAnhSanPham
(
	id int identity(1, 1) primary key,
	idsp varchar(10),
	foreign key(idsp) references SanPham(idsp) on delete cascade,
	linkimage varchar(100)
)
create table Account
(
	tendangnhap varchar(10) primary key,
	matkhau varchar(10),
	email varchar(100),
	quyen varchar(100),
	sdtnv varchar(10)
)
