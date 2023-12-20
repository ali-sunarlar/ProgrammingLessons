--Stored Procedure (Saklý Yordam)

create database Okul1
use Okul1

create table ogrenci
(
adi varchar(20),
soyadi nvarchar(25),
ogr_no numeric(10),
bolum nchar(5), 
sehir nvarchar(30)
)

create PROCEDURE liste
as
select * from ogrenci

exec liste


create procedure ekle
@isim nvarchar(20),
@sisim nvarchar(25),
@num numeric(10),
@bol nchar(5),
@il  nvarchar(30)
as
insert into ogrenci (adi,soyadi,ogr_no,bolum,sehir) values (@isim,@sisim,@num,@bol,@il)

exec ekle 'Hakký','Kanim',512,BLG,'Tokat'


create procedure sil
@id numeric(10)
as
delete from ogrenci where ogr_no=@id

exec sil 512


create procedure guncelle
@il nvarchar(30),
@id numeric(10)
as
update ogrenci set sehir=@il where ogr_no=@id

exec guncelle 'Ankara',2018

create procedure ara
@isim nvarchar(20)
as
select * from ogrenci where adi like '%'+@isim+'%'

exec ara 'yl'