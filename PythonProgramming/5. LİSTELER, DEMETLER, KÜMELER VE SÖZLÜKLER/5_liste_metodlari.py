"""append() Listenin sonuna tek bir eleman ekler
clear() Listeyi siler, bütün elemanlari kaldirir.
copy() Listenin bir kopyasini çikarir.
count() Listede parametrede belirtilen değere sahip kaç eleman olduğunu verir.
extend() Listenin sonuna bir liste ekleyerek genişletir.
index() Parametre olarak verilen değerin ilk bulunuduğu konumunu (indeksini) döndürür
insert() Belirtilen dizin konumuna bir eleman ekler
pop() Parametre olarak verilen indisteki bir elemani döndürür ve kaldirir
remove() Belirtilen bir öğeyi listeden kaldirir
reverse() Tüm listenin sirasini tersine çevirir 
sort() Tüm öğeleri artan düzende siralar"""

meyveler = ["Elma", "Armut", "Muz", "Kiraz", "Elma", "Karpuz"] 

print("Orjinal Liste:",meyveler)

# .copy metodu ile kopyalama

meyveler_yedek = meyveler.copy()

print("Kopya Liste:",meyveler_yedek)

# dilimleme ile kopya liste çikartma

meyveler_yedek2 = meyveler[:]

print("2. Kopya Liste:",meyveler_yedek2)

#listedeki Elma sayisi

print("Listede 'Elma'",meyveler.count("Elma"), "kez geçiyor") 


#Listeyi tersine çevir

meyveler.reverse()

print("Tersine çevrilmiş Liste:",meyveler)

#Listeyi sirala

meyveler.sort()

print("Siralanmis Liste:",meyveler)

#Listeyi tersten sirala

meyveler.sort(reverse=True)

print("Tersten Siralanmiş Liste:",meyveler) 