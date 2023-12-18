set.seed(1) #Seed() her çalıştırılışta aynı rasgele sayıları üretmek için kullanılan fonksiyon 
veri=sample.int (25, 30, replace = TRUE) #1'den 25'e kadar rasgele 30 adet tamsayı sayı üzetir. 
veri 

#ortalamayı hesaplamak için mean() fonksiyonu kullanılır. 
ortalama = mean (veri) 
print (ortalama) 

#Medyanı hesaplamak için median() fonksiyonu kullanılır. 
medyan = median (veri) 
print (medyan) 

#Mod'u hesaplamak için R'da bir kaç yöntem vardır. 
#Bu yöntemlerden en iyi sonuç vereni fonksiyon tanımlamasıdır. 
# Fonksiyon Oluşturuluyor. 
mod_bul <- function(v) { 
    uniqv <- unique (v) 
    uniqv [which.max (tabulate (match (v, uniqv)))] 
    } 
# Yukarıdaki fonksiyon ile elimizdeki verinin modunu hesaplama 
sonuc <-mod_bul (veri) 
print (sonuc) 

#Varyans ve Standart Sapma Hesaplaniyor

#Verinin varyansı hesaplanırken var() fonksiyonu kullanılır 
varyans = var (veri)

#Verinin standart sapması varyansın karekékine eşittir 
standartsapma = sqrt (var (veri))

print (standartsapma) 

#Verinin Histoçramını Çirdirmek
hist (veri, main="Verinin Histogram Grafiği", xlab="Veri", ylab="Siklik", col="lightgreen", axes=TRUE)


