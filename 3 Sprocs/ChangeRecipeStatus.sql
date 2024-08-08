create or alter procedure dbo.ChangeRecipeStatus(
    @RecipeId int,
    @NewStatus varchar (20) 
)
as 
begin 
    
    select @RecipeId = isnull(@RecipeId, 0)

    update Recipe  
    set DateDrafted =
    case @NewStatus when 'Draft' then CURRENT_TIMESTAMP else DateDrafted end,
    DatePublished = 
    case @NewStatus when 'Draft' then null when 'Published' then CURRENT_TIMESTAMP else DatePublished end,
    DateArchived = 
    case @NewStatus when 'Archived' then CURRENT_TIMESTAMP else null end
    where RecipeId = @RecipeId

end 
go 