yas=c (25,16, 38,45) 
isim=c("Hasan", "zehra", "Kamil", "Hatice") 
adres=c("istanbul", "sakarya", "Ankara", "Mersin") 

cerceve1=data.frame(yas, isim, adres) #olusturulan vektorler veri cercevesine donusturiluyor. 
cerceve1 #Veri cercevesi ekrana yazdiriliyor. 

cerceve2=data.frame (c(101,102,103), c("a","B","C")) 
cerceve2 

colnames (cerceve2)=c ("Kodu", "Sinifi") 
cerceve2 

rownames (cerceve2)=c("1. sira","2. sira","3. sira") 
cerceve2 

colnames (cerceve2) [1]="Ogrenci No" 
colnames (cerceve2) [2]="Grubu" 
cerceve2 

head (iris) #IRIS hazir veri setinin ilk alti satiri gériuntuleniyor. 

str(iris) #iris verisinin igerig§i géruntuleniyor. 

yas=c (25,27, 38,43)

isim=c("ismail", "Nalan", "Melek", "Tahsin")

sehir=c("Konya", "Antalya", "Van", "Antalya")

cerceve3=data.frame (yas, isim, sehir) #vektorler veri cergevesine donisturuliyor. 
cerceve3 

attributes (cerceve3) #cerceve3'un oz nitelikleri goruntiulenir. 

attributes (cerceve3)$names #Uye adi ile, tiyenin &znitelikleri géruntulenir.

attributes (cerceve3) [3] #Uye numarasi ile ilyenin &znitelikleri gériuntitlenir. 

rownames (cerceve3) #(ercevenin satir numaralari goruntulenir. 

colnames (cerceve3) #Cercevenin sutun o6znitelikleri gériuntulenir. 

cerceve3[[3]] #cercevenin 3 nolu stitun deferleri géruntillenir. 

cerceve3[["yas"]] #yas siitiinuna ait veriler gérintulenir (satir olarak). 

cerceve3[("yas")] #yas sutununa ait veriler goruntulenir (sutun olarak). 

cerceve3

cerceve3[2,] #ikinci satir ve tum sutunlar goruntulenir

cerceve3[2,3] # 2. satir 3. sutun goruntulenir

cerceve3[c(1,3),] #Belirlenen satirlar alinir.

cerceve3[,c(1,3)] #belirlenen sutunlar alinir.

okul=c("SAU Vakif Koleji","Ugur","Ilke","Sahin") #Okul isimli bir vektor olusturuldu

cerceve3

cerceve4=cbind(cerceve3,okul) #olusturulan vektor, sutun olarak cerceve3'e eklendi ve cerceve4'e aktarildi.

cerceve4

satir=data.frame (yas=50, isim="Murat",sehir="Bolu",okul="TED") #satir adli bir cergeve olusturuldy

cerceve5=rbind(cerceve4, satir)  #olusturulan satir adli cerceve, cerceve4'e yani bir satir olarak eklendi 
# ve cerceve5’e aktarildi.

cerceve5
cerceve6=cerceve5[,-1] #cerceve5'in birinci sutununu siler. Sonuc cerceve6'ya aktarilir.
cerceve5

cerceve6

cerceve5[-2,] #ikinci satirini siler

cerceve5[,-c(1,3)] #1. ve 3. sutun silinir.

cerceve5

cerceve5[-c(2,4),] #2. ve 4. satirlari silinir.


