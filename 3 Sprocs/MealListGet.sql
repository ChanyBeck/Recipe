create or alter procedure dbo.MealListGet(
    @All int = 1
)

as 
begin 

    select m.MealId, m.MealName, 'User'  = concat(u.FirstName, ' ', u.LastName), 'Calories' = dbo.MealCalories(m.MealId), 'Num Courses' = count(c.CourseId), 'Num Recipes' = count(r.RecipeId)
    from Meal m 
    join Users u 
    on u.UsersId = m.UsersId
    join MealCourse c 
    on c.MealId = m.MealId
    join MealCourseRecipe r 
    on r.MealCourseId = c.MealCourseId
    group by m.MealName, u.FirstName, u.LastName, m.MealId

end 