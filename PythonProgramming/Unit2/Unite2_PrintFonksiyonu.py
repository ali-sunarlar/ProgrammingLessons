# Python dilinin dokümantasyonunda print fonksiyonun kullanımı:

# print(*nesneler, sep=' ',end='\n', file=sys.stdout, flush=False)

# şeklinde verilmektedir. Bu parametreler

# - *nesneler - yazdırılacak bir nesne/nesneler.

# - sep – birden çok yazdırılan nesne arasındaki ayırıcı.

# - end - nesneden sonra sonunda yazdırılan karakter/dize.

# - file – çıktının gideceği dosyayı belirtir. Varsayılan olarak bu konsoldur.

# - flush - True olarak ayarlanırsa veri akışı/dosyayı zorla temizler 

sayi1=15
sayi2=7.5
ad="Ahmet"
print(ad,sayi1,sayi2)


#sep parametresi
# sep parametresi: Bu parametre print() fonksiyonu ile nesneler arasına yerleştirmek istediğimiz bir nesneleri ekler. Ön tanımlı olarak boşluk karakteri olarak tanımlıdır.

#sep parametresinin kullanimina ornekler
print("Elma","Armut","Cilek")
print("Elma","Armut","Cilek",sep="/")
print("Elma","Armut","Cilek",sep="-")
print("Elma","Armut","Cilek",sep="/")
print("Elma","Armut","Cilek",sep="-->")


#end parametresi: print() fonksiyonunu , end parametresiyle nesnelerin sonuna eklenecek bir karakter belirtmenize de olanak tanımaktadır. 
# Print fonksiyonu bir alt satıra geçmemize yarayan \n kaçış karakteri ile ön tanımlıdır.

#Yukarıdaki anlatılan iki parametre çıktı karakter dizimizi biçimlendirmek için faydalı 
# olsa da, yalnızca aralığı değiştirmemize veya çıktının sonunda ne olacağına karar 
# vermemize yardımcı olurlar. Ancak, verilerin görünümü üzerinde daha kesin kontrol 
# elde etmek ve düzenli hale getirmek için karakter dizileri için str.format() yöntemleri 
# bulunmaktadır ve onlar kullanılabilir. Böyle durumda süslü parantezler {}, argümanların 
# yazdırılacağı sıraya karar verebileceğimiz yer tutucular işlevini görmektedir.

ogrenci_ad="Esra"
ogrenci_soyad="Caliskan"
vize_notu=55
final_notu=100
ortalama=vize*0.4+final*0.6

#formatli sekilde ekrana bastirma
# print( '{}{}\'nin vize notu:{} \nfinal notu:{} \nortalama{}'\ .format(ogrenci_ad,ogrenci_soyad,vize_notu,final_notu,ortalama) )
#formatli sekilde ekrana bastirma icin baska bir yontem
# print( '{1}{2}\'nin vize notu:{3} \nfinal notu:{4} \nortalama{0}'\ .format(ogrenci_ad,ogrenci_soyad,vize_notu,final_notu,ortalama) )

#sayesinde değişkenlerimizin print içeresindeki kelime dizi içinde 
#uygun yerlerde basılması sağlanmıştır.

##Çok satırlı bir yazıyı print fonksiyonu ile ekran bastırılması 
# istenildiğinde pythonda üçlü tırnak işaretini ( """ """) kullanılabilmektedir.


