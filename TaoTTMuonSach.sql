use [quan ly thu vien]
go

create type ListSachMuon as table (TTMuonTra_ID varchar(20),SachID varchar(20))
go

drop proc TaoIDMuonSach
go

create proc TaoIDMuonSach(@DocGia_ID varchar(20), @ListSach as ListSachMuon readonly)
as
begin
	declare @id varchar(20),@luot int
	set @luot = (select LuotMuonSach from DocGia where DocGia_ID=@DocGia_ID)
	set @id = @DocGia_ID
	set @id += CONVERT(varchar,@luot);
	insert into TTMuonTra (TTMuonTra_ID, DocGia_ID, NgayMuon)
	values (@id,@DocGia_ID,GETDATE())

	insert into SachMuon(TTMuonTra_ID,Sach_ID)
		select * from @ListSach
end
go