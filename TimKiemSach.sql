use [quan ly thu vien]
go

create proc TimKiemSach(@Sach_ten nvarchar(40))
as
begin
	select Sach_ten, TacGia_ID from DauSach
	where Sach_ten like N'%' + @Sach_ten + N'%'
end
go