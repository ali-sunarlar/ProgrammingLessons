select * from Musteriler
--musteriler tablosundaki tüm kayýtlarý getirir

select MusteriAdi,Sehir,Ulke from Musteriler
--belirlediðimiz alanlarý getirir.

select * from Satislar

select OdemeTarihi,SevkTarihi,NakliyeUcreti from Satislar where SevkAdi='Hanari Carnes'

select * from Urunler
--birim fiyatý>20 ve  hedefstokdüzeyi<50

select * from Urunler where BirimFiyati>20 and HedefStokDuzeyi<50


--chai (birim fiyatý, hedefstokduzeyini getiren sorgu)

select BirimFiyati,HedefStokDuzeyi from Urunler where UrunAdi = 'Chai'

--sevkulkesi brazil olanlarýn nakliye ücreti 40 den düþük olanlarýn 
--bilgilerini getiren sorgu

select * from Satislar

select * from Satislar where SevkUlkesi = 'Brazil' and NakliyeUcreti < 40


--order by : sýralama yapmak için kullanýlýr.
--2 anahtar kelimesi var
-- asc : baþtan sona küçükten büyüðe doðru sýralama yapar
--desc : sondan baþa doðru büyükten küçüðe sýralama yapar.

select * from Musteriler
--müþteri adlarýný artan sýralama olarak yazdýr
 select * from Musteriler order by MusteriAdi asc

 
 select * from Satislar
 --satýþlar tablosundan nakliye ücretini azalan sýralama yapýn

 select * from Satislar order by NakliyeUcreti desc
 
 --urunler tablosundaki birim fiyatý 10 dan küçük olanlarý artan sýrala ile gösterelim
select * from Urunler where BirimFiyati < 10 order by BirimFiyati ASC


