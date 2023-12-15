def coklu_parametre(a,b,c,d):
    print(a,"x",b,"=",a*b)
    print("Girilen 1. karakter",c)
    print("Girilen 2. karakter",d)
    
    
sayi1=5;sayi2=7
karakter1="c";karakter2="e" # ; ile iki ifadeyi ayni satirda tanimlanabilir
coklu_parametre(sayi1,sayi2,karakter1,karakter2)
print("--------------------------")
coklu_parametre(sayi1,karakter1,sayi2,karakter2)
print("--------------------------")
coklu_parametre(sayi2,karakter1,sayi1,karakter2)
print("--------------------------")
coklu_parametre(karakter1,karakter2,sayi1,sayi2)

    