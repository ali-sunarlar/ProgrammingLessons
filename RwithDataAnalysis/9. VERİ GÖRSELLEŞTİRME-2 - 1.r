x: çizilmek istenen histogram için değer vektörü
breaks: Histogramın x ekseninden yer alan değişkenin gruplarının ayrılma, noktalarını hesaplayan bir fonksiyon değeri
feq: (mantıksal değer alır); Histogram TRUE değeri için frekansları; FALSE, değeri için ise olasılık yoğunluk
fonksiyonunu temsil eder.
col: sütun rengi belirlenir.
labels: sütunlar için etiket bilgisi girilir.
main: Başlık ekler
hist (x, breaks="sturges", freq=NULL, right=TRUE, col=NULL, .....)
Elimizde 50 gramlık baharat paketleri olan ve aşağıda basit seri şeklinde verilmişbir veri seti olsun. Bu verinin
histogramını çizdiren kodun ekran görüntüsü
paketler=c(40,43,45,46,46,47,48,48,48,46,48,48,50,50,50,51,51,61,51,52,52,52,53,54,54,54,54,55,56,59) 
paketler

hist (paketler, xlab="Paketler", ylab="Frekans", main="Baharat Pakeleri için Histogram", col="yellow", labels=TRUE, freq=TRUE) 
#histegram cizdiriliyor 
 içerisinde yer alan hazır iris veri setini kullanarak histogram oluşturalım. İlk olarak iris veri setinin
özelliklerini görüntüleyelim. Sonra da belli bir sütun verileri için histogram çizdirelim
str(iris)

hist (iris$Sepal.Length, xlab="Canak Boyu", ylab="Siklik", col="yellow",main="Iris Çiçek Datası") 
Barlar üzerine sıklık değerlerini de yazdırmak mümkündür. Bunun için labels parametresi kullanılır. Aşağıdaki ekran
görüntüsünde bu işlemi yapan kod verilmiştir
#Frokans değerleri labels etiketi TRUE yapılarak yardırılır 
hist(iris$Sepal.Width, xlab="Canak Eni", ylab="Siklik", col="lightblue", main="Iris Çiçek Datası", labels=TRUE) 
Frekansları kullanan yoğunluk grafiklerini çizdirmek için density() fonksiyonukullanılır. Histoğram ve yoğunluk
grafiklerini birlikte çizdirmek için ilk olarak yoğunluk grafiği çizdirilir. Daha sonra histoğram grafiği yoğunluk
grafiğine eklenir. Yoğunluk grafiğiile histogram grafiğinin etiketlerinin üst üste gelmesi için birinci grafiğin etiketleri
ve eksen çizgileri (axes) yazdırmıyoruz. Örnek: Bu işlem için ilk olarak iris datasını kullanarak bir yoğunlukfonksiyonu
elde edelim. Yoğunluk grafiğini çizdirmek için plot() fonksiyonu kullanılır.
yogunluk=density (iris$Sepal.Length) 
plot (yogunluk, main="Iris Çanak Yaprakları Yoğunluk Grafiği") 

hist(iris$Sepal.Length, col="lightgreen", main="", xlab="",  ylab="",  axes=FALSE)
Yoğunluk grafiğinin histogram üzerine yazdırılması için
par(new=T) fonksiyonu kullanılır. Bu komut kullanılmaz ise histogram çizdirilmeyecektir.
hist (iris$Sepal.Length, col="lightgreen", main="", xlab="", ylab="", axes=FALSE)

par (new=T)

yogunluk2=density(iris$Sepal.Length)

plot (yogunluk2, xlab="Degerler", ylab="Siklik", main="Iris Çanak Boyu Yoğunluk Grafiği") 
Çubuk grafik çizdirmek için barplot() fonksiyonu kullanılıyor. En basitçe haliyle çubuk grafik bir vektör olarak çizilir.

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
Frekansların çubuk grafiğe eklenmesi için table() fonksiyonu kullanılır. Başarı adlı veri çerçevesinin fizik dersi ile ilgili
frekans grafiğini çizdirelim.

frekans=table(basari$fizik) 
barplot(frekans, main="Fizik Basarisi", xlab="Basari Puani", ylab="Ogrenci Sayısı") 
Bazı durumlarda grafiklerde ızgara kullanmak isteyebiliriz. Izgaralar sayısal olan grafiklerin daha rahat okunmasını
sağlayabilir. Grafiklere ızgara eklemek için grid() fonksiyonu kullanılır. Bu fonksiyonun genel yapısı grid(x,y,
col="renk") biçimindedir. Bu söz diziminde x, y oluşturulmak istenen ızgaranın en ve boyunu ifade eder. Dolayısıyla
grafik üzerinde x*y kadar ızgara oluşur. col ise ızgaraya verilecek olan rengi gösterir.

frekans=table(basari$fizik) 
barplot (frekans, main="Fizik Basarisi", xlab="Basari Puani", ylab="Ogrenci Sayısı") 
grid(10,10, col="blue") #Grafik dzerinde 100 adet kare (ızgara) oluşturur 
Yatay bar oluşturmak için barplot() fonksiyonu içinde horiz=TRUE parametresi kullanılır.

frekans=table(basari$fizik) 
barplot (frekans, main="Fizik Bagarisi", xlab="Basari Puani",ylab="Ogrenci Sayısı", horiz=TRUE) 
Bazı durumlarda elimizde olan veriyi bar veya histogram gibi grafiklerle temsil etmek uygun olmayabilir. Bu durumda
farklı grafik türü seçmek gerek. Örnegin bir yekün içerisinde yüzde olarak kimin ne kadar etkisi olduğu veya yer aldığı,
pasta türü grafiklerle gösterilir. Pasta grafiği çizdirmek için pie() fonksiyonu kullanılır.
partiler=c("X partisi","Y partisi", "Z partisi", "Bagamsizlar", "Geçersiz Oylar") 
oylar=c(13000, 35000,28000, 5000, 2500)

sonuclar=data.frame (partiler, oylar) #Veri çerçevesi oluşturuluyor

sonuclar 

#Yukar:da yer alan veri çerçevesindeki verileri bir pasta grafiği ile gösterelim. 
pie(sonuclar$oylar, labels (sonuclar$partiler, main="Partilere Göre Oyların Dağılımı")) 
Yukarıda elde edilen grafik doğrudan vektör değerlerini kullanarakoluşturuldu. Bu grafik üzerinde partilerin aldıkları
oy oranlarını ve parti isimlerini göstermek isteyelim. İlk olarak partilerin aldıkları oyların yüzde değerleri hesaplanır.
Yüzde değerlerini elde etmek için her bir partinin oy değeri toplam oy değerine bölünür ve elde edilen değerler 100 ile
çarpılır. Bu işlem aşağıdaki ekran görüntüsünde verilmiştir.

yuzde=sonuclar$oylar/sum(sonuclar$oylar) *100 #Partilsrin oy oranları hesaplanıyor. 
yuzde 

yuzde=round (yuzde) # Yüzde değerleri tam sayıya yuvarlanıyor 
yuzde 

etiket=sonuclar$partiler

etiket=paste(etiket, yuzde)

etiket=paste(etiket, "%", sep="")

pie (sonuclar$oylar, labels=etiket, main="Oylarin Partilere Göre Yüzde Olarak Dağılımı") 
The Grammar of Graphics (İstatistik ve Hesaplama) adlı bir kitapta tanıtılan fikirler etrafında oluşturulmuş bir
veri görselleştirme kütüphanesidir. Bu kütüphanenin 3 ana bileşeni vardır. Bu bileşenleri kullanarak kolaylıkla
karmaşık grafikler oluşturmamıza yardımcı olur. Bu bileşenler: veri, koordinat sistemi ve geometri’den oluşur. Ayrıca
ggplot2'ye renk, şekil, boyut vb. gibi hangi parametreleri kullanılacağını da belirtebiliriz.
ggplot2’un söz dizimi;
ggplot(veri, aes())+geom()
Bu söz diziminde:
veri – kullanılan veri seti
aes() – estetik şekil
geom() – Çizdirilmek istenen grafikleri ifade eder.

#veri çerçevesi oluşturalım 
veri <- data.frame("kategori" = c('A', 'B', 'C', 'D'), "miktar" = c(25, 40, 27, 8)) 
#pasta dilimi grafiği çizdirelim 
ggplot(veri, aes(x="", y=miktar, fill=kategori)) + 
geom_bar(stat="identity", width=12) + 
coord_polar("y", start=2) 
ggplot2'deki varsayılan pasta grafiği oldukça karışık görünüyor. Görünümü iyileştirmenin en basit yolu, arka planı,
ızgarayı ve etiketleri kaldıran theme_void() işlevini kullanmaktır
ggplot(veri, aes(x="", y-miktar, fill-kategori)) + 
geom_bar(stat="identity", width=1) + 
coord_polar("y", start=8) + 
theme_void() 
 dilimlerin içine etiketler ekleyerek grafiğin görünümü daha da iyileştirilmiştir Scale_fill_manual() argümanıyla dilimler için kullanmak üzere kendi hex renklerimizi (
https://htmlcolorcodes.com/color-picker/) belirterek grafiği daha da özelleştirebiliriz
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
Renk skalalarından birini seçerek dilimlerin renklerini de özelleştirebilirsiniz. Örneğin, "mavi" renk skalası şöyle
görünür:

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


