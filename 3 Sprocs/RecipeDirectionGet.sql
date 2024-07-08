create or alter procedure dbo.RecipeDirectionGet(
    @RecipeDirectionId int = 0 output, 
	@RecipeId int = 0,
    @All bit = 0, 
    @Message varchar(500) = ''  output
)  
as 
begin 
    declare @return int = 0

	select @All = isnull(@All,0), @RecipeDirectionId = isnull(@RecipeDirectionId,0)

	select d.RecipeDirectionId, d.Direction, d.DirectionSequence, d.RecipeId
	from RecipeDirection d
	where d.RecipeDirectionId = @RecipeDirectionId
	or d.RecipeId = @recipeId
	or @All = 1
	order by d.DirectionSequence

	return @return
end
go 
