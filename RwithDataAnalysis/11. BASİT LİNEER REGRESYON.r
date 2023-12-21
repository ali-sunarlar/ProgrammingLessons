#Örnek Veri Seti

veriler=data.frame(agirlik1=c(140,155,159,179,192,200,212), 
                    bacak_boyu=c (60, 62, 67,70,71,72,75))

veriler

plot(agirlik1,bacak_boyu,main='Agirlik ile Bacak Boyu Iliskisi')

plot(agirlik, bacak_boyu, main='Agirliklar ile Bacak Boyu Iliskisi') 
abline (lm(bacak_boyu ~ ağırlık, data = veriler), col = "blue") 

#Veri Seti Olusturma 
veriseti= data.frame(calisma_saati=c(1, 2, 4, 5, 5, 6, 6, 7, 8, 10, 11, 11, 12, 12, 14), 
                    basari=c(64, 66, 76, 73, 74, 81, 83, 82, 80, 88, 84, 82, 91, 93, 89)) 

head (veriseti) #Veri setinin ilk 6 satırını görüntüleme 

attach (veriseti) #Veri çerçevesi değişkenlerine erişmek icin bağlama fonksiyonu kullanılır. 

scatter.smooth (calisma_saati, basari, main='Calisma Saatine Göre Basari Puani') #Mevcut verinin çirdirilmesi 

boxplot(basari) #Veride aykırı veriler olup olmadığı boxplot grafiği ile görüntüleniyor. 

#Basit lineer Modelin Kurulması 
model=lm(basari~calisma_saati) #R'da lineer model 1m() fonksiyonu ile oluşturulur. 

#Modelin Sonuçlarının ekrana yansitilmasi/gosterilmesi 
summary(model)

artik=resid (model) #Artik değerler resid() fonksiyonu ile elde edilir. 

plot (fitted (model), artik) #Artik dedelerin model değerlerine göre çirdirilmesi 
abline (0,0) # Sıfır () eksenini gizdiriyoruz. 

qqnorm(artik) 
qqline (artık) 


