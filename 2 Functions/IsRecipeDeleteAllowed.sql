create or alter function dbo.IsRecipeDeleteAllowed(@RecipeId int)
returns varchar (100)
as 
begin 
    declare @value varchar (100) = ''
    if exists(select * from Recipe r where r.RecipeId = @RecipeId and (r.RecipeStatus = 'Published' or datediff(day, getdate(), r.DateArchived) < 30 ))
    begin
        select @value = 'cannot delete recipe that is either published or has been archived within 30 days'
    end 
    return @value
end 
go

select dbo.IsRecipeDeleteAllowed(r.RecipeId), * from Recipe r 