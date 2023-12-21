from sklearn.metrics import mean_squared_error

# Gerçek değerler ve model tahminleri

gercek_degerler = [3.5, 2.0, 4.8, 1.7, 3.2] 
tahminler = [3.2, 2.5, 4.5, 1.9, 3.0]

# MSE hesapla

mse = mean_squared_error(gercek_degerler, tahminler) 
print("Ortalama Kare Hata (MSE):", mse) 