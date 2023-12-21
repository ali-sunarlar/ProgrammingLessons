from sklearn.metrics import precision_score

# Gergek etiketler ve model tahminleri

gercek_etiketler = [1, 0, 1, 1, 0, 1, 0, 0, 1] 
tahminler = [1, 0, 1, 0, 1, 1, 0, 1, 1]

# Kesinlik hesapla

kesinlik = precision_score(gercek_etiketler, tahminler) 
print("Kesinlik(Precision):", kesinlik) 