CREATE DATABASE QLPMT

USE QLPMT


CREATE TABLE NHOMNGUOIDUNG
(
	id int IDENTITY(1,1) primary key,
	MaNhomNguoiDung AS CAST('NND' + right('000' + CAST(id as varchar(5)), 3) AS CHAR(6)) persisted ,
	TenNhomNguoiDung nvarchar(max) NOT NULL
);


CREATE TABLE CHUCNANG
(
     id int  primary key IDENTITY(1,1),
	 MaChucNang AS CAST('CN' + right('000' + CAST(id as varchar(3)), 3) as char(5))persisted,
     TenChucNang NVARCHAR(MAX) NOT NULL,
     TenManHinh NVARCHAR(MAX) NOT NULL
)


CREATE TABLE PHANQUYEN
(
    idNhomNguoiDung INT FOREIGN KEY REFERENCES NHOMNGUOIDUNG on delete cascade,
    idChucNang INT FOREIGN KEY REFERENCES CHUCNANG on delete cascade,
    PRIMARY KEY (idNhomNguoiDung, idChucNang)
)


CREATE TABLE NGUOIDUNG
(
	id INT IDENTITY PRIMARY KEY,
	MaNguoiDung  AS CAST('ND'+ RIGHT('000000' + CAST(id AS VARCHAR(4)), 4) AS CHAR(6)) PERSISTED,
    TenNguoiDung NVARCHAR(MAX) NOT NULL,
    NgaySinh datetime,
    ChucVu NVARCHAR(MAX),
    TenDangNhap VARCHAR(256) UNIQUE NOT NULL,
    MatKhau VARCHAR(MAX) NOT NULL,
    idNhomNguoiDung INT REFERENCES NHOMNGUOIDUNG on delete cascade NOT NULL
	AnhDaiDien nvarchar(256)
	SoDT varchar(256)
	DiaChi varchar(256)
) 



CREATE TABLE BENHNHAN
(
	id INT IDENTITY PRIMARY KEY,
	MaBenhNhan  AS CAST('BN'+ RIGHT('0000' + CAST(id AS VARCHAR(4)), 4) AS CHAR(6)) PERSISTED,
    HoTenBenhNhan NVARCHAR(MAX) NOT NULL,
	GioiTinh NVARCHAR(3) NOT NULL,
	NgaySinh datetime NOT NULL, 
	DiaChi NVARCHAR(MAX),
)
CREATE TABLE LOAITHUOC 
(
	id INT IDENTITY PRIMARY KEY,
	MaLoaiThuoc  AS CAST('MLT'+ RIGHT('00' + CAST(id AS VARCHAR(4)), 4) AS CHAR(6)) PERSISTED,
	TenLoaiThuoc NVARCHAR(max) NOT NULL,
)



CREATE TABLE DONVI 
(
	id INT IDENTITY PRIMARY KEY,
	MaDonvi  AS CAST('MDV'+ RIGHT('00' + CAST(id AS VARCHAR(3)), 3) AS CHAR(6)) PERSISTED
	TenDonVi NVARCHAR(max) NOT NULL,
)




 
CREATE TABLE CACHDUNG 
(
	id INT IDENTITY PRIMARY KEY,
	MaCachDung  AS CAST('MCD'+ RIGHT('0000' + CAST(id AS VARCHAR(4)), 4) AS CHAR(6)) PERSISTED,
	TenCachDung NVARCHAR(max) NOT NULL,
)
CREATE TABLE THUOC 
(
	id INT IDENTITY PRIMARY KEY,
	MaThuoc  AS CAST('MT'+ RIGHT('0000' + CAST(id AS VARCHAR(4)), 4) AS CHAR(6)) PERSISTED,
    TenThuoc NVARCHAR(MAX) NOT NULL,
	idMaDonVi int references DONVI NOT NULL ,
	idMaCachDung int references CACHDUNG NOT NULL,
	SoLuongTon int NOT NULL,
	DonGia int NOT NULL,
	CongDung NVARCHAR(max) NOT NULL,
	HuongDanSuDung NVARCHAR(max) NOT NULL,
	idMaLoaiThuoc int references LOAITHUOC NOT NULL ,
)
CREATE TABLE BC_SUDUNGTHUOC 
(
	id INT IDENTITY PRIMARY KEY,
	Thang int NOT NULL, 
	Nam int NOT NULL, 
	MaBCSuDungThuoc AS CAST('BCSDT' + RIGHT('0' + CAST(THANG AS CHAR(2)), 2) + CAST(NAM AS CHAR(4)) AS CHAR(10)) 
				PERSISTED,
)
CREATE TABLE CHITIETBCSUDUNGTHUOC 
(
	idMaBCSuDungThuoc int references BC_SUDUNGTHUOC,
	idMaThuoc int references THUOC,
	DonVi NVARCHAR(max) NOT NULL,
	SoLuong int NOT NULL DEFAULT 0,
	SoLanDung int NOT NULL DEFAULT 0,
	PRIMARY KEY (idMaBCSuDungThuoc,idMaThuoc)
)
CREATE TABLE PHIEUNHAPTHUOC
(
	SoPhieuNhapThuoc int IDENTITY(1,1) primary key,
	TongTien int NOT NULL DEFAULT 0, 
	NgayNhap Datetime NOT NULL
)

CREATE TABLE CT_PHIEUNHAP
(
	SoPhieuNhapThuoc int references PHIEUNHAPTHUOC(SoPhieuNhapThuoc),
	idMaThuoc int references THUOC,
	DonGiaNhap int NOT NULL, 
	ThanhTien int NOT NULL, 
	SoLuongNhap int NOT NULL, 
	primary key (SoPhieuNhapThuoc, idMaThuoc)
)
CREATE TABLE LOAIBENH
(
	id INT IDENTITY PRIMARY KEY,
	MaLoaiBenh AS CAST('LB'+ RIGHT('0000' + CAST(id AS VARCHAR(4)), 4) AS CHAR(6)) PERSISTED,
	TenLoaiBenh NVARCHAR(max) NOT NULL,
)
CREATE TABLE BENH
(
	id INT IDENTITY PRIMARY KEY,
	MaBenh AS CAST('MB'+ RIGHT('0000' + CAST(id AS VARCHAR(4)), 4) AS CHAR(6)) PERSISTED,
	TenBenh NVARCHAR(max) NOT NULL,
	TrieuChung NVARCHAR(max) NOT NULL,
	idMaLoaiBenh int references LOAIBENH NOT NULL, 
	idMaThuocDacTri int references THUOC NOT NULL,
)
CREATE TABLE PHIEUKHAMBENH
(
	SoPhieuKhamBenh INT IDENTITY PRIMARY KEY,
	NgayKham datetime NOT NULL,
	idMaBenhNhan int references BENHNHAN NOT NULL, 
	MaBenh int references BENH NOT NULL,
	TrieuChung NVARCHAR(MAX) NOT NULL,
	TongTien int NOT NULL,
	TrangThai int 
)



CREATE TABLE CT_PHIEUKHAMBENH
(
	SoPhieuKhamBenh int references PHIEUKHAMBENH (SoPhieuKhamBenh),
	idMaThuoc int references THUOC,
	DonGia int NOT NULL, 
	ThanhTien int NOT NULL, 
	SoLuong int NOT NULL, 
	idMaCachDung int references CACHDUNG, 
	primary key (SoPhieuKhamBenh, idMaThuoc)
)
CREATE TABLE HOADON
(
	SoHoaDon INT IDENTITY PRIMARY KEY,
	SoPhieuKhamBenh int references PHIEUKHAMBENH (SoPhieuKhamBenh),
	TienKham int NOT NULL, 
	TienThuoc int NOT NULL, 
	idBenhNhan int references BENHNHAN(id),
	TrangThai  NVARCHAR(max) NOT NULL

)

CREATE TABLE BC_DOANHTHU 
(
	id INT IDENTITY PRIMARY KEY,
	Thang int NOT NULL, 
	Nam int NOT NULL,
	TongDoanhThu float(3) NOT NULL,
	MaBCDoanhThu AS CAST('BCSDT' + RIGHT('0' + CAST(THANG AS CHAR(2)), 2) + CAST(NAM AS CHAR(4)) AS CHAR(10)) 
				PERSISTED,
)
CREATE TABLE CHITIETBCDOANHTHU 
(
	idMaBCDoanhThu int references BC_DOANHTHU,
	NgayKham datetime NOT NULL,
	DoanhThu float(3) NOT NULL DEFAULT 0,
	TyLe float(3) NOT NULL DEFAULT 0,
	PRIMARY KEY (idMaBCDoanhThu,NgayKham)
)
CREATE TABLE THAMSO
(
	id int identity(1,1) primary key,
	SoBenhNhanToiDa int NOT NULL,
	TienKham int NOT NULL,
	SoLuongSapHet int Not Null
)


CREATE TABLE DANGKY
(
     id int  primary key IDENTITY(1,1),
	 MaDangKy AS CAST('DK' + right('000' + CAST(id as varchar(3)), 3) as char(5))persisted,
     NgayDangKy datetime NOT NULL,
     idMaBenhNhan int references BENHNHAN NOT NULL
)

UPDATE CT_PHIEUKHAMBENH
SET ThanhTien= SoLuong*DonGia
UPDATE CT_PHIEUNHAP
SET ThanhTien= SoLuongNhap*DonGiaNhap
go
insert into NHOMNGUOIDUNG (TenNhomNguoiDung) values (N'Nhân viên quản lí')
insert into NHOMNGUOIDUNG (TenNhomNguoiDung) values (N'Bác Sĩ')

go

insert into CHUCNANG (TenChucNang, TenManHinh) VALUES ('BN', N'Bệnh Nhân')
insert into CHUCNANG (TenChucNang, TenManHinh) VALUES ('LPKB', N'Phiếu Khám Bệnh')
insert into CHUCNANG (TenChucNang, TenManHinh) VALUES ('QLB', N'Bệnh và Loại Bệnh')
insert into CHUCNANG (TenChucNang, TenManHinh) VALUES ('QLT', N'Thuốc và Loại Thuốc')
insert into CHUCNANG (TenChucNang, TenManHinh) VALUES ('QLDV_CD', N'Đơn vị và Cách Dùng')
insert into CHUCNANG (TenChucNang, TenManHinh) VALUES ('QLNT', N'Nhập Thuốc')
insert into CHUCNANG (TenChucNang, TenManHinh) VALUES ('TDQD', N'Thay Đổi Quy Định')
insert into CHUCNANG (TenChucNang, TenManHinh) VALUES ('QLBC', N'Báo Cáo')
insert into CHUCNANG (TenChucNang, TenManHinh) VALUES ('QLTK', N'Tài Khoản')
go

INSERT INTO PHANQUYEN VALUES (1, 1)
INSERT INTO PHANQUYEN VALUES (1, 2)
INSERT INTO PHANQUYEN VALUES (1, 3)
INSERT INTO PHANQUYEN VALUES (1, 4)
INSERT INTO PHANQUYEN VALUES (1, 5)
INSERT INTO PHANQUYEN VALUES (1, 6)
INSERT INTO PHANQUYEN VALUES (1, 7)
INSERT INTO PHANQUYEN VALUES (1, 8)
INSERT INTO PHANQUYEN VALUES (1, 9)

INSERT INTO PHANQUYEN VALUES (2, 1)
INSERT INTO PHANQUYEN VALUES (2, 2)
INSERT INTO PHANQUYEN VALUES (2, 3)
INSERT INTO PHANQUYEN VALUES (2, 4)
INSERT INTO PHANQUYEN VALUES (2, 5)
INSERT INTO PHANQUYEN VALUES (2, 6)
go
set dateformat dmy
go
INSERT INTO NGUOIDUNG(TenNguoiDung, TenDangNhap, MatKhau, idNhomNguoiDung) 
VALUES (N'Admin', 'admin', '123', 1)
INSERT INTO NGUOIDUNG(TenNguoiDung, TenDangNhap, MatKhau, idNhomNguoiDung) 
VALUES (N'Bác sĩ', 'doc', '123', 2)
-- Chèn dữ liệu vào bảng BENHNHAN từ các câu INSERT đã sửa đổi
INSERT INTO BENHNHAN (HoTenBenhNhan, GioiTinh, NgaySinh, DiaChi)
VALUES (N'Nguyễn Mai Anh', N'Nữ', '11/06/1999', N'TP Hồ Chí Minh');

INSERT INTO BENHNHAN (HoTenBenhNhan, GioiTinh, NgaySinh, DiaChi)
VALUES (N'Lê Thành Đô', N'Nam', '08/01/1990', N'TP Hồ Chí Minh');

INSERT INTO BENHNHAN (HoTenBenhNhan, GioiTinh, NgaySinh, DiaChi)
VALUES (N'Huỳnh Hồng Thu Giang', N'Nữ', '24/02/2000', N'TP Hồ Chí Minh');

INSERT INTO BENHNHAN (HoTenBenhNhan, GioiTinh, NgaySinh, DiaChi)
VALUES (N'Trần Nhật Huy', N'Nam', '03/01/2004', N'TP Hồ Chí Minh');

INSERT INTO BENHNHAN (HoTenBenhNhan, GioiTinh, NgaySinh, DiaChi)
VALUES (N'Phan Hoàng Khánh Linh', N'Nữ', '22/06/1999', N'TP Hồ Chí Minh');

INSERT INTO BENHNHAN (HoTenBenhNhan, GioiTinh, NgaySinh, DiaChi)
VALUES (N'Nguyễn Ánh Linh', N'Nữ', '25/08/1990', N'TP Hồ Chí Minh');

INSERT INTO BENHNHAN (HoTenBenhNhan, GioiTinh, NgaySinh, DiaChi)
VALUES (N'Trương Họa Mi', N'Nữ', '11/04/2000', N'TP Hồ Chí Minh');

INSERT INTO BENHNHAN (HoTenBenhNhan, GioiTinh, NgaySinh, DiaChi)
VALUES (N'Lê Duy Minh', N'Nam', '02/11/2004', N'TP Hồ Chí Minh');

INSERT INTO BENHNHAN (HoTenBenhNhan, GioiTinh, NgaySinh, DiaChi)
VALUES (N'Nguyễn Đăng Minh', N'Nam', '03/07/1999', N'TP Hồ Chí Minh');

INSERT INTO BENHNHAN (HoTenBenhNhan, GioiTinh, NgaySinh, DiaChi)
VALUES (N'Nguyễn Phan Nhật Minh', N'Nam', '25/09/1990', N'TP Hồ Chí Minh');

INSERT INTO BENHNHAN (HoTenBenhNhan, GioiTinh, NgaySinh, DiaChi)
VALUES (N'Trần Gia Nghĩa', N'Nam', '05/12/2004', N'TP Hồ Chí Minh');
--LOAITHUOC
INSERT INTO loaithuoc (TenLoaiThuoc) VALUES (N'Thuốc đau đầu');
INSERT INTO loaithuoc (TenLoaiThuoc) VALUES (N'Thuốc hạ sốt');
INSERT INTO loaithuoc (TenLoaiThuoc) VALUES (N'Thuốc ho');
INSERT INTO loaithuoc (TenLoaiThuoc) VALUES (N'Thuốc kháng vi khuẩn');
INSERT INTO loaithuoc (TenLoaiThuoc) VALUES (N'Thuốc dị ứng');
INSERT INTO loaithuoc (TenLoaiThuoc) VALUES (N'Thuốc tiêu hóa');
INSERT INTO loaithuoc (TenLoaiThuoc) VALUES (N'Thuốc tim mạch');
INSERT INTO loaithuoc (TenLoaiThuoc) VALUES (N'Thuốc trị viêm');
INSERT INTO loaithuoc (TenLoaiThuoc) VALUES (N'Thuốc chống co giật');
INSERT INTO loaithuoc (TenLoaiThuoc) VALUES (N'Thuốc an thần');
--DONVI
INSERT INTO donvi (TenDonVi) VALUES (N'viên');
INSERT INTO donvi (TenDonVi) VALUES (N'chai');
--CACHDUNG
INSERT INTO CACHDUNG (TenCachDung) VALUES (N'ăn');
INSERT INTO CACHDUNG (TenCachDung) VALUES (N'uống');
INSERT INTO CACHDUNG (TenCachDung) VALUES (N'nhai');
INSERT INTO CACHDUNG (TenCachDung) VALUES (N'hít');

--THUOC
INSERT INTO THUOC (TenThuoc, idMaDonVi, idMaCachDung, SoLuongTon, DonGia, CongDung, HuongDanSuDung, idMaLoaiThuoc)
VALUES (N'Aspirin', 1, 1, 80, 7000, N'Giảm đau, hạ sốt', N'Uống 1 viên sau khi ăn', 3);

INSERT INTO THUOC (TenThuoc, idMaDonVi, idMaCachDung, SoLuongTon, DonGia, CongDung, HuongDanSuDung, idMaLoaiThuoc)
VALUES (N'Ibuprofen', 1, 2, 60, 10000, N'Giảm đau, chống viêm', N'Uống 1 viên sau bữa ăn', 3);

INSERT INTO THUOC (TenThuoc, idMaDonVi, idMaCachDung, SoLuongTon, DonGia, CongDung, HuongDanSuDung, idMaLoaiThuoc)
VALUES (N'Paracetamol', 2, 1, 120, 5000, N'Giảm đau, hạ sốt', N'Uống 1 viên sau khi ăn', 1);

INSERT INTO THUOC (TenThuoc, idMaDonVi, idMaCachDung, SoLuongTon, DonGia, CongDung, HuongDanSuDung, idMaLoaiThuoc)
VALUES (N'Amoxicillin', 1, 2, 40, 8000, N'Kháng vi khuẩn', N'Uống 1 viên mỗi ngày trong 7 ngày', 2);

INSERT INTO THUOC (TenThuoc, idMaDonVi, idMaCachDung, SoLuongTon, DonGia, CongDung, HuongDanSuDung, idMaLoaiThuoc)
VALUES (N'Ceftriaxone', 1, 1, 30, 15000, N'Kháng sinh', N'Pha 1 gói với dung môi và tiêm bắp', 2);

INSERT INTO THUOC (TenThuoc, idMaDonVi, idMaCachDung, SoLuongTon, DonGia, CongDung, HuongDanSuDung, idMaLoaiThuoc)
VALUES (N'Chlorpheniramine', 2, 2, 50, 6000, N'Chống dị ứng', N'Uống 1 viên mỗi ngày trước khi đi ngủ', 4);

INSERT INTO THUOC (TenThuoc, idMaDonVi, idMaCachDung, SoLuongTon, DonGia, CongDung, HuongDanSuDung, idMaLoaiThuoc)
VALUES (N'Loperamide', 2, 3, 70, 9000, N'Chống tiêu chảy', N'Uống 2 viên sau khi tiêu chảy', 4);

INSERT INTO THUOC (TenThuoc, idMaDonVi, idMaCachDung, SoLuongTon, DonGia, CongDung, HuongDanSuDung, idMaLoaiThuoc)
VALUES (N'Gliclazide', 1, 4, 20, 12000, N'Giảm đường huyết', N'Uống 1 viên trước bữa ăn sáng', 5);
--LOAIBENH
INSERT INTO LOAIBENH (TenLoaiBenh) VALUES (N'Đau đầu')
INSERT INTO LOAIBENH (TenLoaiBenh) VALUES (N'Sốt')
INSERT INTO LOAIBENH (TenLoaiBenh) VALUES (N'Cảm lạnh')
INSERT INTO LOAIBENH (TenLoaiBenh) VALUES (N'Tiểu đường')
INSERT INTO LOAIBENH (TenLoaiBenh) VALUES (N'Đau dạ dày')

--BENH
INSERT INTO BENH (TenBenh, TrieuChung, idMaLoaiBenh, idMaThuocDacTri) VALUES (N'Cảm cúm', N'Sốt, ho, đau họng', 3, 1)
INSERT INTO BENH (TenBenh, TrieuChung, idMaLoaiBenh, idMaThuocDacTri) VALUES (N'Tiểu đường', N'Mệt mỏi, đau đầu, thèm ăn nhiều', 4, 2)
INSERT INTO BENH (TenBenh, TrieuChung, idMaLoaiBenh, idMaThuocDacTri) VALUES (N'Viêm xoang', N'Chảy nước mũi, đau mặt', 3, 3)
INSERT INTO BENH (TenBenh, TrieuChung, idMaLoaiBenh, idMaThuocDacTri) VALUES (N'Đau dạ dày', N'Buồn nôn, đau âm ỉ', 5, 1)
INSERT INTO BENH (TenBenh, TrieuChung, idMaLoaiBenh, idMaThuocDacTri) VALUES (N'Viêm họng', N'Đau họng, khó nuốt', 2, 3)
INSERT INTO BENH (TenBenh, TrieuChung, idMaLoaiBenh, idMaThuocDacTri) VALUES (N'Đau lưng', N'Đau ở vùng lưng', 4, 5)
INSERT INTO BENH (TenBenh, TrieuChung, idMaLoaiBenh, idMaThuocDacTri) VALUES (N'Loét miệng', N'Vết loét trên niêm mạc miệng', 2, 4)
INSERT INTO BENH (TenBenh, TrieuChung, idMaLoaiBenh, idMaThuocDacTri) VALUES (N'Viêm mũi', N'Sổ mũi, ngứa mũi', 2, 4)
INSERT INTO BENH (TenBenh, TrieuChung, idMaLoaiBenh, idMaThuocDacTri) VALUES (N'Đau đầu', N'Đau ở vùng đầu', 1, 5)
INSERT INTO BENH (TenBenh, TrieuChung, idMaLoaiBenh, idMaThuocDacTri) VALUES (N'Đau bụng', N'Đau ở vùng bụng', 5, 2)
--THAMSO
INSERT INTO THAMSO (SoBenhNhanToiDa, TienKham) VALUES (40000, 30000)
