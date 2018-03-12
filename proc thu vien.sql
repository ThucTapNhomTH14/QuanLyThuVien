use [quan ly thu vien]
go
drop proc if exists ThemDocGia
go
create proc ThemDocGia(@ID varchar(20),@ten nvarchar(20),@birth date)
as
begin
insert into DocGia(DocGia_ID,DocGia_ten,DocGia_ngaysinh)
values (@ID,@ten,@birth)
end

drop proc if exists SuaDocGia
go
create proc SuaDocGia(@ID varchar(20),@ten nvarchar(20),@birth date)
as
begin
update DocGia set DocGia_ten=@ten,DocGia_ngaysinh=@birth where @ID=DocGia_ID
end

drop proc if exists XoaDocGia
go
create proc XoaDocGia(@ID varchar(20)=null,@ten nvarchar(20)=null,@birth date=null)
as
begin
delete from DocGia where @ID=DocGia_ID
end

drop proc if exists TimDocGia
go
create proc TimDocGia(@ID varchar(20)=null,@ten nvarchar(20)=null,@birth date=null)
as
begin
select * from DocGia
where @ID=DocGia_ID or
(@ID=DocGia_ID and @ten=DocGia_ten) or
(@ID=DocGia_ID and @ten=DocGia_ten and @birth=DocGia_ngaysinh)
end