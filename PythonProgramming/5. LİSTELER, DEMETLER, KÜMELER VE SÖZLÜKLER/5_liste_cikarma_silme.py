markalar =["Adidas","Nike","Puma"," columbia", "North Face"] 

print(markalar)

# Puma markasını sil 
markalar.remove ("Puma") 
print(markalar)

# tekrar silmek istersek hata oluşur # 
# markalar.remove("Puma")

#sondaki eleman silinir 
markalar.pop()

print(markalar)

#indisi verilen eleman silinix 
markalar.pop(1)

print(markalar)

meyveler = ["Elma", "Armut", "Kivi", "Muz","Cilek","Visne"] 
print("Meyveler: ", meyveler)

# Tek bir eleman çıkarma

del meyveler[1]

print (meyveler)

# belli aralıktaki elemanları çıkarma 
del meyveler[3:5]

print(meyveler)

# meyveler listesini sil

del meyveler

print(meyveler) 