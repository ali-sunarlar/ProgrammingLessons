from sklearn.metrics import r2_score

# Gergek degerler ve model tahminleri

gercek_degerler = [3.5, 2.0, 4.8, 1.7, 3.2] 
tahminler = [3.2, 2.5, 4.5, 1.9, 3.0]

# R-Kare hesapla

r2 = r2_score(gercek_degerler, tahminler) 
print("R-Kare (Coefficient of Determination):", r2) 