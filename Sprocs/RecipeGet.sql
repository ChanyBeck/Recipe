create or alter procedure dbo.RecipeGet(@RecipeId int = 0, @All bit = 0, @RecipeName varchar(50) = '')  
as 
begin 
    select @RecipeName = nullif(@RecipeName, '')
    select * 
    from Recipe r 
    where r.recipeid = @RecipeId
    or @All = 1 
    or r.RecipeName like '%' + @RecipeName + '%'
end
go 

