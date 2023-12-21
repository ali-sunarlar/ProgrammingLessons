from sklearn.metrics import confusion_matrix

# Gerçek etiketler ve model tahminleri

gercek_etiketler = [1, 0, 1, 1, 0, 1, 0, 0, 1]

tahminler = [1, 0, 1, 1, 0, 0, 1, 1, 1]

# Karmagiklik matrisini hesapla

karmasiklik_matrisi = confusion_matrix(gercek_etiketler, tahminler) 
print(karmasiklik_matrisi) 