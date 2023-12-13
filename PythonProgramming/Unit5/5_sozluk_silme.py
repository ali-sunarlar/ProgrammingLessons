# Bir sozluk oluşturalim

sozluk = {1: 'Asli', 2: "Ahmet", 3: "Veli", 4: "Zehra", 5: "Zeynep"} 

print (sozluk)

#sozlukten eleman silmek 
sozluk.pop(1)

print( sozluk)

#sozlukteki son öğe silinsin 
sozluk.popitem()

print (sozluk)

#s0zlukten olmayan elenan silelim 
del sozluk[3]

print (sozluk)

# Boş sözlükten popiten ile silme 

sozluk = {}

sozluk.popitem()