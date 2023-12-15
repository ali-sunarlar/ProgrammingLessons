# Bos sözlükten oluşturma

ogrenci ={}

ogrenci["ad"] = "Ahmet"

ogrenci["soyad"] = "Çalişkan"

ogrenci["no"] = 3400001

# Doğrudan oluşturma

personel = {"ad" : "Ali", "Görev" : "Calisan"}

print(personel["ad"])

# dict fonksiyonunu isimli parametrelerle kullanmak:

D = dict([("isim","Hasan"), ("yas",45)])

print(D["isim"])

kod = ["AGHOLAG","AKBNK","AKFGY" ,"AKSA" ,"AKSEN","ALGY0"]

sirket_adi =["ANADOLU GRUBU HOLDING A.S.","AKBANK T.A.S.",\
             "AKFEN GAYRİMENKUL YATIRIM ORTAKLIĞI A.S.","AKSA AKRİLİK KİMYA SANAYİİ A.S.",\
             "AKSA ENERJİ ÜRETİM A.Ş.","ALARKO GAYRİMENKUL YATIRIM ORTAKLIĞI A.Ş."]

# Listelerden zip fonksiyonu ile olusturma

bis100 = dict( zip(kod, sirket_adi) )

print(bis100["AKSEN"]) 