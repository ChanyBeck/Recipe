create or alter procedure dbo.RecipeDirectionUpdate(
    @RecipeDirectionId int = 0, 
	@RecipeId int = 0,
    @Direction varchar (1000) = '',
    @DirectionSequence int = 0,
    @Message varchar(500) = ''  output
)
as 
begin 
    declare @return int = 0

    select @RecipeId = isnull(@RecipeId, 0)

    if @recipeid = 0
    begin 
        insert RecipeDirection(RecipeId, Direction, DirectionSequence)
        values (@RecipeId, @Direction, @DirectionSequence)
    end 
    else 
    begin 
        update RecipeDirection
        set 
        RecipeId = @RecipeId,
        Direction = @Direction,
        DirectionSequence = @DirectionSequence
        where RecipeDirectionId = @RecipeDirectionId
    end 
    return @return
end 
go 