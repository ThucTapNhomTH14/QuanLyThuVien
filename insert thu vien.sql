use [quan ly thu vien]
go
insert dbo.DauSach (
Sach_ID,Sach_ten) values ('00001','Chi Pheo')
insert dbo.DauSach (
Sach_ID,Sach_ten) values ('00002','Cuon theo chieu gio')
insert dbo.DauSach (
Sach_ID,Sach_ten) values ('00003','Angelic')
insert dbo.DauSach (
Sach_ID,Sach_ten) values ('00004','Ong gia khot-ta-bit')
insert dbo.DauSach (
Sach_ID,Sach_ten) values ('00005','Cuoc phieu luu cua Tomsawyer')

insert dbo.DocGia (
DocGia_ID, DocGia_ngaysinh, DocGia_ten) values ('0001',1997-10-9,'Luong Hai Duc')
insert dbo.DocGia (
DocGia_ID, DocGia_ngaysinh, DocGia_ten) values ('0002',1997-3-9,'Nguyen Van Sy')
insert dbo.DocGia (
DocGia_ID, DocGia_ngaysinh, DocGia_ten) values ('0003',1997-2-9,'Phan Hai Nam')
insert dbo.DocGia (
DocGia_ID, DocGia_ngaysinh, DocGia_ten) values ('0004',1997-3-8,'Tran Dinh Kien')
insert dbo.DocGia (
DocGia_ID, DocGia_ngaysinh, DocGia_ten) values ('0005',1997-12-6,'Hoang Hai Nam')

insert dbo.TTMuonTra (
DocGia_ID, NgayMuon, NgayTra, Sach_ID) values ('0001',2017-6-9,2017-8-9,'00001')
insert dbo.TTMuonTra (
DocGia_ID, NgayMuon, NgayTra, Sach_ID) values ('0002',2017-5-9,2017-6-9,'00002')
insert dbo.TTMuonTra (
DocGia_ID, NgayMuon, NgayTra, Sach_ID) values ('0003',2017-4-9,2017-5-9,'00003')
insert dbo.TTMuonTra (
DocGia_ID, NgayMuon, NgayTra, Sach_ID) values ('0004',2017-3-9,2017-4-9,'00004')
insert dbo.TTMuonTra (
DocGia_ID, NgayMuon, NgayTra, Sach_ID) values ('0005',2017-2-9,2017-3-9,'00005')