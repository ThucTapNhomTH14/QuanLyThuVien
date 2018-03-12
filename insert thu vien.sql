use [quan ly thu vien]
go

insert dbo.TacGia (
TacGia_ID,TacGia_ten) values ('00001','Margaret Mitchell')
insert dbo.TacGia (
TacGia_ID,TacGia_ten) values ('00002','Lazar Lagin')
insert dbo.TacGia (
TacGia_ID,TacGia_ten) values ('00003','Van Cao')
insert dbo.TacGia (
TacGia_ID,TacGia_ten) values ('00004','Antoine de Saint-Exupéry')
insert dbo.TacGia (
TacGia_ID,TacGia_ten) values ('00005','Mark Twain')

insert dbo.DauSach (
DauSach_ID,Sach_ten,TacGia_ID) values ('001','Chi Pheo','00003')
insert dbo.DauSach (
DauSach_ID,Sach_ten,TacGia_ID) values ('002','Cuon theo chieu gio','00001')
insert dbo.DauSach (
DauSach_ID,Sach_ten,TacGia_ID) values ('003','Hoang tu be','00004')
insert dbo.DauSach (
DauSach_ID,Sach_ten,TacGia_ID) values ('004','Ong gia khot-ta-bit','00002')
insert dbo.DauSach (
DauSach_ID,Sach_ten,TacGia_ID) values ('005','Cuoc phieu luu cua Tomsawyer'.'00005')

insert dbo.Sach (
DauSach_ID,Sach_ID) values ('0001','00010001')
insert dbo.Sach (
DauSach_ID,Sach_ID) values ('0002','00020002')
insert dbo.Sach (
DauSach_ID,Sach_ID) values ('0003','00030003')
insert dbo.Sach (
DauSach_ID,Sach_ID) values ('0003','00030004')
insert dbo.Sach (
DauSach_ID,Sach_ID) values ('0005','00050005')

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
DocGia_ID, NgayMuon, NgayTra, Sach_ID) values ('0001',2017-6-9,2017-8-9,'00010001')
insert dbo.TTMuonTra (
DocGia_ID, NgayMuon, NgayTra, Sach_ID) values ('0002',2017-5-9,2017-6-9,'00020002')
insert dbo.TTMuonTra (
DocGia_ID, NgayMuon, NgayTra, Sach_ID) values ('0003',2017-4-9,2017-5-9,'00030003')
insert dbo.TTMuonTra (
DocGia_ID, NgayMuon, NgayTra, Sach_ID) values ('0004',2017-3-9,2017-4-9,'00030004')
insert dbo.TTMuonTra (
DocGia_ID, NgayMuon, NgayTra, Sach_ID) values ('0005',2017-2-9,2017-3-9,'00050005')
