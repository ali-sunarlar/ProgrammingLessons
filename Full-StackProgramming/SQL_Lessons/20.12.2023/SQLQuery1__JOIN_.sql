select kitaplar.kitap_isim,yazarlar.yas from kitaplar inner join yazarlar on kitaplar.id=yazarlar.id

select kitaplar.kitap_isim,yazarlar.yazar_isim from kitaplar left join yazarlar on yazarlar.id=kitaplar.id

select kitaplar.kitap_isim,yazarlar.yazar_isim from kitaplar right join yazarlar on yazarlar.id=kitaplar.id


