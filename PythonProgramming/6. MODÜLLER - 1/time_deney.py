import time as time

#1 Ocak 1970 yilindan buz zamana geçen süreyi hesapla

print (time.time())

# Şu anki zamani veriri

simdi=time.asctime()

print ("Programin çaliştiği zaman: {}".format(simdi))

#Su anki zamani formatli şekilde aktar

# ayin kisaltilmiş adi ve tam tarih saat ve zaman bilgisini vermek için 
simdi=time.strftime( '%b %x %X')

print ("Programin çaliştiği zaman formatli hali: {}".format(simdi)) 


print("*********************************************************")


#Yönerge                    Anlami                                  Çikti
#%a                         Haftanin günü kisaltmasi                Sun,Mon,…
#%A                         Haftanin günüi tam adi                  Sunday,Monday…
#%w                         Haftanin günü tam sayi olarak           0,1,1,2
#%b                         Ayin kisaltilmiş adi                    Jan,Feb,Dec
#%B                         Ayin tam adi                            Januar, Februar…
#%d                         Aydaki gün                              01,02,03,…,30
#%j                         Yilin günü                              001,002,…365,366
#%m                         Sayisal olarak ay                       01,02,…,11,12
#%U                         Yilin kaçinci haftasi                   00,01,…,53
#%y                         Yilin son iki rakami                    00,01,…,98,99
#%Y                         Yilin dört haneli tam hali              2020,2021,2022
#%x                         Tam tarih bilgisi                       09/14/22
#%X                         Tam saat bilgisi                        14:29:15



