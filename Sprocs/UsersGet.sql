create or alter procedure dbo.UsersGet(@UsersId int = 0, @All bit = 0, @UserName varchar(50) = '')
as 
begin 
    select @UserName = nullif(@UserName, '')
    select * 
    from Users u 
    where u.UsersId = @UsersId 
    or @All = 1
    or u.UserName like '%' + @UserName + '%'
end

