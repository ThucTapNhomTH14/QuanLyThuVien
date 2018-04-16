use [quan ly thu vien]
go

create proc SuaTTSach(@DauSach_ID varchar(20), @Sach_ten nvarchar(40),@TacGia_ten nvarchar)
as
begin
	declare @TacGia_ID varchar(20) = (select TacGia_ID from TacGia where TacGia_ten = @TacGia_ten)
	if @TacGia_ID=''
		set @TacGia_ID = (select top 1 TacGia_ID from TacGia order by TacGia_ID desc)
		declare @id_number int = convert(int,@TacGia_ID) + 1
		set @TacGia_ID = convert(varchar,@id_number);
		while len(@TacGia_ID) < 20
		begin
			set @TacGia_ID = '0'+@TacGia_ID
		end
		insert into TacGia(TacGia_ID,TacGia_ten) values (@TacGia_ID,@TacGia_ten)
	update DauSach set Sach_ten=@Sach_ten,TacGia_ID=@TacGia_ID where DauSach_ID = @DauSach_ID 
end
go