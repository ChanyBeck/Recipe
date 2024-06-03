declare @TableName varchar (50) = 'Recipe'
select 
    concat('@', c.Column_Name ,' ', c.DATA_TYPE,' ', 
    case when c.CHARACTER_MAXIMUM_LENGTH is null then '' else concat('(', c.CHARACTER_MAXIMUM_LENGTH, ')' )end, 
    case when c.TABLE_NAME + 'Id' = c.Column_Name then ' output' else '' end,
    ',')
from INFORMATION_SCHEMA.COLUMNS c 
where c.TABLE_NAME = @TableName

declare @insertlist varchar (5000) = ''

select @insertlist = @insertlist + concat(c.Column_Name, ', ') from INFORMATION_SCHEMA.COLUMNS c 
where c.TABLE_NAME = @TableName
and c.COLUMN_Name <> c.table_name + 'id'

select @insertlist

select @insertlist = ''

select @insertlist = @insertlist + concat('@', c.Column_Name, ', ') from INFORMATION_SCHEMA.COLUMNS c 
where c.TABLE_NAME = @TableName
and c.COLUMN_Name <> c.table_name + 'id'

select @insertlist

select concat(c.Column_Name, ' = ','@', c.Column_Name, ', ') from INFORMATION_SCHEMA.COLUMNS c 
where c.TABLE_NAME = @TableName
and c.COLUMN_Name <> c.table_name + 'id'