USE [TTN-QuanLyThuVien]


create table TacGia (
TacGia_ID varchar(20) not null primary key,
TacGia_ten nvarchar(40)
)

create table DauSach (
DauSach_ID varchar(20) not null primary key,
Sach_ten nvarchar(40),
TacGia_ID varchar(20) not null foreign key references TacGia(TacGia_ID)
)


create table Sach (
Sach_ID varchar(20) not null primary key,
DauSach_ID varchar(20) not null foreign key references DauSach(DauSach_ID),
)


create table DocGia (
DocGia_ID varchar(20) not null primary key,
DocGia_ten nvarchar(40),
DocGia_ngaysinh date,
)


CREATE table TTMuonTra (
TTMuonTra_ID int IDENTITY  primary key,
Sach_ID varchar(20) not null foreign key references Sach(Sach_ID),
DocGia_ID varchar(20) not null foreign key references DocGia(DocGia_ID),
NgayMuon date,
NgayTra date,
)
GO
ALTER TABLE 
GO

CREATE TABLE Account
(
	id INT IDENTITY PRIMARY KEY,
	DisplayName NVARCHAR(100) NOT NULL ,
	UserName NVARCHAR(100) NOT NULL,
	PassWord NVARCHAR(100) NOT NULL,
	Type INT NOT NULL DEFAULT 0--1: admin/0:user
)
GO


------------
insert dbo.TacGia (
TacGia_ID,TacGia_ten) values ('00001','Margaret Mitchell')
insert dbo.TacGia (TacGia_ID,TacGia_ten) values ('00002','Lazar Lagin')
insert dbo.TacGia (
TacGia_ID,TacGia_ten) values ('00003','Van Cao')
insert dbo.TacGia (
TacGia_ID,TacGia_ten) values ('00004','Antoine de Saint-Exupéry')
insert dbo.TacGia (
TacGia_ID,TacGia_ten) values ('00005','Mark Twain')
-------------
insert dbo.Sach (
DauSach_ID,Sach_ID) values ('001','1')
insert dbo.Sach (
DauSach_ID,Sach_ID) values ('002','2')
insert dbo.Sach (
DauSach_ID,Sach_ID) values ('003','3')
insert dbo.Sach (
DauSach_ID,Sach_ID) values ('003','4')
insert dbo.Sach (
DauSach_ID,Sach_ID) values ('005','5')

-----------
insert dbo.DauSach (
DauSach_ID,Sach_ten,TacGia_ID) values ('001','Chi Pheo','00003')
insert dbo.DauSach (
DauSach_ID,Sach_ten,TacGia_ID) values ('002','Cuon theo chieu gio','00001')
insert dbo.DauSach (
DauSach_ID,Sach_ten,TacGia_ID) values ('003','Hoang tu be','00004')
insert dbo.DauSach (
DauSach_ID,Sach_ten,TacGia_ID) values ('004','Ong gia khot-ta-bit','00002')
insert dbo.DauSach (
DauSach_ID,Sach_ten,TacGia_ID) values ('005','Cuoc phieu luu cua Tomsawyer','00005')

-----------------
insert dbo.DocGia (
DocGia_ID, DocGia_ngaysinh, DocGia_ten) values ('0001','19971005','Luong Hai Duc')
insert dbo.DocGia (
DocGia_ID, DocGia_ngaysinh, DocGia_ten) values ('0002','19970903','Nguyen Van Sy')
insert dbo.DocGia (
DocGia_ID, DocGia_ngaysinh, DocGia_ten) values ('0003','19970209','Phan Hai Nam')
insert dbo.DocGia (
DocGia_ID, DocGia_ngaysinh, DocGia_ten) values ('0004','19970308','Tran Dinh Kien')
insert dbo.DocGia (
DocGia_ID, DocGia_ngaysinh, DocGia_ten) values ('0005','19971206','Hoang Hai Nam')


----ttmuontra
insert dbo.TTMuonTra (
DocGia_ID, NgayMuon, NgayTra, Sach_ID) values ('0001','20170609','2017-8-9','1')
insert dbo.TTMuonTra (
DocGia_ID, NgayMuon, NgayTra, Sach_ID) values ('0002','20170509','2017-6-9','2')
insert dbo.TTMuonTra (
DocGia_ID, NgayMuon, NgayTra, Sach_ID) values ('0003','20170409','2017-5-9','3')
insert dbo.TTMuonTra (
DocGia_ID, NgayMuon, NgayTra, Sach_ID) values ('0004','20170309','2017-4-9','4')
insert dbo.TTMuonTra (
DocGia_ID, NgayMuon, NgayTra, Sach_ID) values ('0005','20170209','2017-3-9','5')


--insert Account
INSERT INTO dbo.Account
        ( 
		  DisplayName ,
          UserName ,
          PassWord ,
          Type
        )
VALUES  ( 
          N'Admin' , -- DisplayName - nvarchar(100)
          N'Admin' , -- UserName - nvarchar(100)
          N'1' , -- PassWord - nvarchar(100)
          1  -- Type - int
        )

INSERT INTO dbo.Account
        ( 
          DisplayName ,
          UserName ,
          PassWord ,
          Type
        )
VALUES  ( 
          N'user1' , -- DisplayName - nvarchar(100)
          N'user1' , -- UserName - nvarchar(100)
          N'1' , -- PassWord - nvarchar(100)
          0  -- Type - int
        )