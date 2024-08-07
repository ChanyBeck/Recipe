create or alter procedure dbo.CookbookGet(
    @CookbookId int = 0 output, 
    @All bit = 0, 
    @Message varchar(500) = ''  output
)  
as 
begin 
    declare @return int = 0, @Isactive bit

	select @All = isnull(@All,0), @CookBookId = isnull(@CookBookId,0), @Isactive = isnull(@Isactive, 0)

	select @Isactive = IsActive from CookBook where CookBookId = @CookbookId

	select b.CookbookId, b.Title, b.UsersId, b.Price, b.BookCreated, b.Isactive
	from CookBook b 
	where b.CookBookId = @CookBookId
	or @All = 1

	return @return
end
go 
