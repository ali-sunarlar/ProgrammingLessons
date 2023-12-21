


from sklearn.metrics import accuracy_score

# Gerçek etiketler ve model tahminleri

gercek_etiketler = [1, 0, 1, 1, 0, 1, 0, 0, 1] 
tahminler = [1, 0, 1, 1, 0, 1, 0, 0, 1]

# Doğruluk hesapla

dogruluk = accuracy_score(gercek_etiketler, tahminler) 

print("Doğruluk(Accuracy):", dogruluk) 