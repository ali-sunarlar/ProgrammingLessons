tam_sayi=1907
ondalikli_sayi=7.88
toplam=tam_sayi+ondalikli_sayi
print("toplam: ",toplam)
print("tam_sayi degiskenlerinin turu: ",type(tam_sayi))
print("ondalikli_sayi degiskeninin turu: ",type(ondalikli_sayi))
print("toplam degiskenin turu: ",type(toplam))

""" Örtülü tür dönüşümleri sayısal veri türlerinde gerçekleşmesine rağmen eğer bu işlemi 
Kod 17'deki gibi bir sayısal tür ve karakter dizisi(string) ile yapacak olsaydık tür dönüşümü 
gerçekleşmemiş olup ve hata " TypeError: unsupported operand type(s) for +: 'int' and 'str'" 
şeklinde desteklenmediğine dair hata mesajı karşımıza çıkıp program durmuş olacaktır. """

""" karakter_dizisi="7.88"
toplam2 =tam_sayi+karakter_dizisi
print("toplam2: ",toplam2)
print("toplam degiskeninin turu: ",type(toplam2)) """

#- int(a) a değişkenini tam sayıya dönüştürme,

#- float(a) a değişkenini ondalıklı sayıya dönüştürme,

#- complex(gerçek, imajiner) karmaşık sayıya dönüştürme,

#- str(a) a değişkenini karakter dizisine dönüştürme,

#- chr(a) a tamsayısını değişkenini karaktere dönüştürme,

#- ord(a) a karakterini tam sayıya dönüştürme,

#- bool(a) herhangi bir türü Bool türe dönüştürme,



sayi1=12
sayi2=int("15")
toplam1=sayi1+sayi2
print(toplam1)


sayi3=12
sayi4=15.6
toplam2=sayi3+int(sayi4)
print(toplam2)


 
 
 