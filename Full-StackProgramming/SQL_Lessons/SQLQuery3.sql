--dml komutlar�
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
--Art�k pk olan alan benzersiz olur. Her tabloda bir tane pk alan olur.

insert into Malzemeler
(MalzemeNo,MalzemeAdi,Fiyat,Adet,UretimYeri) values(1,'Bilgisayar',40000,2,'Bursa')
insert into Malzemeler(MalzemeNo,MalzemeAdi,Fiyat,Adet,UretimYeri)values
(2,'�t�',15000,1,'T�rkiye')

update Malzemeler set UretimYeri='�ngiltere' where MalzemeAdi='Bilgisayar'
--malzeme ad� bilgisayar olan kayd�n �retim yerini ingiltere olarak de�i�tiren sorgu.
--update varolan verilerimizde de�i�iklik yapmak istersek kullan�l�r.

--malzemeno 2 olan verinin adeti 8 olarak de�i�tirilsin
update Malzemeler set adet = 8 where MalzemeNo = 2

delete from Malzemeler where MalzemeNo=2

delete from Malzemeler 
--malzeme adl� tablomdaki t�m verileri siler.

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
insert into Personeller(AdSoyad,Adres,Maas,Prim)values('G�lizar Jale','Ankara',28000,1750)