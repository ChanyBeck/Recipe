create or alter procedure dbo.UsersUpdate(
    @UsersId int output,
    @FirstName varchar (30),
    @LastName varchar (30),
    @UserName varchar (20),
    @Message varchar(500) = '' output
)
as 
begin 
    declare @return int = 0

    select @UsersId = isnull(@UsersId, 0)

    if @UsersId = 0
    begin 
        insert Users(FirstName, LastName, UserName)
        values (@FirstName, @LastName, @UserName)

        select @UsersId = SCOPE_IDENTITY();
    end 
    else 
    begin 
        update Users
        set 
        FirstName = @FirstName, 
        LastName = @LastName, 
        UserName = @UserName
        where UsersId = @UsersId
    end 
    return @return
end 
go 