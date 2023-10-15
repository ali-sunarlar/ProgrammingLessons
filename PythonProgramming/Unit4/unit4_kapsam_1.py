toplam = 100 
carpim = 10 
topla = None
def hesap(sayi1, sayi2): 
    toplam = sayi1 + sayi2 
    global carpim 
    carpim = sayi1 * sayi2 
    return toplam 

#fonk cagrilmadan onceki degerler
print("carpim:",carpim) 
print("toplam:", toplam) 
print("Topla", topla) 
#fonksiyon cagrildi
topla=hesap(10, 100)
#fonksiyon cagrildiktan sonraki degerler
print("carpim:",carpim) 
print("toplam:", toplam) 
print("Topla", topla)