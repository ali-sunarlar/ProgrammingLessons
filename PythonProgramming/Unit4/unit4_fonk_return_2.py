def hesapla(sayi1,sayi2): 
    toplam = sayi1 + sayi2 
    fark = sayi1 - sayi2 
    carpim = sayi1 - sayi2 
    bolum = sayi1/sayi2 
    return [toplam, fark, carpim, bolum] #birden fazla deger dondurulmesi

donus = hesapla(10,11)

print(donus)

print (type (donus)) #print ile ekrana bastir

a,b,c,d = hesapla(10,11) #donus degerlerini tek tek degiskenlerine aktar

print(a,b,c,d, sep="\n") 