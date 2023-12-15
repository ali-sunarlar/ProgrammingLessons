def toplama(ilk,*sayilar):
    #bir veya daha fazla sayinin toplamini dondurur
    toplam=ilk
    if len(sayilar)>0:
        for sayi in sayilar:
            toplam+=sayi
    print(toplam)
        
toplama(5,6)
toplama(3)
toplama(7,8,9,10)
