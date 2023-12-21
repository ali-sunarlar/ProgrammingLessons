from sklearn.metrics import recall_score

# Gergek etiketler ve model tahminleri

gercek_etiketler = [1, 0, 1, 1, 0, 1, 0, 0, 1] 
tahminler = [1, 0, 1, 1, 0, 0, 1, 1, 1]

# Duyarlılık hesapla

duyarlik = recall_score(gercek_etiketler, tahminler) 
print("Duyarlik (Recall):", duyarlik) 