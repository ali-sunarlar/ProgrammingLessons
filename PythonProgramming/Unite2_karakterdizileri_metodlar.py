metin = "Merhaba Dunya"

print("Lowercase:",metin.lower())
print("Uppercase:",metin.upper())
print("Capitalize:",metin.capitalize())
print("Title Case:",metin.title)

kelimeler=metin.split()
print("İcerilen kelimeler",kelimeler)

#Merhaba kac kere geciyor
print(metin.count("Merhaba"))
#kac harf var
print(len(metin))

#Dunya kelimesini Ahmet ile degistir
metin2=metin.replace("Dunya","Ahmet")

metin3="Merhaba Dunya"
print(metin3.find("e"))
print(metin.isalnum())
print(metin.isdigit())
print(metin.isalpha())

metin3="Dunya"
print(metin3.isalpha())


#len() fonksiyonu #Karakter dizisi içerisindeki karakter sayısını verir
#upper() metodu #Karakter dizisi içindeki tüm harfleri büyük harfe çevirir.
#lower() metodu #Karakter dizisinde bulunan tüm harfleri küçük harfe çevirir.
#capitalize() metodu # Karakter dizisinin ilk harfini büyütür
#title() metodu# Karakter dizisini başlık biçimine çevirir
#swapcase() metodu #Karakterleri büyükten küçüğe küçükten büyüğe çevirir.
#split() metodu #Karakter dizisini istenilen bir karakterden bölümlere ayırmak
#join() metodu #Karakter dizilerini özel bir şekilde birleştirir.
#replace() metodu #Bir karakter dizisi içerisinde belli karakter dizisi parçasını başka bir karakter dizisi ile değiştirir.
#find(),metodarı #karakter dizisi içinde belli beli karakterin kaçıncı sırada (indekste) olduğunu bulur
#rfind() metodu #Karakter dizisi içinde belli bir karakterin tersten sırasını bulur
#isalpha() metodu #Karakter dizisinin sadece harften oluşup olmadığını kontrolü. Bulunması halinde geriye True döndürür .
#isdigit() metodu. #Karakter dizisinin sadece rakamdan oluşup olmadığını kontrolü. Bulunması halinde geriye True döndürür.
#isalnum() metotları #Karakter dizisinin rakamdan ve harften oluşup olmadığını kontrolü. Bulunması halinde geriye True döndürür.



