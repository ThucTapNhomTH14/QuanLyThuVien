use [quan ly thu vien]

drop table if exists TacGia 
create table TacGia (
TacGia_ID varchar(20) not null primary key,
TacGia_ten nvarchar(40)
)
drop table if exists DauSach
create table DauSach (
DauSach_ID varchar(20) not null primary key,
Sach_ten nvarchar(40),
TacGia_ID varchar(20)
)

drop table if exists Sach
create table BanSao (
Sach_ID varchar(20) not null primary key,
DauSach_ID varchar(20) not null foreign key references DauSach(Sach_ID),
)

drop table if exists DocGia
create table DocGia (
DocGia_ID varchar(20) not null primary key,
DocGia_ten nvarchar(40),
DocGia_ngaysinh date,
)

drop table if exists TTMuonTra
create table TTMuonTra (
TTMuonTra_ID varchar(20) not null primary key,
Sach_ID varchar(20) not null foreign key references Sach(Sach_ID),
DocGia_ID varchar(20) not null foreign key references DocGia(DocGia_ID),
NgayMuon date,
NgayTra date,
)
