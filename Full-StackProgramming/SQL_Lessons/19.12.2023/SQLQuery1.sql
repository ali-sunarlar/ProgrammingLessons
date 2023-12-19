use Northwind

--T�m M��terileri listeleyiniz
select * from Musteriler

--t�m m��terilerin sadece MusteriAdi ve MusteriUnvanini listeleyin
select MusteriAdi,MusteriUnvani from Musteriler

--birim fiyat� 18 ve �zeri olan �r�nleri listeleyiniz
select * from Urunler
select * from Urunler where BirimFiyati >= 18

--�ehir bilgisi London olan t�m personlleri listeleyiniz
select * from Personeller where Sehir='London'

-- KategoriID si 3 olan ve birim fiyat� 10 dan k���k olan t�m �r�nleri listeleyiniz
select * from Urunler where KategoriID=3 and BirimFiyati<10

--�ehir bilgisi London veya Seattle olan t�m personelleri listeleyiniz
select * from Personeller where Sehir='London' or Sehir='Seattle'

--3,5 veya 7 nolu kategorideki t�m �r�nleri listeleyin.(urunler-kategoriID)
select * from Urunler where KategoriID = 3 or KategoriID = 5 or KategoriID = 7
select * from Urunler where KategoriID in (3, 5, 7)

--6 ve 8 nolu kategorideki �r�nler d���ndaki t�m �r�nleri listeleyin
select * from Urunler where KategoriID NOT IN (6, 8)
select * from Urunler where KategoriID!=6 and KategoriID!=8

--birim fiyat� 10 ve 20 aras�ndaki t�m �r�nleri listeleyiniz
select * from Urunler where BirimFiyati>=10 and BirimFiyati<=20
select * from Urunler where BirimFiyati between 10 and 20

--Sat��lar tablosunda 1996-07-16 ile 1996-07-30 aras�nda sevk edilen sat��lar� listeleyin

select * from Satislar where SevkTarihi between '1996-07-16' and '1996-07-30'

--musteriler tablosunda b�lgesi olmayan t�m m��terileri listeleyin
select * from Musteriler
select * from Musteriler where Bolge is Null

--musteriler tablosunda faks numaras� olan t�m m��terileri listeleyiniz
select * from Musteriler where Faks IS NOT NULL

--musteriler tablosunda manager �nvan�na sahip t�m �r�nleri listeleyin
select * from Musteriler Where MusteriUnvani like '%Manager'

--�r�nler tablosunda birim fiyat� 10 un alt�nda olan �r�nlerin kategoriID lerini tekil bir �ekilde listeleyiniz

select distinct KategoriID from Urunler  where BirimFiyati<10
select * from Urunler

--urunler tablosunda en d���k birim fiyat�na sahip 5 �r�n� listeleyiniz
select top 5 * from Urunler order by BirimFiyati asc

--en y�ksek birim fiyat�na sahip 10 �r�n� listeleyin
select top 10 * from Urunler order by BirimFiyati desc

--m��terileri �lke ve �ehir bilgisine g�re s�ralay�p listeleyiniz
select * from Musteriler
select * from Musteriler order by Ulke asc,Sehir asc

--personellerin ad, soyad ve ya� bilgilerini listeleyin
select Adi,SoyAdi,DATEDIFF(yy,DogumTarihi,GETDATE()) Yas from Personeller

--sat��lar tablosunda 35 g�n i�inde sevk edilmeyen sat��lar� listeleyin
select * from Satislar
Select * from Satislar where DATEDIFF(DD,SatisTarihi,SevkTarihi)>35

--�r�nler tablosunda birim fiyat� en y�ksek olan �r�n�n kategoriler tablosundan kategori ad�n� listeleyin.
select KategoriAdi from Kategoriler where KategoriID = (select KategoriID from Urunler where BirimFiyati = (SELECT MAX(BirimFiyati) from Urunler))

select KategoriAdi from Kategoriler where KategoriID=(select top 1 KategoriID from Urunler order by BirimFiyati desc)

--sat��lar tablosunda 1996 y�l�nda yap�lan sipari�leri listeleyin
select * from Satislar
select * from Satislar where DATEPART(yy,satistarihi)=1996

select * from Satislar where YEAR(SatisTarihi) = 1996

select * from Satislar where SatisTarihi BETWEEN '1996-01-01' AND '1996-12-31'

--�r�nler tablosunda her bir kategoride ka� adet �r�n var listeleyiniz
select KategoriID,count(*) from Urunler group by KategoriID

