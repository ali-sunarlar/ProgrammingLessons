--Id numaras� 1 olan m�hendisin yapt��� projeleri getiren sorgu

select * from Muhendisler,MuhendisProje where MuhendisProje.PersonelID=Muhendisler.PersonleID and Muhendisler.PersonleID=1

--muhendisler tablosunda personel�d=1 olan kayd�n ad�,soyad�,b�l�m�,projead�,biti� tarihi bilgilerini listeleyen sorgu

Select m.Ad,m.soyad,m.Bolum,p.ProjeAd�,p.Bitis from Muhendisler m,MuhendisProje mp,Projeler p Where m.PersonleID = mp.PersonelID and p.ProjeId = mp.ProjeID and m.PersonleID = 1

