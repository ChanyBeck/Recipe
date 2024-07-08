create or alter function dbo.RecipeDesc(@RecipeId int)
returns varchar (120)

as 
begin 
    declare @value varchar (120)


    select @value = concat(r.RecipeName, ' (', c.CuisineType, ' ) has ', case when max(ri.IngredientSequence) is null then 0 else max(ri.IngredientSequence) end, ' ingrediants and ', case when max(rd.DirectionSequence) is null then 0 else max(rd.DirectionSequence) end, ' steps.') 
    from Recipe r 
    left join Cuisine c 
    on c.CuisineId = r.CuisineId 
    left join RecipeDirection rd 
    on rd.RecipeId = r.RecipeId
    left join RecipeIngredient ri 
    on ri.RecipeId = r.RecipeId
    where r.RecipeId = @RecipeId
    group by r.RecipeName, c.CuisineType

    return @value
end 
go

select RecipeDesc = dbo.RecipeDesc(r.RecipeId), * from Recipe r