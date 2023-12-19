use Northwind

--Tüm Müþterileri listeleyiniz
select * from Musteriler

--tüm müþterilerin sadece MusteriAdi ve MusteriUnvanini listeleyin
select MusteriAdi,MusteriUnvani from Musteriler

--birim fiyatý 18 ve üzeri olan ürünleri listeleyiniz
select * from Urunler
select * from Urunler where BirimFiyati >= 18

--þehir bilgisi London olan tüm personlleri listeleyiniz
select * from Personeller where Sehir='London'

-- KategoriID si 3 olan ve birim fiyatý 10 dan küçük olan tüm ürünleri listeleyiniz
select * from Urunler where KategoriID=3 and BirimFiyati<10

--þehir bilgisi London veya Seattle olan tüm personelleri listeleyiniz
select * from Personeller where Sehir='London' or Sehir='Seattle'

--3,5 veya 7 nolu kategorideki tüm ürünleri listeleyin.(urunler-kategoriID)
select * from Urunler where KategoriID = 3 or KategoriID = 5 or KategoriID = 7
select * from Urunler where KategoriID in (3, 5, 7)

--6 ve 8 nolu kategorideki ürünler dýþýndaki tüm ürünleri listeleyin
select * from Urunler where KategoriID NOT IN (6, 8)
select * from Urunler where KategoriID!=6 and KategoriID!=8

--birim fiyatý 10 ve 20 arasýndaki tüm ürünleri listeleyiniz
select * from Urunler where BirimFiyati>=10 and BirimFiyati<=20
select * from Urunler where BirimFiyati between 10 and 20

--Satýþlar tablosunda 1996-07-16 ile 1996-07-30 arasýnda sevk edilen satýþlarý listeleyin

select * from Satislar where SevkTarihi between '1996-07-16' and '1996-07-30'

--musteriler tablosunda bölgesi olmayan tüm müþterileri listeleyin
select * from Musteriler
select * from Musteriler where Bolge is Null

--musteriler tablosunda faks numarasý olan tüm müþterileri listeleyiniz
select * from Musteriler where Faks IS NOT NULL

--musteriler tablosunda manager ünvanýna sahip tüm ürünleri listeleyin
select * from Musteriler Where MusteriUnvani like '%Manager'

--ürünler tablosunda birim fiyatý 10 un altýnda olan ürünlerin kategoriID lerini tekil bir þekilde listeleyiniz

select distinct KategoriID from Urunler  where BirimFiyati<10
select * from Urunler

--urunler tablosunda en düþük birim fiyatýna sahip 5 ürünü listeleyiniz
select top 5 * from Urunler order by BirimFiyati asc

--en yüksek birim fiyatýna sahip 10 ürünü listeleyin
select top 10 * from Urunler order by BirimFiyati desc

--müþterileri ülke ve þehir bilgisine göre sýralayýp listeleyiniz
select * from Musteriler
select * from Musteriler order by Ulke asc,Sehir asc

--personellerin ad, soyad ve yaþ bilgilerini listeleyin
select Adi,SoyAdi,DATEDIFF(yy,DogumTarihi,GETDATE()) Yas from Personeller

--satýþlar tablosunda 35 gün içinde sevk edilmeyen satýþlarý listeleyin
select * from Satislar
Select * from Satislar where DATEDIFF(DD,SatisTarihi,SevkTarihi)>35

--ürünler tablosunda birim fiyatý en yüksek olan ürünün kategoriler tablosundan kategori adýný listeleyin.
select KategoriAdi from Kategoriler where KategoriID = (select KategoriID from Urunler where BirimFiyati = (SELECT MAX(BirimFiyati) from Urunler))

select KategoriAdi from Kategoriler where KategoriID=(select top 1 KategoriID from Urunler order by BirimFiyati desc)

--satýþlar tablosunda 1996 yýlýnda yapýlan sipariþleri listeleyin
select * from Satislar
select * from Satislar where DATEPART(yy,satistarihi)=1996

select * from Satislar where YEAR(SatisTarihi) = 1996

select * from Satislar where SatisTarihi BETWEEN '1996-01-01' AND '1996-12-31'

--ürünler tablosunda her bir kategoride kaç adet ürün var listeleyiniz
select KategoriID,count(*) from Urunler group by KategoriID

