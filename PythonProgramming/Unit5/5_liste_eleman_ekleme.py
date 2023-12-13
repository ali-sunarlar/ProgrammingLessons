liste = [1, 2, 3, 4] 

print("Listem:", liste)

# listeye eleman ekle 

liste.append(5)

print (liste)

# listeye elemanlar ekle 
liste.extend([6, 7, 8]) 
print(liste)

# Listeye eklenecek deger 
deger = 0

# 7 saysınının önüne ekleme 
hangi_sayinin_onune = 7

# bir degerin indisini bul 
indis = liste.index(hangi_sayinin_onune) 

# değeri bulduğumuz indisi ekle 
liste.insert(indis, deger) 
print(liste) 