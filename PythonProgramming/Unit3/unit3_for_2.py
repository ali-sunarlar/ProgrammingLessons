for i in range(5):
   print(i,"5'e kadar \n") 
for x in range(2,10,3):
   print(x," 2'den 10 kadar 3'er \n") 
 
 #range(10) 0'dan baslayarak  9 dahil deger alir
for y in range(10):
    print(y,"\n")
print ('1. For dongusunden cikildi \n')

#2 den baslarak 10'a kadar 2 aralikli yazdirma
aralik=range(2,10,2) #aralik degiskine range ile 2'den 10 kadar 2 aralikli deger olusturma
aralik_listesi=list(aralik) #listeye cevir
print("range yapisinin turu: ",type(aralik))
print("aralik_listesi'nin icerigi:",aralik_listesi)

for z in aralik_listesi:
    print(z,end=" \n")
print('\n2. For dongusunden cikildi')