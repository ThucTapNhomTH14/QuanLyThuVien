use [quan ly thu vien]

drop table if exists DauSach
create table DauSach (
Sach_ID varchar(20) not null primary key,
Sach_ten nvarchar(40),
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
Sach_ID varchar(20) not null foreign key references DauSach(Sach_ID),
DocGia_ID varchar(20) not null foreign key references DocGia(DocGia_ID),
NgayMuon date,
NgayTra date,
)
