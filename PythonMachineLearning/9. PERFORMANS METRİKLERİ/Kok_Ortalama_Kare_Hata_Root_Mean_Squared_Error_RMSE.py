"""Kök Ortalama Kare Hata (RMSE), bir regresyon modelinin tahminlerinin gerçek değerlere ne kadar yakin
olduğunu ölçen bir metriktir. RMSE, MSE (Ortalama Kare Hata) metriği ile ayni fikri temsil eder, ancak fark
olarak RMSE'nin karekökü alinir."""

from sklearn.metrics import mean_squared_error
from math import sqrt

# Gerçek değerler ve model tahminleri

gercek_degerler = [3.5, 2.0, 4.8, 1.7, 3.2] 
tahminler = [3.2, 2.5, 4.5, 1.9, 3.0]

# MSE hesapla

mse = mean_squared_error(gercek_degerler, tahminler) 
rmse=sqrt(mse)
print("Ortalama Kare Hata (MSE):", rmse) 