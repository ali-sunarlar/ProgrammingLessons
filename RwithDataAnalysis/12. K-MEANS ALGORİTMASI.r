veri=matrix(c(7,4,2,0,9,6,3,5,4,1,7,8), nrow = 6) 
veri 

round (dist (veri), 2) 

# 5 ve 6 veri setinin başlangıç merkezi olarak alınıyor. A 
# Algoritma olarak "Lloyd" un k-means yaklaşımı seçilmiştir. 
res.k=kmeans (veri,

centers=veri[c(5,6),],

algorithm="Lloyd") 

res.k #kume merkezleri olusturuluyor

res.k$cluster #Verilerin atanmış oldukları kümeler görüntüleniyor 

round (res.k$centers,digits=2) #Oluşan kümelerin final merkezleri belirleniyor. 

#Kumelemenin başarısı için BSS/TSS' ye bölünür. 
round (res.k$betweenss/res.k$totss, 3) 

# Verinin Yiklenmesi 
data (iris) 

head (iris) # verinin ilk 6 satırının görüntülenmesi 

str(iris) # verinin tim alt özelliklerinin görüntülenmesi 

# Gerekli paketlerin kurulması 
install.packages ("clusterR") 
install.packages ("cluster") 

# Kurulan paketlerin yüklenmesi 
library(clusterR) 
library(cluster) 

# Orijinal veriden "Species" etiketli sütunun silinmesi 
iris1=iris[, -5] 
head (iris1) 

# Veri setinin eğitilmesi için K-means kümeleme algoritmasının uydurulması

set.seed(240) # Seed değerinin ayarlanması

# nstart seçeneği, birden çok ilk yapılandırmayı dener ve en iyisi hakkında rapor verir. # Örneğin, nstart=20 eklemek, başlangıçta 20 rastgele merkez noktası oluşturur.

# Daha sonra algoritma için en iyisini seçer.

kmeans.kumele=kmeans(iris1, centers = 3, nstart = 20)

kmeans.kumele

# Herbir gözlem için kümelerin tanımlanması 
kmeans.kumeler$cluster

# Karmaşıklık Matrisi 
karmasiklik_matrisi=table(iris$Species, kmeans.kumeler$cluster) 
karmasiklik_matrisi 

# Modelin Dejerlendirilmesi ve Görselleştirme 
plot(iris1[c("Sepal.Length", "Sepal.Width")])

plot (iris1[c("Sepal.Length", "Sepal.Width")], 
      col = kmeans.kumeler$cluster, 
      main = "K-means ile Olugan 3 Kime") 

# Kime Merkezlerinin (Cizdirilmesi 
kmeans.kumeler$centers 
kmeans.kumeler$centers(, c("Sepal.length", "Sepal.Width")] 

# Kimelerin Gorselleztirilmesi 
y_kmeans <- kmeans.kumelerjcluster 
clusplot (irisl([, c("Sepal.length®, "Sepal.Wideh")), 
            y_kmeans, 
            lines = 1, #Kime Merkeslerini İşaretler 
            shade = TRUE, 
            color = TRUE, 
            labels = 2, 
            plotchar = FALSE, 
            span = TRUE, 
            main = paste ("Iris Verisinin Kümeleri"), 
            xlab = 'Sepal.length', 
            ylab = 'Sepal.¥Width') 


