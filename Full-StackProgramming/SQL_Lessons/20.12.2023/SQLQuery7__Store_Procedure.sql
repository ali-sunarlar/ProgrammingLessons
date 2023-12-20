--SpExample adýnda veri tabaný oluþturalým

--Users adlý tablo ve içerisine de Name (nvarchar) , SurName (nvarchar),Email(nvarchar) 'e mail alaný boþ geçilemez'

--sp_InsertUser isimli procedure oluþturalým
--Name,SurName,Email

use SpExample
create procedure InsertUser
@Name nvarchar(50), 
@SurName nvarchar(50), 
@E_Mail nvarchar(30) 
as 
insert into Users(Name , SurName, E_Mail) values (@Name, @SurName, @E_Mail)


exec InsertUser 'Salih', 'Can', 'salih@gmail.com'

--sp_UpdateUser isimli procedure oluþturalým
-- Name, SurName, E_Mail parametrelerim olsun

create Proc sp_UpdateUser
(
@Name nvarchar(50),
@SurName nvarchar(50),
@Email nvarchar(30)
)
as 
begin
update Users set Name=@Name,SurName=@SurName,E_Mail=@Email where SurName=@SurName
End

exec sp_UpdateUser 'Zerrin','Leman','zerrin@gmail.com'

--sp_DeleteUser adýnda prosedür tanýmlayalým
--SurName parametre
--SurName e göre silme iþlemini gerçekleþtirsin

create procedure DeleteUser 

@SurName nvarchar(50)
as 
delete from Users where SurName = @SurName

exec DeleteUser 'Can'

--sp_SelectUser isimli procedure oluþtur

create procedure sp_SelectUsers 
as
select * from Users 

exec sp_SelectUsers

