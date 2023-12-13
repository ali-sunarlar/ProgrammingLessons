icice_liste = ["Merhaba", 2.0, 5, [10, 20]]
# içerdeki liste 
ic_liste = icice_liste[3] 
print(ic_liste) 
#icerdeki listenin 2. elemani 
oge = ic_liste[1] 
print(oge) 
print(icice_liste[3][1]) 
"""içiçe listenin ilk öğesinin string olmasi ve 1 kakterdden fazla olmasi durumunda 2. harfini yazdir aksi halde karakter dizisi değildir diye yazdir""" 
if isinstance(icice_liste[0], str): 
    if len(icice_liste[0])>=1: 
        print ("Karakter dizisinin 2. harfi:",icice_liste[0][1]) 
    else: print("Karakter dizisi 1 elemanli") 
else: print("Karakter Dizisi Değil") 