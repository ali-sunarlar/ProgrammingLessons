sayilar=[] #Ekrana sirali yazdiracagimiz ve sayilari tutacagimiz bos liste tanimlayalim
i=0  #sayac icin i degiskine 0 degerini verelim ve baslangicta hic deger almadik
while i<10: #10 tane deger alacak sekilde dongu kosulunu belirleyelim
    sayi=int(input('sayi{}: '.format(i+1))) #kullanicidan tam sayi alalim
    sayilar.append(sayi) #kullanicidan alinan deger sayilar listesine eklensin
    #donguden cikilmasi icin kosullu alinan deger sayilar listesine eklensin
    i+=1 # i=i+1'e denk gelen artir ve esitle operatoru kullandik
#donguden ciktik
sayilar.sort() #sayilar listemizi siralayalim
print(sayilar) #ekrana bastiralim
