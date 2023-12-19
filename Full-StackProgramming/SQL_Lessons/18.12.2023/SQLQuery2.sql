create database Market
use Market
create table Personeller
(
PersonelNo int primary key identity,
AdSoyad varchar(50),
Adres varchar(50),
Maa int
)
insert into Personeller(AdSoyad,Adres,Maa)values('Ahmet Aytaç','Ankara',32000)
insert into Personeller(AdSoyad,Adres,Maa) values ('Savaþ Düzgün', 'Ýstanbul', 30000)
insert into Personeller(AdSoyad,Adres,Maa)values('Zerrin Tekin','Ýstanbul',43000)
select *from Personeller

insert into Personeller(AdSoyad,Adres,maa)values('Ahmet Aytaç','Ankara',32000)





