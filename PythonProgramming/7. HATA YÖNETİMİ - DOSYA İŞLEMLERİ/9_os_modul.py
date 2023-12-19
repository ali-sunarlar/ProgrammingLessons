"""metot / fonksiyon               açiklama
getcwd()                        Mevcut çalişma dizinini almak için,
chdir(yol)                      Geçerli çalişma dizinini değiştir.
listdir(yol)                    Dizindeki dosyalarin ve alt dizinlerin adlarini listesini döndürür
makedirs(klasör)                Yeni bir klasör oluşturur.
remove(yol)                     Yoldaki dosya dizini sil
rmdir(yol)                      Yoldaki dizini sil
path.exists(path)               Yolun doğruluğunu kontrol etme, aksi takdirde False.
path.isfile(path)               Yolun dosya olup olmadiği kontrolü
path.isdir (yol)                Yolun dizin olup olmadiği kontrolü
path.abspath(yol)               Argümandaki mutlak yolu kelime dizisi olarak döndürür
path.join((yol, * yollar)       Birden fazla yolu işletim sistemi bağimsiz şekilde birleştirir."""

import os

calisma_dizini = os.getcwd() # Geçerli dizinin mutlak yolu

print ("Şu an bulunduğunuz dizin:{}".format(calisma_dizini))
# yolu belirtilen dizinin icindekile
print(calisma_dizini,"dizinin icindekiler:\n",os.listdir(calisma_dizini))
# yeni dizin adli dizini var olan çalişma dizini ile birleştirme
yeni_dizin_yolu = os.path.join(calisma_dizini,"yeni dizin")
print(yeni_dizin_yolu)
# Yeni dizini oluşturma
if os.path.exists(yeni_dizin_yolu):  #oluşturulmak istenen dizinin olup olmadiğini kontrol etme 
    print ("Zaten dizin var")
else: 
    os.makedirs(yeni_dizin_yolu)
# geçerli dizinin içindekiler
print("Dizinin içindekiler: Vn",os.listdir())
os.rmdir(yeni_dizin_yolu)
print("Dizinin içindekiler: Vn",os.listdir()) 