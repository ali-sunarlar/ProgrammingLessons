# Bos küme oluşturmayi deneyelim

bos_kume = set()

bos_kume2 ={}

print("bos_kume'nin türü:()".format(type(bos_kume))) 
print("bos kume2'nin türü:()".format(type(bos_kume2))) #Kume oluşturmaya örnekler

tam_sayi_kume = {1,2,3,4,5,6,7}

#listeden kümeye dönüştürmek

meyve_listesi = ["elma","armut","muz"]

meyve_kumesi = set(meyve_listesi)

print("Meyve kümesinin içeriği :{}".format(meyve_kumesi)) 
# meyve kümesine yeni meyvelerin eklenmesi meyve_kumesi.add("mandalina")

meyve_kumesi.add("cilek")

print("Meyve kümesinin içeriği :{}".format(meyve_kumesi)) #meyve kümesinden eleman silme meyve_kumesi.remove("armut")

print("Meyve kümesinin içeriği :{}".format(meyve_kumesi)) 
meyve_kumesi.discard("¢ilek")

print("Meyve kümesinin içeriği :{}".format(meyve_kumesi)) 
meyve_kumesi.discard("cilek")

print("Meyve kümesinin içeriği :{}".format(meyve_kumesi)) 
meyve_kumesi.remove("armut") #kimede bulunmayan içerik hata olusturur] 
print("Meyve kümesinin içeriği :{}".format(meyve_kumesi)) 