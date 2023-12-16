# Randon modülünden ihtiyaç duyulan modüllerin içeriye aktarilmasi

from random import random,uniform, randint,shuffle,choice

# random:0 ile 1 arasinda rastgele float değerinde sayi üretir

print("0-1 arasi rastgele sayi {}".format(random()))

# uniform: min ve max değerleri arasi float tipinde rastgele ondalikli sayi üretir 
print("20-60 arasi rastgele sayi {}".format(uniform(20,60)))

# randint:min ve max değerleri arasi tamsayi tipinde rastgele tamsayi sayi üretir 
print("20-60 arasi rastgele sayi {}".format (randint(20,60)))

# shuffle:Parametre olarak girilen listeyi kariştirir

liste = [1,2,3,4,5,6,7,8,9,0]

print("Listem: {}".format(liste))

shuffle(liste)

print("Karistarilms liste: {}".format(liste)) #dikkat orjinal liste değişti

# choice: Bir listenin içerisinden rastgele bir eleman çekmeye yarar

liste = [1,2,3,4,5,6,7,8,9,0]

print("Rastege bir eleman: {}".format(choice(liste))) 