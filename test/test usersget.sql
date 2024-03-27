declare @Id int
select top 1 @Id = u.UsersId from Users u
exec UsersGet @UsersId = @Id -- return one record

exec UsersGet --return empty result set

exec UsersGet @All = 1 --return all records

exec UsersGet @UserName = 'G' --return records with Users name G

exec UsersGet @UserName = '' --return empty result set