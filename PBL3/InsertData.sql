
use [QuanLyBanGiay]
go
insert SanPham values
('sp01', 'Stan Smith Pink', 40, 10,  1680000),
('sp02', 'Falcon Black Grey', 41, 30,  6500000),
('sp03', 'Yung 1 Cloud White', 37, 20,  3200000),
('sp04', 'MLB Mule NY – Pink', 39, 10,  1520000),
('sp05', 'adidas Continental 80', 40, 20,  4780000),
('sp06', 'Air Force 1 Crater', 45, 15,  4410000),
('sp07', 'Converse Chuck Taylor', 44, 25,  3300000),
('sp08', 'Domba High Point', 41, 30,  2570000),
('sp09', 'Falcon Multicolor', 42, 25,  1520000),
('sp10', 'Fila Ray Script', 40, 10,  1470000)

insert NhanVien values
('nv01', 'Do Phu Thanh', 1, 20, 'Hue', '0968018419'),
('nv02', 'Tran Trung Quan', 1, 20, 'Quang Tri', '0988538948'),
('nv03', 'Nguyen Viet Buu', 1, 20, 'Quang Ngai', '0834824363')

insert NhaCungCap values
('ncc01', 'Adidas', 'Thanh pho Ho Chi Minh', 'adidasvn@gmail.com'),
('ncc02', 'MLB', 'Thanh pho Da Nang', 'mlbdanang@gmail.com'),
('ncc03', 'Vina giay', 'Thanh pho Can Tho', 'vinactho@gmail.com'),
('ncc04', 'Vascara', 'Thanh Hoa', 'vascara@gmail.com'),
('ncc05', 'Jnno', 'Thanh pho Ho Chi Minh', 'junohcm@gmail.com')

insert KhachHang values
('kh01', 'Nguyen Van Nam', 1, 'Thanh Hoa', '0125795874'),
('kh02', 'Le Nhu Tam', 0, 'Da Nang', '0568458856'),
('kh03', 'Nguyen Ngoc Nu', 0, 'Nghe An', '0545626556'),
('kh04', 'Le Vu Duc', 1, 'Hue', '0745562659'),
('kh05', 'Ngo Gia Lam', 1, 'Da Nang', '0688987652')
insert HinhAnhSanPham(idsp, linkimage) values 
('sp01', 'sp01.jpg'),
('sp02', 'sp02.jpg'),
('sp03', 'sp03.jpg'),
('sp04', 'sp04.jpg'),
('sp05', 'sp05.jpg'),
('sp06', 'sp06.jpg'),
('sp07', 'sp07.jpg'),
('sp08', 'sp08.jpg'),
('sp09', 'sp09.jpg'),
('sp10', 'sp10.jpg')
insert Account values
('admin', '1', 'a1@gm', 'admin', ''),
('user1', '1', 'u1@gm', 'user','0968018419'),
('user2', '1', 'u2@gm', 'user','0988538948'),
('user3', '1', 'u3@gm', 'user', '0834824363')