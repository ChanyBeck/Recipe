create or alter procedure dbo.MeasurementDelete(
    @MeasurementId int,
    @Message varchar(500) = '' output
)
as 
begin 
    declare @return int = 0 

	select @MeasurementId = isnull(@MeasurementId,0)

    begin try

        delete Measurement where measurementId = @MeasurementId

    end try
    begin catch
        rollback;
        throw
    end catch

	return @return
end
go 
