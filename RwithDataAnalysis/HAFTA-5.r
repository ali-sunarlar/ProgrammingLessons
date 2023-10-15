liste1=list(54) #icerigi 54 olan bir liste olusturuldu
print(liste1)

liste2=list(54,"S",TRUE)
print(liste2)

yas=c(25,35,45,55)
kan=c("A","B","0","AB")
sonuc=c(FALSE,TRUE,FALSE,TRUE)

liste3=list(yas,kan,sonuc)

liste3

isimler=c("Tahsin","Zehra","Ayse","Mehmet","Ziya","Hulya")

isimler

as.list(isimler) #as.list fonksiyonu ile isimler adlı vektor liste veri yapısına dönüştürülüyor.

isimler

yeni_isim=as.list(isimler) #kalici olmasi icin bir degiskene aktarildi.

yeni_isim

liste4=vector("list",3) #vector fonksiyonu bos liste olusturur. Bu ornekte 3 elemanli bos bir liste olusturuldu.

liste4

vektor=c(1,2,3,4,5,6)
vericercevesi=data.frame(c(1,2,3),c("A","B","C")) #Veri cercevesi olusturuldu
matris=matrix(c(1,2,3,4,5,6,7,8,9),3,byrow=TRUE) #matris olusturuldu #Not:veri cercevesi ve matris ilerleyen bolumlerde anlatilacaktir.

liste5=list(vektor,vericercevesi,matris) #Vektor, veri cercevesi ve matris liste veri yapisina donusturuldu

liste5

liste5[[3]][3,2] #Listenin 3 nolu elemani olan matris nesnenin 3. satir ve 2. sutun elamanina erisim saglar

liste5[2] #listenin 2 nolu elemani olan veri cercevesinin tum elemanlarina (tamamina) erisim saglar

liste6=list(vektor1=vektor, vericercevesi1=vericercevesi, matris1=matris) #list (verilecek ad=verinesnesi1, verilecek ad=veri nesnesi2,..)

liste6

dilim1=liste6["matris1"] #liste6 adli nesnenin matris adli parcasi aliniyor.

dilim1

dilim2=liste6[c("vericercevesi1","matris1")] #liste6 adli nesnenin matris ve veri cercevesi adli parcasi aliniyor

dilim2

liste6[["vericercevesi1"]]

liste6$vericercevesi1

liste6$matris[2,2] #matrisin 2. satir ve 2. sutun elemani dilimlenir.

vek2=c(10,20,30,40,50,60) #vek2 adli bir vektor olusturuldu
liste7=list(vektor=vek2) #olusturulan vektor liste veri yapisina donusturuluyor

liste7

vek3=c(5,6,7,8,9,10) #vek3 adli bir vektor olusturuluyor
liste7[[2]]=vek3 #liste7 adli listeye, vek3 vektoru listenin ikinci elemani olarak ekleniyor

liste7

liste7[[3]]=c(5,6,7,8) #liste7 adli liste veri yapisina 3. uyesi olarak bir vektor direkt ekleniyor.

liste7

liste8=liste6 #Daha once olusturulmus oldugumuz liste6 adli listeyi liste8'e esitleyeylim ve bu listeyi kullanarak
              #guncelleme ve silme islemlerini gerceklestirelim

liste8

liste8$vektor1[4]=10 #Uye ismi kullanarak liste8'in vektor uyesinin 4 nolu indis degerli elemani
                    #10 olarak guncellenir
liste8$vericercevesi1[3,1]=9 #liste8'nin vericercevesi1 uyesinin 3. satir ve 1. sutun elemani 9 olarak guncellenir.
liste8$matris1[1,1]=20  #liste8'nin matris uyesinin 1. satir ve 1. sutun elamani 20 olarak guncellenir.

liste8

liste8[[1]][3]=20 #Uye ismi kullanılmadan liste8'in 1 nolu uyesinin 3 nolu indis degerli elemani
                    #20 olarak güncellenir.
liste8[[2]][3,2]="B" #liste8'in 2 nolu uyesinin 3. satir ve 2. sutun elemani "B" olarak guncellenir
liste8[[3]][3,3]=88  #liste8'in 3 nolu uyesinin 3. satir ve 3. sutun elemani 88 olarak guncellenir.

liste8

liste8[[1]]=NULL # Uye ismi kullanılmadan uye numarasi ile liste8'in 1 nolu uyesi siliniyor.

liste8

liste9=list(vektor=c(12,10,25,18,46), matris=matrix(c(2,5,7,3,8,12,45,67,93),3))

liste9

lapply(liste9,sum) #liste9'un vektor ve matris uye elemanlarinin toplami hesaplaniyor.
                    #ve liste biciminde gosteriliyor

lapply(liste9,mean) #liste9'un vektor ve matris uye elemanlarinin ortalamasi hesaplaniyor.

sapply(liste9,min) #liste9'un vektor ve matris uye elemanlarinin en kucugu bulunuyor.
                    #ve tablo biciminde goruntuleniyor

sapply(liste9,max) #liste9'un vektor ve matris uye elemanlarinin en buyugu bulunuyor.


