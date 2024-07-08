create or alter procedure dbo.RecipeGet(
@RecipeId int = 0, 
@All bit = 0, 
@RecipeName varchar(50) = '', 
@message varchar (1000) = '' output)  

as 
begin 
    declare @return int = 0, @count int = 0
    declare @t table(recipeid int) 

    select @RecipeName = nullif(@RecipeName, '')

    insert @t(r.recipeid)
    select r.RecipeId
    from Recipe r 
    where r.recipeid = @RecipeId
    or @All = 1 
    or r.RecipeName like '%' + @RecipeName + '%'

    select @count = count(*)
    from @t

    if @count > 7
    begin 
        select @message = concat ('Searching for ', @count, ' Recipes, max search is 7') 
        select @return = 1
        goto finished
    end 

    select *, IsDeleteAllowed = dbo.IsRecipeDeleteAllowed(r.RecipeId)
    from @t t 
    join Recipe r 
    on r.RecipeId = t.recipeid

    finished:
    return @return
end
go 

--exec RecipeGet @ALL = 1