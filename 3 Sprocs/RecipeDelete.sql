
create or alter procedure dbo.RecipeDelete(
    @RecipeId int,
    @Message varchar(500) = '' output
)
as 
begin 
    declare @return int = 0, @deleteallowed varchar(100) = ''
    select @deleteallowed = isnull(dbo.IsDeleteAllowed(@RecipeId), '')
    if @deleteallowed <> ''
        select @return = 1, @Message = @deleteallowed
        goto finished
    end
    begin try
        begin tran
        delete RecipeDirection where recipeid = @RecipeId
        delete RecipeIngrediant where recipeid = @RecipeId
        delete recipe where recipeid = @RecipeId
        commit
    end try
    begin catch
        rollback;
        throw
    end catch
    finished:
    return @return 
end
go

