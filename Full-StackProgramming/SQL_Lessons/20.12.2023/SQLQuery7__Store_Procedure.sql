--SpExample ad�nda veri taban� olu�tural�m

--Users adl� tablo ve i�erisine de Name (nvarchar) , SurName (nvarchar),Email(nvarchar) 'e mail alan� bo� ge�ilemez'

--sp_InsertUser isimli procedure olu�tural�m
--Name,SurName,Email

use SpExample
create procedure InsertUser
@Name nvarchar(50), 
@SurName nvarchar(50), 
@E_Mail nvarchar(30) 
as 
insert into Users(Name , SurName, E_Mail) values (@Name, @SurName, @E_Mail)


exec InsertUser 'Salih', 'Can', 'salih@gmail.com'

--sp_UpdateUser isimli procedure olu�tural�m
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

--sp_DeleteUser ad�nda prosed�r tan�mlayal�m
--SurName parametre
--SurName e g�re silme i�lemini ger�ekle�tirsin

create procedure DeleteUser 

@SurName nvarchar(50)
as 
delete from Users where SurName = @SurName

exec DeleteUser 'Can'

--sp_SelectUser isimli procedure olu�tur

create procedure sp_SelectUsers 
as
select * from Users 

exec sp_SelectUsers

