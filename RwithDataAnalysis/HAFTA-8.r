t=45
if(t>40)
    print("Sonuc dogru")

m=50
n=70
if(m>20)
    fark=n-m
cat("Sonuc",fark)

z=5
P=70
if(z>20)
    fark=p-z
cat("Sonuc",fark)
print("Sart Saglanamadi")

notu=60
if (notu>50) { 
    print ("DEGER") 
}else{
    print ("KALIR") } 

sayi=-15
if(sayi>0){
    print("Girilen Sayi Pozitiftir")
}else{
    print("Girilen Sayi Negatiftir")
}

x=5
if(x<0){
    print("Sayi negatiftir")
}else if(x>0){
    print("Sayi pozitiftir")
}else{
    print("Sayi sifirdir")
}

for(i in 1:5) #1 den 5 e kadar rakamlari ekrana yazdirir
    print(i)

for (i in 4:12) #4 den 12 ye kadar rakamlari ekrana yazdirir
    print(i)

h=c(5,10,15,20,25,30,35) #vektor olusturuluyor
toplam=0                 #toplama islemlerinde baslangicta toplam degeri sifira esitlenmesi gerekir.
for (i in 1:length(h)){   #length() fonksiyonu ile h vektorunun uzunlugu hesaplaniyor
    toplam=toplam+h[i]
}
print(toplam) #vektor elemanlarinin toplami ekrana yazdiriliyor

x=c(2,5,8,11,14,23,45,88)
i=1                      #while yapisinda donguyu kontrol etmek icin indis degeri baslangicta 1'e esitlenir
while(x[i]<10)           #x vektorunun elemanlarinin indis degeri ile kontrol ediliyor
                         #10'dan kucuk olanlar ekrana yazdiriliyor
{
print(x[i])
i=i+i
}

n=10
toplam=0
i=1
while(i<=n)
{
    toplam=toplam+i
    i=i+1
}
print(toplam)

for(i in 1:10)
{
if(i==7)
break   #i=7 oldugunda donguden cikilir.
print(i)
}

i=1
n=10
while (n!=i){ #n i'ye esit olmadigi surece dongu devam eder
       #if(i==4) #i 4 oldugunda donguden cikar
    #break
    print(i)
    i+i+1 
} 


x=1:5
for(rakam in x){
    if(rakam==3){
        next #3 rakamini atla
    }
    print(rakam)
}

for(i in 1:10){
    if(i<=5){
        next #ilk bes rakamini 
    }
    print(i)
}

k=c(3,1,8,7,12)
y=c(5,2,3,8,6)
toplam=0
for(i in 1:length(y)){
    toplam[i]=k[i]+y[i] #her dongude indise karsilik gelen degerler toplanir
}
print(toplam)

k1=c(3,1,15,7,12)
y1=c(5,2,13,8,6)
toplam1=0
toplam1=k1+y1 #vektor elemanlari toplanir
print(toplam1)

adi=c("Hasan","Hulya","Ayse","Mehmet","Zehra")
cinsiyet=c("E","K","K","E","K")
boy=c(176,160,165,180,179)
kilo=c(75,55,58,80,61)
personel=data.frame(adi,cinsiyet,boy,kilo) #vektorler veri cercevesine donusturuluyor
personel

kilo_ortalama=apply(personel[4],2,mean) #Cinsiyet ayrimi olmadan kilo ortalamasi hesaplaniyor
print(kilo_ortalama)

cinsiyet_kilo_ortalama=tapply(as.vector(personel[,4]),factor(personel[,2]),mean)
print(cinsiyet_kilo_ortalama)

personel

liste1=as.list(personel[,3:4]) #cercevenin 3. ve 4. sutunu liste olarak aliniyor
liste1

lapply(liste1,mean)

sapply(liste1,mean)
print(sapply(liste1,mean))


