yil=int(input("Yili Giriniz: "))
ay=int(input("Ayi Giriniz: "))

if(ay==1 or ay==3 or ay==5 or ay==7 or ay==8 or ay==10 or ay==12):
    print("Ay 31 gunden olusuyor")
elif (ay==4 or ay==6 or ay==9 or ay==11):
    print("Ay 30 gunden olusuyor")
elif ay==2:
    if((yil%4)==0 and(yil%100)!=(yil%400)==0):
        print("Artik Yildayiz ve 29 Gun")
    else:
        print("Artik Yil Degil ve Ay 28 Gun")
else:
    print("Yanlis Ay Bilgisi Girdiniz")