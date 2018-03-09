use [quan ly thu vien]

drop table if exists DauSach
create table DauSach (
Sach_ID varchar(20),
Sach_ten nvarchar(40),
)

drop table if exists DocGia
create table DocGia (
DocGia_ID varchar(20),
DocGia_ten nvarchar(40),
DocGia_ngaysinh date,
)

drop table if exists TTMuonTra
create table TTMuonTra (
Sach_ID varchar(20),
DocGia_ID varchar(20),
NgayMuon date,
NgayTra date,
)
