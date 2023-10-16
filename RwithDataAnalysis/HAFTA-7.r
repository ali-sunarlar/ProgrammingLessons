matrisA=matrix(c(1,2,3,4,5),3,2, byrow=TRUE) # 3 satir ve 2 sutundan olusan bir matris olusturur ##once satirlar doldurulur
matrisA

matrisA=matrix(c(1,2,3,4,5,6),3,2, byrow=FALSE) ## 3 satir ve 2 sutundan olusan bir matris olusturur ##once sutunlar doldurulur
matrisA

dim(matrisA) #matrisin boyutları ogreniliyor

karematris=matrix(c(1,2,3,4,5,6,7,8,9),3) #byrow parametresi yazilmaz ise once sutunlar doldurulur.
karematris

matrisB=cbind(c(1,2,3,4),c(5,6,7,8),c(9,10,11,12)) #vektorler sutun olarak birlestiriliyor
matrisB

matrisC=rbind(c(1,2,3,4),c(5,6,7,8),c(9,10,11,12)) #vektorler satir olarak birlestiriliyor
matrisC

matrisD=matrix(c(10,20,30,40,50,60,70,80,90),3)
matrisD

rbind(matrisD,c(33,66,99)) #matrisD'ye c(33,66,99) vektoru satir olarak ekleniyor.

cbind(matrisD,c(77,88,99)) #matrisD'ye c(77,88,99) vektoru sutun olarak ekleniyor

matrisK<-matrix(1:12,byrow=FALSE,ncol=3) #uc satirli bir matris olusturuluyor
matrisK

matrisK[1,2] #matrisK'nın 1. satir ve 2. sutunun kesisimi olan eleman aliniyor

matrisK[1:3,2:3] #matrisK'nın 1.2.3. satir ile 2 ve 3 sutunun kesişimi elemanlari aliniyor

matrisK[,1] #matrisK'nın 1. sutun elemanlari aliniyor

matrisK[1,] #matrisK'nın 1. satir elemanlari aliniyor

matrisK

matrisK[-1,] #1. satir siliniyor

matrisK[,-3] #2. sutun siliniyor

matrisK[-(1:2),]

faktor1=factor(c("Kadin","Erkek","Kadin","Kadin","Erkek"))
faktor1

table(faktor1) #faktorun sayısını level seviyelerini sayısını alırız

faktor2=factor(c("Orta","Yuksek","Orta","Dusuk","Yuksek","Dusuk"))
faktor2

table(faktor2)

faktor2[3]="Cok Yuksek" #faktor2'nin 3 nolu indis elemani "Cok Yuksek" olarak guncellenmek isteniyor
                        #ancak bu kod hata verir. Cunku faktor2'nin olusumunda "cok yuksek" verisi kullanilmamistir.

faktor2[3]="Yuksek" #3 nolu indis elemani "Yuksek" olarak güncellenir.
faktor2

faktor2[-2]  #2 nolu indis elemani siliniyor

faktor2

faktor3=faktor2[-2] #2 nolu indis elemani siliniyor ve degisikligin kalici olması icin
                    #faktor degiskenine aktariliyor
faktor3


