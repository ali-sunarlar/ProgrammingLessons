--Saklý Yordam (Store Procedured), kaydedebileceðiniz hazýrlanmýþ sql kodu.
--•  Saklý yordamlar, SQL Server 'a esneklik ve hýz kazandýrýrlar.
--•  Önceden derlenmiþ olduðu için, normal kullanýlan bir SQL sorgusunun tekrar tekrar çalýþtýrýlmasýna oranla daha fazla performans elde edilmesine saðlarlar. 
--•  Bir kez yazýlýp, tekrar tekrar kullanýldýðý için modüler bir yapýda program geliþtirilmiþ olur. 
--•  Ayný Transact-SQL cümleciðini birden fazla yerde kullanýlacaðý zaman, bunu bir saklý yordam haline getirerek, kullanýmýný sadece ismini çaðýrma ile gerçekleþtirilebilir. 
--•  Belirli girdi ve çýktý parametreleri olduðu için, saklý yordamlarýn kullanýmý ile güvenlik açýsýdan yöneticiyi de saðlama almýþ olur. 
--•  Að trafiðini azaltýr. Ýstemci tarafýndan birçok satýra sahip SQL komutunun sunucuya gitmesindense, sadece saklý yordamýn adýnýn sunucuya gitmesi aðý daha az meþgul etmiþ olur. 

--Kullanýmý:

--create Procedure ProcedureAdi
--varsa paraetreler yazýlýr
--as
--sql Kodlarý yazýlýr

--exec ProcedureAdi yazarak çalýþtýrýlýr.
--varsa parametrelerimizi de ekleriz.

use Northwind
--Tüm Müþterileri listeleyen SP yazýnýz.

create Procedure spTumMusteriler
as
select * from Musteriler

exec spTumMusteriler

--Dýþarýdan gönderilen bilgilere göre Nakliyeci kaydeden SP yazýnýz

create proc spNakliyeciEkle
@sirketAdi nvarchar(40),
@telefon nvarchar (11)
as
insert into Nakliyeciler (SirketAdi,Telefon) values (@sirketAdi,@telefon)

exec spNakliyeciEkle @sirketAdi='BBBBB', @telefon='2144444444'

--Dýþarýdan gönderilen bilgilere göre Nakliyecinin tüm bilgilerini güncelleyen SP yazýnýz.
----procedure ismi spNakliyeciDuzenle--parametreler olacak..

CREATE PROC spNakliyeciDuzenle 
@NakliyeciID int,
@SirketAdi nvarchar(40), 
@telefon nvarchar(24) 
as 
UPDATE Nakliyeciler SET SirketAdi = @sirketAdi, telefon = @telefon where NakliyeciID=@NakliyeciID

exec spNakliyeciDuzenle 1, 'Express','(741) 852 96 32'

--exec spNakliyeciDuzenle @nakliyeciID=1, @sirketAdi='Express', @telefon='(741) 852 96 32'   þeklinde de yazýlabilir.

--Dýþarýdan gönderilen bilgiye göre Nakliyeciyi silen SP yazýnýz.
--procedure ismi spNakliyeciSil , NakliyeciID parametresini kullan
create procedure spNakliyeciSil
@NakliyeciID int 
as
DELETE FROM Nakliyeciler WHERE NakliyeciID=@NakliyeciID

exec spNakliyeciSil 6

--dýþarýdan gönderilen bilgilere göre Nakliyeci kaydeden SP yazýnýz. Ayný telefon numarasý varsa kaydetmeyiniz.
--spNakliyecilerEkle procedure ismi

create proc spNakliyecilerEkle
@SirketAdi nvarchar (40),
@Telefon nvarchar (20)
as
declare @sayi int
set @sayi=(select count(*) from Nakliyeciler where Telefon=@Telefon)
if @sayi>0
begin 
print 'Böyle bir telefon numarasý kayýtlý'
end
else
begin
insert into Nakliyeciler (SirketAdi,Telefon)
values (@SirketAdi,@Telefon)
print 'Nakliyeci Eklendi'
end

exec spNakliyecilerEkle 'ZZZZZ','(741) 852 96 00'

--Gönderilen KategoriID ye göre ürünler i listeleyen SP yazýnýz.(UrunID,UrunAdi,KategoriAdi)

create proc spUrunlerKategoriID
@KategoriID int
as
select u.UrunID,u.UrunAdi,k.KategoriID from Urunler u inner join Kategoriler k on u.KategoriID=k.KategoriID where k.KategoriID=@KategoriID

exec spUrunlerKategoriID 4


--Dýþarýdan gönderilen musteriID ye göre o müþterinin satýn aldýðý ürünleri ve kaç adet satýn aldýðýný listeleyen SP yazýnýz.

create Procedure spMusteriUrunAdet
@MusteriID nchar(5)
as
select u.UrunAdi,SUM(sd.Miktar) as ToplamAdet from Urunler u inner join [Satis Detaylari] sd on u.UrunID=sd.UrunID inner join Satislar s on sd.SatisID=s.SatisID where s.MusteriID=@MusteriID group by u.UrunAdi

exec spMusteriUrunAdet 'LILAS'


--Dýþarýdan gönderilen iki tarih arasýnda sevk edilen satýþlarý listeleyen SP yazýnýz.
--procedure ismi spSatisIkiTarih, @basTarih, @bitTarih

create proc spSatisIkýTarih
@basTarih date, 
@bitTarih date 
as 
select * from Satislar where SevkTarihi >= @basTarih and SevkTarihi <= @bitTarih 


exec spSatisIkýTarih @basTarih = '1996-07-01', @bitTarih = '1996-07-20'

--Dýþarýdan gönderilen sayý kadar en yüksek fiyata sahip ürünleri listeleyen SP yazýnýz. Sayý gönderilmezse 10 adet ürün listeleyiniz.

--spEnPahaliUrunler
create procedure spEnPahaliUrunler
@adet int = 10 
as
select top (@adet) * from Urunler order by BirimFiyati desc

exec spEnPahaliUrunler 

















