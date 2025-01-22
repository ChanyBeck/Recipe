create or alter procedure dbo.RecipeGet(
@RecipeId int = 0, 
@All bit = 0, 
@RecipeName varchar(50) = '', 
@IncludeBlank bit = 0,
@message varchar (1000) = '' output)  

as 
begin 
    declare @return int = 0, @count int = 0
    declare @t table(RecipeId int) 

    select @RecipeName = nullif(@RecipeName, ''), @IncludeBlank = isnull(@IncludeBlank, 0)

    insert @t(r.RecipeId)
    select r.RecipeId
    from Recipe r 
    where r.recipeid = @RecipeId
    or @All = 1 
    or r.RecipeName like '%' + @RecipeName + '%'
    order by r.recipestatus desc

    select @count = count(*)
    from @t

    if @count > 30
    begin 
        select @message = concat ('Searching for ', @count, ' Recipes, max search is 30') 
        select @return = 1
        goto finished
    end 

    select *, IsDeleteAllowed = dbo.IsRecipeDeleteAllowed(r.RecipeId)
    from @t t 
    join Recipe r 
    on r.RecipeId = t.recipeid
    union select 0, 0, 0, 0, '', '', '', '', '', '', '', ''
    where @IncludeBlank = 1
    

    finished:
    return @return
end
go 

--exec RecipeGet @includeblank = 1,  @ALL = 1

--select * from Recipe