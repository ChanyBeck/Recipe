create or alter procedure dbo.CuisineUpdate(
    @CuisineId int,
    @CuisineType varchar (50)
)
as 
begin 
    declare @return int = 0

    select @CuisineId = isnull(@CuisineId, 0)

    if @Cuisineid = 0
    begin 
        insert Cuisine(CuisineType)
        values (@CuisineType)
    end 
    else 
    begin 
        update Cuisine 
        set 
        Cuisinetype = @Cuisinetype
        where CuisineId = @Cuisineid
    end 
    return @return
end 
go 