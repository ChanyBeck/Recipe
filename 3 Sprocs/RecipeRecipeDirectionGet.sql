create or alter procedure dbo.RecipeRecipeDirectionGet(
    @RecipeRecipeDirectionId int = 0 output, 
    @RecipeId int = 0 output,
    @All bit = 0,
    @Message varchar(500) = ''  output
)  
as 
begin 
    declare @return int = 0

	select @RecipeRecipeDirectionId = isnull(@RecipeRecipeDirectionId,0)

	select d.RecipeDirectionId, d.Direction, d.DirectionSequence
	from RecipeDirection d
	where d.RecipeId = @RecipeId
    or @All = 1
    order by DirectionSequence

	return @return
end
go 
