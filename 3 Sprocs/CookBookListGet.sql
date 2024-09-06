create or alter procedure dbo.CookBookListGet(
    @All bit = 0, 
    @Message varchar(500) = ''  output
)  
as 
begin 
    declare @return int = 0

	select @All = isnull(@All,0)

	select b.CookBookId, 'Cookbook Name' = b.Title, 'Author' = concat(u.FirstName, ' ', u.LastName), 'Num Recipe' = max(br.BookRecipeSequence), 'Price' = b.Price
	from CookBook b 
    join Users u 
    on u.UsersId = b.UsersId
    join BookRecipe br 
    on br.CookBookId = b.CookBookId
    join Recipe r 
    on r.RecipeId = br.RecipeId
	or @All = 1
    group by b.CookBookId, b.Title, concat(u.FirstName, ' ', u.LastName), b.Price

	return @return
end
go 
