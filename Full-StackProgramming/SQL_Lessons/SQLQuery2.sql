--Avm database
--Plaza table
--PlazoNo,PlazaAd,CalisanSayisi Alanlar�

create database Avm 
create table Plaza
(
PlazaNo int not null,
PlazaAd varchar(40) null,
CalisanSayisi int null
)

--alter: varolan �zerinde de�i�iklik yap�l�r

alter table Ogrenciler add Not1 int
alter table Ogrenciler add mail varchar(20)
alter table Ogrenciler drop column Odeme

use Okul
