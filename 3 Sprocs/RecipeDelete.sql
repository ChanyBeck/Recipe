
create or alter procedure dbo.RecipeDelete(
    @RecipeId int,
    @Message varchar(500) = '' output
)
as 
begin 
    declare @return int = 0
    if exists(select * from Recipe r where r.RecipeId = @RecipeId and (r.RecipeStatus = 'Published' or datediff(day, getdate(), r.DateArchived) < 30 ))
    begin
        select @return = 1, @Message = 'cannot delete recipe that is either published or archived within 30 days'
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

