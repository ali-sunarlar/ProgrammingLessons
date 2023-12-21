from sklearn.metrics import mean_absolute_error

# Gerçek değerler ve model tahminleri

gercek_degerler = [3.5, 2.0, 4.8, 1.7, 3.2] 
tahminler = [3.2, 2.5, 4.5, 1.9, 3.0]

# MAE hesapla

mae = mean_absolute_error(gercek_degerler, tahminler) 
print("Ortalama Mutlak Hata (MAE):", mae) 