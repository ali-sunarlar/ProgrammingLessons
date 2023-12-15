vektor1=c(5.2,6.7,7.1,4.3,9.0,5.9)

vektor1

plot(vektor1,type="p") #vektor verilerini nokta(point) biciminde gosterir

plot(vektor1,type="l") #vektor verilerini cizgi(line) biciminde gosterir

plot(vektor1,type="o") #vektor verilerini nokta ve cizgi(point-line) biciminde gosterir

plot(vektor1,type="l", main="Test Grafigi") 

plot(vektor1,type="o", main="Test Grafigi", col="blue") 

x=c(1,5,7,3,6,8,4,2)
y=c(3,6,3,5,7,1,9,8)
print(x)
print(y)
#Dağıtık (scatter) grafiği verilerin yatay ve dikey eksen arasında noktalar olarak gösterilmesi ile elde edilir. Vektör
#içerisinde yer alan verilerin konumu koordinat eksenine göre belirlenir.

plot(x,y, main="Dagitim Grafigi", col="black")

#Var olan bir veri seti üzerinde grafik çizdirmek mümkündür. Bu işlem için R içinde var olan hazır "iris" verisi
#kullanılacaktır.
#ilk olarak head() fonksiyonu ile iris datasının ilk altı satırı, daha sonra str()fonksiyonu ile iris datasının 
#öz nitelikleri görüntülendi. Son olarak iris datasının ilk iki sütunu kullanılarak
#dağıtık grafik çizdirilmiştir

head(iris)

str(iris) #iris verisinin oz niteliklerini goruntuler

plot(iris$Sepal.Length, iris$Sepal.Width, main="Iris Datasinin Dagilim Grafigi", col="green")

#Nokta grafiği çizdirmek için dotchart() fonksiyonu kullanılır. Bu fonksiyonu kullanarak bir veri çerçevesinde ele alınan
#sütunların grafiğini çizdirmek için

bebekadi=c("Hasan","Huseyin","Ali","Veli","Omer")
dogumyili=c(2015,2016,2017,2018,2019)
boyu=c(85,90,93,95,100)
kilosu=c(15,17,19,21,23)

bebekler=data.frame (bebekadi,dogumyili,boyu, kilosu)
bebekler

dotchart(t(bebekler[,2:4]), main="Nokta Grafigi", col="blue")

#Çizgi grafik için plot() fonksiyonunu kullanılır. Var olan bir grafik üzerine yeni çizgi eklemek lines() fonksiyonu
#kullanılır. Bu fonksiyon ile aynı grafik üzerinde birden fazla vektörün grafiğini ekleyebiliriz.

plot (satislar$geker, type="o", col="blue", main="Aylik Satış Miktarları")
lines (satislar$yad, type="o", col="green",lty=2) #diğer vektör verileri grafik üzerine lines () ile ekleniyor 
lines (satislar$un, type="o", col="black",lty=2)
lines(satislar$piring, type="o", col="red", lty=4)

plot(iris$Sepal.Length, type="o", main="Iris Datasinin Birden Cok Dagilim Grafigi", col="blue")
lines(iris$Sepal.Width, type="o", col="green",lty="2")
lines(iris$Petal.Length, type="o", col="black",lty="3")
lines(iris$Petal.Width, type="o", col="red",lty="4")

#Etiket eklemek için plot() tanımında xaxt="n" komutu kullanılarak ilk olarak etiketlerin içi boşaltılır. Grafik
#çizildikten sonra, eksen etiketlerini isimlendirmek için text() fonksiyonu kullanılır. axTicks(1) parametresi yatay
#ekseni belirler. par("usr") kullanıcı tarafından tanımlanan grafik bölgesini belirtir. xpd=T/F olabilir. T, grafiğin
#çizdirilen alana göre kırpılabileceğini ifade eder.


plot(satislar$seker, type="o", col="blue", xlab="Aylar", ylab="Satiglar", main="Aylik Satış Miktarları", xaxt="n") lines (satislar$yad, type="c", col="green", lty=2)

lines (satislar$un, type="o", col="black",Klty=3)

lines (satislar$piring, type="o", col="red", lty=4)

text (axTicks (1), par("usr")(3)-2, adj=1, labels=c("Ocak", "Subat", "Mart", "Nisan", "Mayis", "Haziran"), xpd=T) 

#Eksen etiketleri verilen grafiğin içerisinde yer alan çizgilerin neyi temsil ettiği okuyucu tarafından anlaşılmasına ihtiyaç
#vardır. Bunun için, hangi çizginin hangi ürünü temsil ettiğini anlamak için etikete ihtiyaç vardır. R'da etiket eklemek
#için legend() fonksiyonu kullanılır. 

plot(satislar$takim, type="o", col="blue", xlab="Aylar", ylab="Satiglar", main="Aylik Satış Miktarları", xaxt="n") lines (satislar§ceket, type="o", col="green", lty=2)
lines (satislar$gomlek, type="o", col="black",K lty=3)
lines (sataslar$kravat, type="o", col="red", lty=4)
text (axTicks (1), par("usr”)[3]-2, adj=1, labels=c("Ocak”, "Subat","Mart","Nisan","Mayis","Haziran"), xpd=T) 
legend(4,152, legend=c("Takim Elbise", "Ceket", "Gimlek",6 "Kravat"), col=c("blue®, "green", "black", "red"), lty=1:4) 


