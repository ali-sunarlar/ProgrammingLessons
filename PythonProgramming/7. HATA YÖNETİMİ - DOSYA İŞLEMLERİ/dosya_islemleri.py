"""Mod                      Açiklama
'r' modu                    Dosya sadece okunmak için açilir. Bu mod varsayilan moddur.
r+' modu                    Dosya hem okunmak hem de yazmak için açilir. Eğer çağrilan dosya bulunamadiysa yeni bir dosya oluşturulmaz.
'w' modu                    Dosya sadece yazmak için açilir. Daha önceden varolan dosyanin üzerine yazma işlemini yapar böylelikle önceki dosya kaybolur. Eğer çağrilan dosya bulunamadiysa yeni bir dosya oluşturur.
'w+' modu                   'w' modu gibi çalişmasina ek okuma işlemi de yapilir.
'a' modu                    Dosya ekleme işlemi için açilir. Daha önceden varolan dosyanin en sonundan eklemeye devam eder. Eğer çağrilan dosya bulunamadiysa yeni bir dosya oluşturur.
'a+' modu                   'a' modu gibi çalişmasina ek okuma işlemi de yapilir.
't'                         Metin modunda açilir. (varsayilan)
'b'                         İkili modda açilir.(resim veya yürütülebilir dosyalar)"""

"""dosya = open("test.txt", encoding = 'utf-8')

# dosya operasyonlari

dosya.close()

Ancak bu yöntem tek başina güvenli değildi. O bakimdan oluşabilecek istisnalardan kurtulmak için kodun

try:

dosya = open("test.txt", encoding = 'utf-8')

# dosya operasyonlari

finally:

dosya.close()"""





