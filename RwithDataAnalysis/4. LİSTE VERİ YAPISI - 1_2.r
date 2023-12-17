#Vektör Oluşturma
v=c(1,8,10,3,5,1,18) # v adlı tamsayılı bir vektör oluşturuldu
assign("v1",c(10,20,30,40,50)) # "v1" adlı bir vektör oluşturuldu

print(v)
print(v1)

#Bir vektör başka bir vektör içerisinde veri olarak kullanılabilir
v2=c(-1,-2,-3,-4,-5)
w=c(10,20,v2)     #v2 vektörü w vektörü içerisine dahil edildi

print(v2)
print(w)

vektor4=c(61,3.14,"R ile Veri Analizi",TRUE)
print(vektor4)

vektor4
#Vektör elemanlarına erişim indis değerleri ile gerçekleştirilir.
vektor4[2] #indis numarası 2 olan eleman görüntülenir.
vektor4[2:4] #indis değeri 2 ile 4 arasında olan elemanlar görüntülenir.

kv=c("Mehmet Ziya", "Hülya", "Kazım", "Ayşe") #Karakter tipinde vektör oluşturur
kv

kv=c(kv,"Fatih", "Havva") #kv vektörüne ; Fatih ve Havva adlı iki eleman eklendi

kv

length(kv) #kv vektörünün uzunluğu öğrenilir

nchar(kv) #vektörün içindeki her bir elemanın karakter uzunlukları belirlenir.

vektor5=c(TRUE,FALSE,TRUE,FALSE,NA,NA)

vektor5

vektor6=c(12,15,17,21,23,35,37) #elemanları sayısal olan bir vektor oluşturuldu

vektor6

vektor6>21 #vektor6 içerisinde 21'den büyük olanlar

x=c(1,3,5,7,9)
y=c(2,4,6,8,10)

toplam=x+y #x ve y vektorleri toplama işlemi yapılıyor

toplam

carpim=x*y #x ve y vektorleri çarpma işlemi yapılıyor

carpim

isimler=c("Mahmut","Aysel","Kazım","Can","Hülya")

names(isimler)=c("ID10","ID20","ID30","ID40","ID50")

isimler

isimler[3]="Abdullah"

isimler

isimler[-4]

 isimler # silinmediği gözükmektedir.

isimler=isimler[-4] #kalıcı hale geldi, silindi

isimler

yeni_isimler=c("Mehmet","Ziya","Ayşe","Yusuf","Kerem","Zehra")

yeni_isimler

yeni_isimler[-c(2:4)]

yeni_isimler

yeni_isimler=NULL

yeni_isimler

adlar=c("Mehmet","Ziya","Ayşe","Yusuf","Kerem","Zehra","Mahmut","Aysel","Kazım","Can","Hülya")

adlar

sort(adlar) #A'dan Z'ye sıralama

sort(adlar, decreasing=FALSE)

sort(adlar, decreasing=TRUE) #Z'den A'ya Sıralama yapar


