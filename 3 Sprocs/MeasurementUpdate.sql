create or alter procedure dbo.MeasurementUpdate(
    @MeasurementId int output,
    @MeasurementType varchar (20),
    @Message varchar(500) = '' output
)
as 
begin 
    declare @return int = 0

    select @MeasurementId = isnull(@MeasurementId, 0)

    if @MeasurementId = 0
    begin 
        insert Measurement(measurementType)
        values (@MeasurementType)

        select @MeasurementId = SCOPE_IDENTITY();
    end 
    else 
    begin 
        update Measurement 
        set 
        measurementType = @MeasurementType
        where measurementId = @MeasurementId
    end 
    return @return
end 
go 