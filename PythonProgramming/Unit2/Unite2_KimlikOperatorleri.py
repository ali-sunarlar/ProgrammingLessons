tam_sayi=10
ondalikli_sayi=10.5
kelime_dizisi="Python"

#kimlik operatoru ile nesnenin hangi tur oldugunu kontrolu

#tam_sayi degiskeni tam sayi mi?
print(type(tam_sayi)is int)
#kelime_dizisi degiskeni float sayi olmadigini kontrol et
print(type(kelime_dizisi)is not float)
#ondalikli_sayi degiskeni ve bilimsel gosterim 10e2 ayni turde mi
print(type(ondalikli_sayi)is type(10e2))

print("tam_sayi degiskeninin kimlik numarasi : ",id(tam_sayi)) #tam_sayi nesnesinin kimlik numarasi 

#tam sayi degiskenini b'ye atiyoruz.
b=tam_sayi
#b'nin kimlik numarasi
print("b'nin degiskeninin kimlik numarasi:",id(b))
#tam_sayi'nin degerini degistirip kimlik numarasini bakalim
tam_sayi=100
print("tam_sayi'nin degeri= ",tam_sayi," ve kimlik numarasi: ",id(tam_sayi))     