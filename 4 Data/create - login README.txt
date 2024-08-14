script to create login and user is excluded from this repo. 
Create a file called create - login.sql 
add the following to the file 

create login [loginname] with Password = '[password]'

create user [username] from login [loginname]