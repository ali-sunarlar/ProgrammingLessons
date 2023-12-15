buyuk_ikramiye=123456
amorti1=5
amorti2=6
bilet_no=int(input("Biletiniz numarasini giriniz: "))
if bilet_no==buyuk_ikramiye:
    print("Tebrikler Kazandiniz !!!")
elif (bilet_no%10==amorti1 or bilet_no%10==amorti2) and (bilet_no!=buyuk_ikramiye):
    print("Amorti Kazandiniz")
else:
    print("Malesef Kazanmadiniz")
#if (bilet_no%10==amorti1 or bilet_no%10==amorti2) and (bilet_no!=buyuk_ikramiye):
#    print("Amorti Kazandiniz")
