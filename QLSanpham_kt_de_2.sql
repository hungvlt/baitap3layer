--
CREATE DATABASE QLSanpham_kt_de_2;
USE QLSanpham_kt_de_2;
GO

DROP TABLE LoaiSP

CREATE TABLE LoaiSP (
    MaLoai CHAR(2) PRIMARY KEY,
    TenLoai NVARCHAR(30) NOT NULL
);

CREATE TABLE Sanpham (
    MaSP CHAR(6) PRIMARY KEY,
    TenSP NVARCHAR(30) NOT NULL,
    NgayNhap DATETIME,
    MaLoai CHAR(2),
    FOREIGN KEY (MaLoai) REFERENCES LoaiSP(MaLoai)
);

INSERT INTO LoaiSP (MaLoai, TenLoai) 
VALUES ('L1', N'Bánh kẹo'),
	   ('L2', N'Giải khát')

INSERT INTO Sanpham (MaSP, TenSP, NgayNhap, MaLoai) 
VALUES ('SP001', N'Kẹo mút', '2024-12-20', 'L1'),
	   ('SP002', N'Bánh ngọt', '2024-12-19', 'L1'),
       ('SP003', N'Sting', '2024-12-18', 'L2')

SELECT * FROM LoaiSP;
SELECT * FROM Sanpham;
