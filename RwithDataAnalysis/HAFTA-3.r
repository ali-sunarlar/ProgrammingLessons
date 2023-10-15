#Sayisal Veri Tirinde De§isken Tanimlama
x<-54 #bu kod satirinda x defisken adi ve 54'de bu defiskene atanan deferdir 
y=34.5 #y değişkenine 34.5 değeri atandı
100->z #z değişkenine soldan sağa değer atandı

#Degisken deferlerini direkt degisken adini yazarak ekrana yazdirma 
x
y
z

#Degisken degerlerini print() fonksiyonu ile ekrana yazdirma 
print(x)
print(y)
print(z)

#Tamsay: Veri Tarunde Degisken Tanimlama 
k=11
m=205

print(k)
print(m)

#Karakter Ver: Tirinde Degisken Tanimlama 
#Karakter veri degerleri " * igerisinde yazilarak degiskenlere atanir 
harf="a"
isim="Ayşe"
sehir="Sakarya"

print(harf)
print(isim)
print(sehir)

#Mantiksal Veri Tirinde Degisken Tanimlama 
sonuc1=TRUE
sonuc2=FALSE

print(sonuc1)
print(sonuc2)

#0lusturulan De§iskenleri Goérintiileme 
objects()

#0lusturulan De§iskenleri Goérintiileme
ls()

#olusturulan Degiskenleri silme
remove(sonuc1)
rm(harf)

ls()

typeof(sonuc2) 
class(isim)

#cift tirnak igerisine yazilan sayilar R dili tarafindan karakter/string tipi olarak yorumlanir. 
h="3.14"

typeof(h)

#Karaktersel veriyi Sayisal Tire Déniistirme
as.numeric(h)

class(h)

h1=as.numeric(h) #karaktersel veri sayısala dönüştürüldükten sonra yeni bir değişkene atanması gerekmektedir.

typeof(h1)

#Degiskenin Sayisal Olup Olmadigini Sorgulama 
is.numeric(h)
is.numeric(h1)



sayi=67.875
#Değişkenin Sayısal kısmını alma
as.integer(sayi)

sayi2="45"
class(sayi2)
as.integer(sayi2)

sayi3=61
class(sayi3)
as.character(sayi3)
class(sayi3)

mantik=TRUE
class(mantik)

durum1=1
durum2=0
class(durum1)
class(durum2)

as.logical(durum1)
as.logical(durum2)


