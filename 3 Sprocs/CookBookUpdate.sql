create or alter procedure dbo.CookbookUpdate(
    @CookbookId int output,
    @UsersId int, 
    @Title varchar(100), 
    @Price decimal(5,2),
    @Isactive bit = 0, 
    @Message varchar(500) = '' output
)
as 
begin 
    declare @return int = 0

    select @CookbookId = isnull(@CookbookId, 0), @Isactive = isnull(@Isactive, 0)

    if @CookbookId = 0
    begin 
        insert CookBook(UsersId, Title, Price, IsActive, BookCreated)
        values(@UsersId, @Title, @Price, @Isactive, CURRENT_TIMESTAMP)

        select @CookbookId = SCOPE_IDENTITY();

    end 
    else 
    begin 
        update CookBook
        set 
        UsersId = @UsersId, 
        Title = @Title, 
        Price = @Price, 
        IsActive = @Isactive
        where CookBookId = @CookbookId
    end 
    return @return
end 
go 