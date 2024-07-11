create or alter procedure dbo.CookbookGet(
    @CookbookId int = 0 output, 
    @All bit = 0, 
    @Message varchar(500) = ''  output
)  
as 
begin 
    declare @return int = 0

	select @All = isnull(@All,0), @CookBookId = isnull(@CookBookId,0)

	select b.CookbookId, b.Title, b.UsersId, b.Price, b.BookCreated, b.IsActive
	from CookBook b 
	where b.CookBookId = @CookBookId
	or @All = 1

	return @return
end
go 
