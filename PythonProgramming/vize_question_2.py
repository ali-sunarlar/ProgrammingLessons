def hesapla(sayi1=12,sayi2=7,operator="+"):
    if operator == "+": 
        sonuc = sayi1 + sayi2 
    if operator == "-": 
        sonuc = sayi1 - sayi2 
    else: 
        sonuc ="Hesaplayamadim" 
    return sonuc 

# sonuc = hesapla(sayi1=1,sayi2=1,operator="+") 
# print (sonuc) 

print(hesapla(1,1,"+"))