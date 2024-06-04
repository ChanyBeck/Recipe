create or alter procedure dbo.UsersGet(
    @UsersId int = 0, 
    @All bit = 0,     
    @Message varchar(500) = ''  output
)  
as 
begin 
    declare @return int = 0

	select @All = isnull(@All,0), @UsersId = isnull(@UsersId,0)

	select u.UsersId, u.UserName
	from Users u
	where u.UsersId = @UsersId
	or @All = 1
	order by u.UserName
end
go
