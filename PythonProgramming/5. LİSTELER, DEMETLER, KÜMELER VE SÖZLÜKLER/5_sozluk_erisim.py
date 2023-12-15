# Dogrudan olusturma

personel = {"ad" : "Ali", "Görev" : "Calisan"}

# [1 doğrudan sözlükten veri getirmek

print ("Personelin Adi: {}".format (personel ["ad"]))

# get metotu ile sözlükten veri almak

print ("Personelin görevi: {}".format (personel.get("Görev"))) # olmayan bir anahtari get ile çağirmak

print ("Personelin maaşi: {}".format (personel.get("Maas"))) 
print("Personelin maaşi: {}".format (personel.get ("Maas", "Belirtilmemiş")))

# olmayan bir anahtari () ile çağirmak

print ("Personelin maaşi: {}".format (personel ["Maas"])) 