sayilar = {1:"Bir", 
           2:"İki", 
           3:"Üç", 
           4:"Dört", 
           5:"Beş"}

# Döngü ile değerlere erişmek 
for deger in sayilar.values(): 
    print(deger) 
# Döngü ile anantarlara erişmek 
for anahtar in sayilar.keys(): 
    print (anahtar) 
# Döngü ile anahtar-deger iftlerind erişmek 
for oge in sayilar.items(): 
    print(oge) 