USE [quan ly thu vien]
GO

create proc [dbo].[themSach](@DauSach_ID varchar(20),@Sach_ten nvarchar(40),@SoBanSao int,@TacGia_ID varchar(20))
as
begin
	insert into DauSach(DauSach_ID,Sach_ten,TacGia_ID)
	values(@DauSach_ID,@Sach_ten,@TacGia_ID)
	
	declare @i int 
	set @i = (select count(Sach_ID) from Sach where @DauSach_ID = DauSach_ID)
	declare @i_string varchar(4);
	declare @cpy_string varchar(8);

	while @i < @SoBanSao
	begin
		set @i_string = convert(varchar(4),@i)
		if @i<10
			set @cpy_string = @DauSach_ID + '000' + @i_string
		else if @i>=10 and @i<100
			set @cpy_string = @DauSach_ID + '00' + @i_string
		else if @i>=100 and @i<1000
			set @cpy_string = @DauSach_ID + '0' + @i_string
		else if @i>=1000 and @i<=9999
			set @cpy_string = @DauSach_ID + '' + @i_string
		insert into Sach(DauSach_ID,Sach_ID)
		values(@DauSach_ID,@cpy_string)
		set @i = @i+1;
	end
end