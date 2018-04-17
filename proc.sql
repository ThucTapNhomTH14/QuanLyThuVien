-----------------------
drop proc GetAccountByUserName
go
CREATE PROC GetAccountByUserName
@username NVARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName=@username
END
GO

dbo.GetAccountByUserName @username = N'admin' -- nvarchar(100)

GO
-----------------------
drop proc pro_Login
go
CREATE PROC pro_Login
@username NVARCHAR(100), @password NVARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName=@username AND PassWord=@password
END

GO
dbo.pro_Login @username = N'', -- nvarchar(100)
    @password = N'' -- nvarchar(100)
