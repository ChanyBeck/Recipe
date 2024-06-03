create or alter function dbo.MealCalories(@MealId int)
returns int

as 
begin 
    declare @value int = 0; 

    select @value = sum(r.Calories)
    from Meal m 
    join MealCourse mc 
    on mc.MealId = m.MealId
    join MealCourseRecipe mcr 
    on mcr.MealCourseId = mc.MealCourseId
    join Recipe r 
    on r.RecipeId = mcr.RecipeId
    where m.MealId = @MealId

    return @value
end 
go

select Calories = dbo.MealCalories(m.MealId), * from meal m 