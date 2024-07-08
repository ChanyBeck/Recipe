create or alter procedure dbo.DashboardGet(
    @All int = 1
)
as 
begin 

select Type = 'Recipes', Number = count(*)
from Recipe
union select 'Meals', count(*)
from Meal
union select 'Cookbooks', count(*)
from CookBook

end 
go 
