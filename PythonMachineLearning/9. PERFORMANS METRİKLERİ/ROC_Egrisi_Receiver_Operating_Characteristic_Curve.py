from sklearn.metrics import roc_curve, roc_auc_score

import matplotlib.pyplot as plt

# Gerçek siniflar ve tahmin edilen olasiliklar

gercek_siniflar = [1, 0, 1, 1, 0, 0, 1, 0, 1, 0]

tahmin_olasiliklari = (0.8, 0.3, 0.6, 0.9, 0.2, 0.1, 0.7, 0.4, 0.8, 0.3) 


# ROC eğrisini ve AUC'yl hesapla

fpr, tpr, thresholds = roc_curve(gercek_siniflar, tahmin_olasiliklari) 
auc = roc_auc_score(gercek_siniflar, tahmin_olasiliklari)

# ROC eğrisini çiz

plt.figure 