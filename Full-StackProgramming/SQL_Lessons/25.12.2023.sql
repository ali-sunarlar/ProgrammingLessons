--Sakl� Yordam (Store Procedured), kaydedebilece�iniz haz�rlanm�� sql kodu.
--�  Sakl� yordamlar, SQL Server 'a esneklik ve h�z kazand�r�rlar.
--�  �nceden derlenmi� oldu�u i�in, normal kullan�lan bir SQL sorgusunun tekrar tekrar �al��t�r�lmas�na oranla daha fazla performans elde edilmesine sa�larlar. 
--�  Bir kez yaz�l�p, tekrar tekrar kullan�ld��� i�in mod�ler bir yap�da program geli�tirilmi� olur. 
--�  Ayn� Transact-SQL c�mleci�ini birden fazla yerde kullan�laca�� zaman, bunu bir sakl� yordam haline getirerek, kullan�m�n� sadece ismini �a��rma ile ger�ekle�tirilebilir. 
--�  Belirli girdi ve ��kt� parametreleri oldu�u i�in, sakl� yordamlar�n kullan�m� ile g�venlik a��s�dan y�neticiyi de sa�lama alm�� olur. 
--�  A� trafi�ini azalt�r. �stemci taraf�ndan bir�ok sat�ra sahip SQL komutunun sunucuya gitmesindense, sadece sakl� yordam�n ad�n�n sunucuya gitmesi a�� daha az me�gul etmi� olur. 

--Kullan�m�:

--create Procedure ProcedureAdi
--varsa paraetreler yaz�l�r
--as
--sql Kodlar� yaz�l�r

--exec ProcedureAdi yazarak �al��t�r�l�r.
--varsa parametrelerimizi de ekleriz.

use Northwind
--T�m M��terileri listeleyen SP yaz�n�z.

create Procedure spTumMusteriler
as
select * from Musteriler

exec spTumMusteriler

--D��ar�dan g�nderilen bilgilere g�re Nakliyeci kaydeden SP yaz�n�z

create proc spNakliyeciEkle
@sirketAdi nvarchar(40),
@telefon nvarchar (11)
as
insert into Nakliyeciler (SirketAdi,Telefon) values (@sirketAdi,@telefon)

exec spNakliyeciEkle @sirketAdi='BBBBB', @telefon='2144444444'

--D��ar�dan g�nderilen bilgilere g�re Nakliyecinin t�m bilgilerini g�ncelleyen SP yaz�n�z.
----procedure ismi spNakliyeciDuzenle--parametreler olacak..

CREATE PROC spNakliyeciDuzenle 
@NakliyeciID int,
@SirketAdi nvarchar(40), 
@telefon nvarchar(24) 
as 
UPDATE Nakliyeciler SET SirketAdi = @sirketAdi, telefon = @telefon where NakliyeciID=@NakliyeciID

exec spNakliyeciDuzenle 1, 'Express','(741) 852 96 32'

--exec spNakliyeciDuzenle @nakliyeciID=1, @sirketAdi='Express', @telefon='(741) 852 96 32'   �eklinde de yaz�labilir.

--D��ar�dan g�nderilen bilgiye g�re Nakliyeciyi silen SP yaz�n�z.
--procedure ismi spNakliyeciSil , NakliyeciID parametresini kullan
create procedure spNakliyeciSil
@NakliyeciID int 
as
DELETE FROM Nakliyeciler WHERE NakliyeciID=@NakliyeciID

exec spNakliyeciSil 6

--d��ar�dan g�nderilen bilgilere g�re Nakliyeci kaydeden SP yaz�n�z. Ayn� telefon numaras� varsa kaydetmeyiniz.
--spNakliyecilerEkle procedure ismi

create proc spNakliyecilerEkle
@SirketAdi nvarchar (40),
@Telefon nvarchar (20)
as
declare @sayi int
set @sayi=(select count(*) from Nakliyeciler where Telefon=@Telefon)
if @sayi>0
begin 
print 'B�yle bir telefon numaras� kay�tl�'
end
else
begin
insert into Nakliyeciler (SirketAdi,Telefon)
values (@SirketAdi,@Telefon)
print 'Nakliyeci Eklendi'
end

exec spNakliyecilerEkle 'ZZZZZ','(741) 852 96 00'

--G�nderilen KategoriID ye g�re �r�nler i listeleyen SP yaz�n�z.(UrunID,UrunAdi,KategoriAdi)

create proc spUrunlerKategoriID
@KategoriID int
as
select u.UrunID,u.UrunAdi,k.KategoriID from Urunler u inner join Kategoriler k on u.KategoriID=k.KategoriID where k.KategoriID=@KategoriID

exec spUrunlerKategoriID 4


--D��ar�dan g�nderilen musteriID ye g�re o m��terinin sat�n ald��� �r�nleri ve ka� adet sat�n ald���n� listeleyen SP yaz�n�z.

create Procedure spMusteriUrunAdet
@MusteriID nchar(5)
as
select u.UrunAdi,SUM(sd.Miktar) as ToplamAdet from Urunler u inner join [Satis Detaylari] sd on u.UrunID=sd.UrunID inner join Satislar s on sd.SatisID=s.SatisID where s.MusteriID=@MusteriID group by u.UrunAdi

exec spMusteriUrunAdet 'LILAS'


--D��ar�dan g�nderilen iki tarih aras�nda sevk edilen sat��lar� listeleyen SP yaz�n�z.
--procedure ismi spSatisIkiTarih, @basTarih, @bitTarih

create proc spSatisIk�Tarih
@basTarih date, 
@bitTarih date 
as 
select * from Satislar where SevkTarihi >= @basTarih and SevkTarihi <= @bitTarih 


exec spSatisIk�Tarih @basTarih = '1996-07-01', @bitTarih = '1996-07-20'

--D��ar�dan g�nderilen say� kadar en y�ksek fiyata sahip �r�nleri listeleyen SP yaz�n�z. Say� g�nderilmezse 10 adet �r�n listeleyiniz.

--spEnPahaliUrunler
create procedure spEnPahaliUrunler
@adet int = 10 
as
select top (@adet) * from Urunler order by BirimFiyati desc

exec spEnPahaliUrunler 

















