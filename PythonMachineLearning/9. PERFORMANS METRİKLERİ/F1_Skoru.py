"""F1 skoru, bir siniflandirma modelinin kesinlik (precision) ve
duyarlilik (recall) metriklerinin harmonik ortalamasidir. Bu metrik, modelin yanliş pozitifler ve yanliş negatifler
arasindaki dengeyi sağlar. """

from sklearn.metrics import f1_score

# Gergek etiketler ve model tahminleri

gercek_etiketler = [1, 0, 1, 1, 0, 1, 0, 0, 1] 
tahminler = [1, 0, 1, 1, 0, 0, 1, 1, 1]

# Duyarlilik hesapla

f1skoru = f1_score(gercek_etiketler, tahminler) 
print("F1 Skoru (F1 Score):", f1skoru) 