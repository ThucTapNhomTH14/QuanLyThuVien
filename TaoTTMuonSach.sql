use [TTN-QuanLyThuVien]
go

create type ListSachMuon as table (TTMuonTra_ID varchar(20),SachID varchar(20))
go

drop proc if exists TaoIDMuonSach
go
create proc TaoIDMuonSach(@DocGia_ID varchar(20), @ListSach as ListSachMuon readonly)
as
begin
	declare @id varchar(20),@luot int
	set @id = (SELECT REPLACE(CONVERT(VARCHAR(20), GETDATE(), 103),'/','')+
           RIGHT('0'+CAST(DATEPART(hour, GETDATE()) as varchar(2)),2)+
           RIGHT('0'+CAST(DATEPART(minute, GETDATE())as varchar(2)),2)+
           RIGHT('0'+CAST(DATEPART(Second, GETDATE())as varchar(2)),2))
	insert into TTMuonTra (TTMuonTra_ID, DocGia_ID, NgayMuon)
	values (@id,@DocGia_ID,GETDATE())

	insert into SachMuon(TTMuonTra_ID,Sach_ID)
		select * from @ListSach
end
go
