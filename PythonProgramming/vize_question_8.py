sayil = int(input("1. sayiyi giriniz:")) 
sayi2 = int(input("2. sayiyi giriniz:")) 
islem = input("Yapmak istediginiz islemi giriniz (+ - *):") 

if islem == "+":
    print("{} + {} = {}".format(sayil,sayi2,sayil+sayi2)) 
elif islem == "-":
    print("{} - {} = {}".format(sayil,sayi2,sayil-sayi2)) 
elif islem == "x":
    print("{} * {} = {}".format(sayil,sayi2,sayil*sayi2)) 
else:
    print("Yanlis islem girdiniz") 