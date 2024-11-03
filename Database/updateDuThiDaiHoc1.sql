create database DuThiDaiHoc;
go
use DuThiDaiHoc;
go

-- Bảng KhuVuc
create table KhuVuc (
	MaKhuVuc nvarchar(255) primary key,
	TenKhuVuc nvarchar(255)
);
go

-- Bảng UuTien
create table UuTien (
	MaUuTien nvarchar(255) primary key,
	TenUuTien nvarchar(255),
	DiemUuTien float
);
go

-- Bảng DiemChuan
create table DiemChuan (
	MaNganh nvarchar(255) primary key,
	TenNganh nvarchar(255),
	TongDiem float,
	TenTruong nvarchar(255),
	ChiTieu int
);
go



-- Bảng DoiTuong
create table DoiTuong (
	MaDoiTuong nvarchar(255) primary key,
	TenDoiTuong nvarchar(255)
);
go

-- Bảng QueQuan
create table QueQuan (
	MaQue nvarchar(255) primary key,
	TenQue nvarchar(255)
);
go

-- Bảng HoSoThiSinh
create table HoSoThiSinh (
	SoBD int primary key,
	HoTen nvarchar(255),
	NgaySinh datetime,
	GioiTinh nvarchar(255),
	MaQueQuan nvarchar(255),
	MaKhuVuc nvarchar(255),
	MaUuTien nvarchar(255),
	MaDoiTuong nvarchar(255),
	MatKhau nvarchar(255), 
	GhiChu nvarchar(max), 
	
	constraint FK_QueQuan_MaQue foreign key (MaQueQuan) references QueQuan(MaQue),
	constraint FK_KhuVuc_MaKhuVuc foreign key (MaKhuVuc) references KhuVuc(MaKhuVuc),
	constraint FK_UuTien_MaUuTien foreign key (MaUuTien) references UuTien(MaUuTien),
	constraint FK_DoiTuong_MaDoiTuong foreign key (MaDoiTuong) references DoiTuong(MaDoiTuong)
);
go

-- Bảng NguyenVong
create table NguyenVong (
	MaNganh nvarchar(255) unique,
	TenNguyenVong nvarchar(255) unique,
	ThuTuNV int,
	SoBD int,
	foreign key (SoBD) references HoSoThiSinh(SoBD),
	constraint FK_DiemChuan_MaNguyenVong foreign key (MaNganh) references DiemChuan(MaNganh)
);
go
-- Bảng DiemThi
create table DiemThi (
	SoBD int,
	DiemToan float,
	DiemLy float,
	DiemHoa float,
	constraint FK_HoSoTT_SoBD foreign key (SoBD) references HoSoThiSinh(SoBD)
);
go





-- Dữ liệu cho bảng KhuVuc
insert into KhuVuc (MaKhuVuc, TenKhuVuc) 
values (N'KV01', N'Khu vực 1'), 
(N'KV02', N'Khu vực 2'), 
(N'KV02-NT', N'Khu vực 2 - Nông Thôn'),
(N'KV03', N'Khu vực 3');

--Khu vực 1 (KV1): Cộng ưu tiên 0,75 điểm. ...
--Khu vực 2 (KV2): Cộng ưu tiên 0,25 điểm. ...
--Khu vực 2 nông thôn (KV2-NT): Cộng ưu tiên 0,5 điểm. ...
--Khu vực 3: thành phố Không được công điểm ưu tiên.
go

-- Dữ liệu cho bảng UuTien
insert into UuTien (MaUuTien, TenUuTien, DiemUuTien)
values(N'UT01', N'không', 0),
(N'UT02', N'Ngành thiếu nhân lực', 1.0),
(N'UT03', N'học sinh giỏi quốc gia', 1.5);
go

-- Dữ liệu cho bảng DiemChuan
insert into DiemChuan (MaNganh, TenNganh,TongDiem,TenTruong, ChiTieu)
values
(N'IT1', N'Công nghệ thông tin', 26.0, N'Đại Học Giao Thông Vận Tải', 500),
(N'IT2', N'Công nghệ thông tin', 25.9, N'Đại Học Công Nghiệp', 450),
(N'IT3', N'Công nghệ thông tin', 25.8, N'Đại Học Điện Lực', 440),
(N'KTE1', N'Kinh tế',24.5,N'Đai Học Giao Thông Vận Tải' ,600),
(N'KTE2', N'Kinh tế',24.4,N'Đai Học Công Nghiệp' ,580),
(N'KTE3', N'Kinh tế',24.3,N'Đai Học Điện Lực' ,560),
(N'MK1', N'Marketing',26.0,N'Đại Học Thương Mại',560),
(N'MK2', N'Marketing',24.7,N'Đại Học Giao Thông Vận Tải',560),
(N'MK3', N'Marketing',24.6,N'Đại Học Công Nghiệp',540),
(N'MK4', N'Marketing',24.5,N'Đại Học Điện Lực',530),
(N'CT1', N'Công Trình',23.5,N'Đại Học Giao Thông Vận Tải',250),
(N'CK1', N'Cơ Khí',22.7,N'Đại Học Điện Lực',170),
(N'CK2', N'Cơ Khí',22.6,N'Đại Học Giao Thông Vận Tải',170),
(N'CK3', N'Cơ Khí',22.5,N'Đại Học Công Nghiệp',170),
(N'CDT1', N'Cơ Điện Tử',23.8,N'Đại Học Giao Thông Vận Tải',240),
(N'CDT2', N'Cơ Điện Tử',23.1,N'Đại Điện Lực',240),
(N'CDT3', N'Cơ Điện Tử',23.2,N'Đại Học Công Nghiệp',240),
(N'OT1', N'Kĩ Thuật Ô tô',24.4,N'Đại Học Giao Thông Vận Tải',220),
(N'OT2', N'Kĩ Thuật Ô tô',24.3,N'Đại Học Công Nghiệp',230),
(N'OT3', N'Kĩ Thuật Ô tô',24.2,N'Đại Học Điện Lực',240),
(N'CD1', N'Cầu Đường', 22.0,N'Đại Học Giao Thông Vận Tải',180),
(N'KHMT1', N'Khoa Học Máy Tính',25.8,N'Đại Học Giao Thông Vận Tải',330),
(N'KHMT2', N'Khoa Học Máy Tính',25.2,N'Đại Học Công Nghiệp',320),
(N'KHMT3', N'Khoa Học Máy Tính',25.4,N'Đại Học Điện Lực',350),
(N'KT1', N'Kế Toán', 24.85,N'Đại Học Giao Thông Vận Tải',400),
(N'KT2', N'Kế Toán', 24.4,N'Đại Học Điện Lực ',300),
(N'KT3', N'Kế Toán', 24.55,N'Đại Học Công Nghiệp',330),
(N'KT4', N'Kế Toán', 24.25,N'Đại Học Thương Mại',320);
go

-- Dữ liệu cho bảng DoiTuong
insert into DoiTuong (MaDoiTuong, TenDoiTuong)
values(N'DT01', N'Không'), -- không cộng
(N'DT02', N'Dân tộc thiểu số'), -- dân tộc thiểu số : điểm +1
(N'DT03', N'Con thương binh, bệnh binh'); -- con thương binh, bệnh binh : điểm +2
go

-- Dữ liệu cho bảng QueQuan
insert into QueQuan (MaQue, TenQue)
values(N'Q01', N'Hà Nội'),
(N'Q02', N'TP.HCM'),
(N'Q03', N'Đà Nẵng'),
(N'Q04', N'Hải Phòng'),
(N'Q05', N'Cần Thơ'),
(N'Q06', N'An Giang'),
(N'Q07', N'Bà Rịa - Vũng Tàu'),
(N'Q08', N'Bắc Giang'),
(N'Q09', N'Bắc Kạn'),
(N'Q10', N'Bạc Liêu'),
(N'Q11', N'Bắc Ninh'),
(N'Q12', N'Bến Tre'),
(N'Q13', N'Bình Định'),
(N'Q14', N'Bình Dương'),
(N'Q15', N'Bình Phước'),
(N'Q16', N'Bình Thuận'),
(N'Q17', N'Cà Mau'),
(N'Q18', N'Cao Bằng'),
(N'Q19', N'Đắk Lắk'),
(N'Q20', N'Đắk Nông'),
(N'Q21', N'Điện Biên'),
(N'Q22', N'Đồng Nai'),
(N'Q23', N'Đồng Tháp'),
(N'Q24', N'Gia Lai'),
(N'Q25', N'Hà Giang'),
(N'Q26', N'Hà Nam'),
(N'Q27', N'Hà Tĩnh'),
(N'Q28', N'Hải Dương'),
(N'Q29', N'Hậu Giang'),
(N'Q30', N'Hòa Bình'),
(N'Q31', N'Hưng Yên'),
(N'Q32', N'Khánh Hòa'),
(N'Q33', N'Kiên Giang'),
(N'Q34', N'Kon Tum'),
(N'Q35', N'Lai Châu'),
(N'Q36', N'Lâm Đồng'),
(N'Q37', N'Lạng Sơn'),
(N'Q38', N'Lào Cai'),
(N'Q39', N'Long An'),
(N'Q40', N'Nam Định'),
(N'Q41', N'Nghệ An'),
(N'Q42', N'Ninh Bình'),
(N'Q43', N'Ninh Thuận'),
(N'Q44', N'Phú Thọ'),
(N'Q45', N'Phú Yên'),
(N'Q46', N'Quảng Bình'),
(N'Q47', N'Quảng Nam'),
(N'Q48', N'Quảng Ngãi'),
(N'Q49', N'Quảng Ninh'),
(N'Q50', N'Quảng Trị'),
(N'Q51', N'Sóc Trăng'),
(N'Q52', N'Sơn La'),
(N'Q53', N'Tây Ninh'),
(N'Q54', N'Thái Bình'),
(N'Q55', N'Thái Nguyên'),
(N'Q56', N'Thanh Hóa'),
(N'Q57', N'Thừa Thiên Huế'),
(N'Q58', N'Tiền Giang'),
(N'Q59', N'Trà Vinh'),
(N'Q60', N'Tuyên Quang'),
(N'Q61', N'Vĩnh Long'),
(N'Q62', N'Vĩnh Phúc'),
(N'Q63', N'Yên Bái');
go

-- Dữ liệu cho bảng HoSoThiSinh
insert into HoSoThiSinh (SoBD, HoTen, NgaySinh, GioiTinh, MaQueQuan, MaKhuVuc, MaUuTien, MaDoiTuong, MatKhau, GhiChu)
values(1001, N'Nguyễn Văn A', cast('2003-05-15' as datetime), N'Nam', N'Q01', N'KV01', N'UT01', N'DT01', '123', N''),
(1002, N'Trần Thị B', cast('2002-10-22' as datetime), N'Nữ', N'Q02', N'KV02', N'UT02', N'DT02', '123', N''),
(1003, N'Lê Văn C', cast('2004-01-18' as datetime), N'Nam', N'Q03', N'KV03', N'UT03', N'DT03', '123', N'');
go

-- Dữ liệu cho bảng DiemThi
insert into DiemThi (SoBD, DiemToan, DiemLy, DiemHoa)
values(1001, 8.5, 7.0, 8.0),
(1002, 9.0, 8.5, 7.5),
(1003, 7.5, 8.0, 7.0);
go

-- nguyen vong thi sinh
insert into NguyenVong(MaNganh,TenNguyenVong,ThuTuNV,SoBD) values ('CT1',N'Công Trình',1,1001),('OT1',N'Kĩ Thuật Ô Tô',2,1001),('CK1','Cơ Khí',3,1001)
