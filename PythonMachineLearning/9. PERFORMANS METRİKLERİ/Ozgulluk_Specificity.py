# Gergek etiketler ve model tahminleri

gercek_etiketler = [1, 0, 1, 1, 0, 1, 0, 0, 1]

tahminler = [1, 0, 1, 1, 0, 0, 1, 1, 1]

# True Negatives (TN) ve False Positives (FP) hesapla

TN = sum((gercek == 0 and tahmin == 0) for gercek, tahmin in zip(gercek_etiketler, tahminler)) 
FP = sum((gercek == 0 and tahmin == 1) for gercek, tahmin in zip(gercek_etiketler, tahminler)) 


# Specificity (Özgüllük) hesapla

specificity = TN / (TN + FP)

print("Specificity (Ozgulluk):", specificity) 