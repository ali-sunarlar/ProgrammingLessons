select * from Musteriler
--musteriler tablosundaki t�m kay�tlar� getirir

select MusteriAdi,Sehir,Ulke from Musteriler
--belirledi�imiz alanlar� getirir.

select * from Satislar

select OdemeTarihi,SevkTarihi,NakliyeUcreti from Satislar where SevkAdi='Hanari Carnes'

select * from Urunler
--birim fiyat�>20 ve  hedefstokd�zeyi<50

select * from Urunler where BirimFiyati>20 and HedefStokDuzeyi<50


--chai (birim fiyat�, hedefstokduzeyini getiren sorgu)

select BirimFiyati,HedefStokDuzeyi from Urunler where UrunAdi = 'Chai'

--sevkulkesi brazil olanlar�n nakliye �creti 40 den d���k olanlar�n 
--bilgilerini getiren sorgu

select * from Satislar

select * from Satislar where SevkUlkesi = 'Brazil' and NakliyeUcreti < 40


--order by : s�ralama yapmak i�in kullan�l�r.
--2 anahtar kelimesi var
-- asc : ba�tan sona k���kten b�y��e do�ru s�ralama yapar
--desc : sondan ba�a do�ru b�y�kten k����e s�ralama yapar.

select * from Musteriler
--m��teri adlar�n� artan s�ralama olarak yazd�r
 select * from Musteriler order by MusteriAdi asc

 
 select * from Satislar
 --sat��lar tablosundan nakliye �cretini azalan s�ralama yap�n

 select * from Satislar order by NakliyeUcreti desc
 
 --urunler tablosundaki birim fiyat� 10 dan k���k olanlar� artan s�rala ile g�sterelim
select * from Urunler where BirimFiyati < 10 order by BirimFiyati ASC


