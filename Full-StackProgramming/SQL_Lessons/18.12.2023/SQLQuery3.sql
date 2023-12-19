--TRUNCATE

TRUNCATE TABLE ogrenciler

select * from Ogrenciler

delete from Ogrenciler where Not1=30

--ID isimli alana int veri tipi idendity ozelligi verelim

alter table Ogrenciler add ID int primary key identity

insert into Ogrenciler (Ogrencino,AdSoyad,Yas,Not1)values (547,'Ali Ylmaz',16, 80)
insert into Ogrenciler (Ogrencino,AdSoyad,Yas,Not1)values (547,'Naz Ylmaz',16, 90)
insert into Ogrenciler (Ogrencino,AdSoyad,Yas,Not1)values (547,'Semiha Ylmaz',16, 65)
select * from Ogrenciler


delete from Ogrenciler

truncate table ogrenciler 

select sum(not1) from Ogrenciler

select MAX(not1) from Ogrenciler

select AVG(not1) from Ogrenciler

alter table ogrenciler
alter column not1 bigint

select * from Ogrenciler where AdSoyad like '[a-d]' and AdSoyad like '[a-z]'

use Northwind
select * from Musteriler

select * from Musteriler where Sehir like '[a-d]%'

select top 3 * from Musteriler order by MusteriID asc
select * from Musteriler order by MusteriID desc 

select top 10 * from Musteriler order by MusteriID desc

select * from Urunler where UrunAdi like 'Cho%'

select * from urunler where UrunAdi like '%i'

select * from urunler where UrunAdi like '[a-t]%' and UrunAdi like '%a'

select * from urunler where HedefStokDuzeyi between 10 and 50

select * from urunler

select top 7 * from Urunler  where HedefStokDuzeyi between 10 and 50

select * from Musteriler

select top 10 percent * from musteriler order by MusteriID desc

select top 10 percent * from Musteriler where MusteriUnvani='Owner'

select top 10 percent * from Musteriler where MusteriUnvani<>'Owner'

select KategoriAdi as Katalog, Tanimi as 'Katalog Aciklama' from Kategoriler

--satýþlar tablosunda sevkadý v ile baþlayanlarý getiren sorgu

select * from Satislar

Select * From Satislar where SevkAdi like 'v%'

--satýþlar tablosu ödeme tarihini between ile sýralama yapan sorgu
--1997 yýlý verileri gelsin

Select * from Satislar where OdemeTarihi between '1997-01-01' and '1997-12-31'

