create database Market
use Market
create table Personeller
(
PersonelNo int primary key identity,
AdSoyad varchar(50),
Adres varchar(50),
Maa int
)
insert into Personeller(AdSoyad,Adres,Maa)values('Ahmet Ayta�','Ankara',32000)
insert into Personeller(AdSoyad,Adres,Maa) values ('Sava� D�zg�n', '�stanbul', 30000)
insert into Personeller(AdSoyad,Adres,Maa)values('Zerrin Tekin','�stanbul',43000)
select *from Personeller

insert into Personeller(AdSoyad,Adres,maa)values('Ahmet Ayta�','Ankara',32000)





