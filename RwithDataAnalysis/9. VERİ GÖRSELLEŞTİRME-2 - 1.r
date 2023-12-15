#x: çizilmek istenen histogram için değer vektörü
#breaks: Histogramin x ekseninden yer alan değişkenin gruplarinin ayrilma, noktalarini hesaplayan bir fonksiyon değeri
#feq: (mantiksal değer alir); Histogram TRUE değeri için frekanslari; FALSE, değeri için ise olasilik yoğunluk
#fonksiyonunu temsil eder.
#col: sütun rengi belirlenir.
#labels: sütunlar için etiket bilgisi girilir.
#main: Başlik ekler
#hist (x, breaks="sturges", freq=NULL, right=TRUE, col=NULL, .....)
#Elimizde 50 gramlik baharat paketleri olan ve aşağida basit seri şeklinde verilmişbir veri seti olsun. Bu verinin
#histogramini çizdiren kodun ekran görüntüsü
paketler=c(40,43,45,46,46,47,48,48,48,46,48,48,50,50,50,51,51,61,51,52,52,52,53,54,54,54,54,55,56,59) 
paketler

hist (paketler, xlab="Paketler", ylab="Frekans", main="Baharat Pakeleri için Histogram", col="yellow", labels=TRUE, freq=TRUE) 
#histogram cizdiriliyor 
#içerisinde yer alan hazir iris veri setini kullanarak histogram oluşturalim. İlk olarak iris veri setinin
#özelliklerini görüntüleyelim. Sonra da belli bir sütun verileri için histogram çizdirelim
str(iris)

hist (iris$Sepal.Length, xlab="Canak Boyu", ylab="Siklik", col="yellow",main="Iris Çiçek Datasi") 
#Barlar üzerine siklik değerlerini de yazdirmak mümkündür. Bunun için labels parametresi kullanilir. Aşağidaki ekran
#görüntüsünde bu işlemi yapan kod verilmiştir
#Frokans değerleri labels etiketi TRUE yapilarak yardirilir 
hist(iris$Sepal.Width, xlab="Canak Eni", ylab="Siklik", col="lightblue", main="Iris Çiçek Datasi", labels=TRUE) 
#Frekanslari kullanan yoğunluk grafiklerini çizdirmek için density() fonksiyonukullanilir. Histoğram ve yoğunluk
#grafiklerini birlikte çizdirmek için ilk olarak yoğunluk grafiği çizdirilir. Daha sonra histoğram grafiği yoğunluk
#grafiğine eklenir. Yoğunluk grafiğiile histogram grafiğinin etiketlerinin üst üste gelmesi için birinci grafiğin etiketleri
#ve eksen çizgileri (axes) yazdirmiyoruz. Örnek: Bu işlem için ilk olarak iris datasini kullanarak bir yoğunlukfonksiyonu
#elde edelim. Yoğunluk grafiğini çizdirmek için plot() fonksiyonu kullanilir.
yogunluk=density (iris$Sepal.Length) 
plot (yogunluk, main="Iris Çanak Yapraklari Yoğunluk Grafiği") 

hist(iris$Sepal.Length, col="lightgreen", main="", xlab="",  ylab="",  axes=FALSE)
#Yoğunluk grafiğinin histogram üzerine yazdirilmasi için
#par(new=T) fonksiyonu kullanilir. Bu komut kullanilmaz ise histogram çizdirilmeyecektir.
hist (iris$Sepal.Length, col="lightgreen", main="", xlab="", ylab="", axes=FALSE)

par (new=T)

yogunluk2=density(iris$Sepal.Length)

plot (yogunluk2, xlab="Degerler", ylab="Siklik", main="Iris Çanak Boyu Yoğunluk Grafiği") 
#Çubuk grafik çizdirmek için barplot() fonksiyonu kullaniliyor. En basitçe haliyle çubuk grafik bir vektör olarak çizilir.

v=c(10,20,15, 30,50,40,30) 
barplot(v, main="V vektörü", xlab="Sayilar", ylab="Yofunluk Değerleri") 
#Sütun (Bar) grafik çizimi

adi=c ("Hasan", "Celal", "Meral", "Hande", "Kamil")

matematik=c(9,7,5,7,2)

fizik=c(5,8,3,5,6)

kimya=c (7,9,6,6,4)

basari=data.frame (adi, matematik, fizik,kimya) #vektörler veri gergevesine dönüştürülüyor. 
basari 

barplot(basari$matematik, main="Matematik Puanlari",col="lightblue", xlab="Ogrenci Adai", ylab="Puani",names=basari$adi) 
#Frekanslarin çubuk grafiğe eklenmesi için table() fonksiyonu kullanilir. Başari adli veri çerçevesinin fizik dersi ile ilgili
#frekans grafiğini çizdirelim.

frekans=table(basari$fizik) 
barplot(frekans, main="Fizik Basarisi", xlab="Basari Puani", ylab="Ogrenci Sayisi") 
#Bazi durumlarda grafiklerde izgara kullanmak isteyebiliriz. Izgaralar sayisal olan grafiklerin daha rahat okunmasini
#sağlayabilir. Grafiklere izgara eklemek için grid() fonksiyonu kullanilir. Bu fonksiyonun genel yapisi grid(x,y,
#col="renk") biçimindedir. Bu söz diziminde x, y oluşturulmak istenen izgaranin en ve boyunu ifade eder. Dolayisiyla
#grafik üzerinde x*y kadar izgara oluşur. col ise izgaraya verilecek olan rengi gösterir.

frekans=table(basari$fizik) 
barplot (frekans, main="Fizik Basarisi", xlab="Basari Puani", ylab="Ogrenci Sayisi") 
grid(10,10, col="blue") #Grafik dzerinde 100 adet kare (izgara) oluşturur 
#Yatay bar oluşturmak için barplot() fonksiyonu içinde horiz=TRUE parametresi kullanilir.
#
frekans=table(basari$fizik) 
barplot (frekans, main="Fizik Bagarisi", xlab="Basari Puani",ylab="Ogrenci Sayisi", horiz=TRUE) 
#Bazi durumlarda elimizde olan veriyi bar veya histogram gibi grafiklerle temsil etmek uygun olmayabilir. Bu durumda
#farkli grafik türü seçmek gerek. Örnegin bir yekün içerisinde yüzde olarak kimin ne kadar etkisi olduğu veya yer aldiği,
#pasta türü grafiklerle gösterilir. Pasta grafiği çizdirmek için pie() fonksiyonu kullanilir.
partiler=c("X partisi","Y partisi", "Z partisi", "Bagamsizlar", "Geçersiz Oylar") 
oylar=c(13000, 35000,28000, 5000, 2500)

sonuclar=data.frame (partiler, oylar) #Veri çerçevesi oluşturuluyor

sonuclar 

#Yukar:da yer alan veri çerçevesindeki verileri bir pasta grafiği ile gösterelim. 
pie(sonuclar$oylar, labels (sonuclar$partiler, main="Partilere Göre Oylarin Dağilimi")) 
#Yukarida elde edilen grafik doğrudan vektör değerlerini kullanarakoluşturuldu. Bu grafik üzerinde partilerin aldiklari
#oy oranlarini ve parti isimlerini göstermek isteyelim. İlk olarak partilerin aldiklari oylarin yüzde değerleri hesaplanir.
#Yüzde değerlerini elde etmek için her bir partinin oy değeri toplam oy değerine bölünür ve elde edilen değerler 100 ile
#çarpilir. Bu işlem aşağidaki ekran görüntüsünde verilmiştir.

yuzde=sonuclar$oylar/sum(sonuclar$oylar) *100 #Partilsrin oy oranlari hesaplaniyor. 
yuzde 

yuzde=round (yuzde) # Yüzde değerleri tam sayiya yuvarlaniyor 
yuzde 

etiket=sonuclar$partiler

etiket=paste(etiket, yuzde)

etiket=paste(etiket, "%", sep="")

pie (sonuclar$oylar, labels=etiket, main="Oylarin Partilere Göre Yüzde Olarak Dağilimi") 
#The Grammar of Graphics (İstatistik ve Hesaplama) adli bir kitapta tanitilan fikirler etrafinda oluşturulmuş bir
#veri görselleştirme kütüphanesidir. Bu kütüphanenin 3 ana bileşeni vardir. Bu bileşenleri kullanarak kolaylikla
#karmaşik grafikler oluşturmamiza yardimci olur. Bu bileşenler: veri, koordinat sistemi ve geometri’den oluşur. Ayrica
#ggplot2'ye renk, şekil, boyut vb. gibi hangi parametreleri kullanilacağini da belirtebiliriz.
#ggplot2’un söz dizimi;
#ggplot(veri, aes())+geom()
#Bu söz diziminde:
#veri – kullanilan veri seti
#aes() – estetik şekil
#geom() – Çizdirilmek istenen grafikleri ifade eder.

#veri çerçevesi oluşturalim 
veri <- data.frame("kategori" = c('A', 'B', 'C', 'D'), "miktar" = c(25, 40, 27, 8)) 
#pasta dilimi grafiği çizdirelim 
ggplot(veri, aes(x="", y=miktar, fill=kategori)) + 
geom_bar(stat="identity", width=12) + 
coord_polar("y", start=2) 
#ggplot2'deki varsayilan pasta grafiği oldukça karişik görünüyor. Görünümü iyileştirmenin en basit yolu, arka plani,
#izgarayi ve etiketleri kaldiran theme_void() işlevini kullanmaktir
ggplot(veri, aes(x="", y-miktar, fill-kategori)) + 
geom_bar(stat="identity", width=1) + 
coord_polar("y", start=8) + 
theme_void() 
#dilimlerin içine etiketler ekleyerek grafiğin görünümü daha da iyileştirilmiştir Scale_fill_manual() argümaniyla dilimler için #kullanmak üzere kendi hex renklerimizi (
#https://htmlcolorcodes.com/color-picker/) belirterek grafiği daha da özelleştirebiliriz
ggplot(veri, aes(x="", y-miktar, fill=kategori)) + 
geom_bar(stat="identity", width=1) + 
coord_polar("y", start=0) + 
geom_text(aes(label = paste0(miktar, "%")), position = position_stack(vjust=0.5)) + 
labs(x =NULL, y = NULL, fill = NULL) + 
theme_classic() + 
theme(axis.line = element_blank(), 
      axis.text = element_blank(), 
      axis.ticks = element_blank()) + 
scale_fill_manual(values=c("FF5733", "yellow", "lightblue", "green")) 
#Renk skalalarindan birini seçerek dilimlerin renklerini de özelleştirebilirsiniz. Örneğin, "mavi" renk skalasi şöyle
#görünür:

ggplot(veri, aes(x="", y-miktar, fill=kategori)) + 
geom_bar(stat="identity", width=1) + 
coord_polar("y", start=0) + 
geom_text(aes(label = paste0(miktar, "%")), position = position_stack(vjust=0.5)) + 
labs(x =NULL, y = NULL, fill = NULL) + 
theme_classic() + 
theme(axis.line = element_blank(), 
      axis.text = element_blank(), 
      axis.ticks = element_blank()) + 
scale_fill_brewer(palette="Blues")


