--Id numarasý 1 olan mühendisin yaptýðý projeleri getiren sorgu

select * from Muhendisler,MuhendisProje where MuhendisProje.PersonelID=Muhendisler.PersonleID and Muhendisler.PersonleID=1

--muhendisler tablosunda personelýd=1 olan kaydýn adý,soyadý,bölümü,projeadý,bitiþ tarihi bilgilerini listeleyen sorgu

Select m.Ad,m.soyad,m.Bolum,p.ProjeAdý,p.Bitis from Muhendisler m,MuhendisProje mp,Projeler p Where m.PersonleID = mp.PersonelID and p.ProjeId = mp.ProjeID and m.PersonleID = 1

