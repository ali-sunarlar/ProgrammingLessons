--dml komutlarý
--insert (ekleme ,kaydetme)

create database Magaza

use Magaza
create table Malzemeler
(
MalzemeNo int primary key,
MalzemeAdi varchar(50),
Fiyat int,
Adet int,
UretimYeri varchar(50)
)
--primary key(pk): Birincil Anahtar demektir. 
--Artýk pk olan alan benzersiz olur. Her tabloda bir tane pk alan olur.

insert into Malzemeler
(MalzemeNo,MalzemeAdi,Fiyat,Adet,UretimYeri) values(1,'Bilgisayar',40000,2,'Bursa')
insert into Malzemeler(MalzemeNo,MalzemeAdi,Fiyat,Adet,UretimYeri)values
(2,'Ütü',15000,1,'Türkiye')

update Malzemeler set UretimYeri='Ýngiltere' where MalzemeAdi='Bilgisayar'
--malzeme adý bilgisayar olan kaydýn üretim yerini ingiltere olarak deðiþtiren sorgu.
--update varolan verilerimizde deðiþiklik yapmak istersek kullanýlýr.

--malzemeno 2 olan verinin adeti 8 olarak deðiþtirilsin
update Malzemeler set adet = 8 where MalzemeNo = 2

delete from Malzemeler where MalzemeNo=2

delete from Malzemeler 
--malzeme adlý tablomdaki tüm verileri siler.

--personeller table
--personelno (pk), adsoyad,adres,maas,prim

create table Personeller
(
PersonelNo int primary key identity(1,1),
AdSoyad varchar(50),
Adres varchar(50),
Maas int,
Prim int
)

insert into Personeller(AdSoyad,Adres,Maas,Prim)values('Zerrin Tok','Ankara',30000,2000)
insert into Personeller(AdSoyad,Adres,Maas,Prim)values('Kamil Kuleli','Erzincan',35000,2500)
insert into Personeller(AdSoyad,Adres,Maas,Prim)values('Gülizar Jale','Ankara',28000,1750)