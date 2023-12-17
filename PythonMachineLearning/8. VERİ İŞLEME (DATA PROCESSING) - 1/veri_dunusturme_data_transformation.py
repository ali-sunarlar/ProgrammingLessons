#Kutuphanalerin Yuklenmesi

import pandas as pd

import numpy as np

from sklearn.datasets import load_iris

from sklearn.preprocessing import PolynomialFeatures, PowerTransformer, QuantileTransformer, FunctionTransformer 

from sklearn.model_selection import train_test_split

import warnings

warnings.filterwarnings ("ignore") # Kod içinde kütüphane hatalarımı göstermemesi icin 

#Verilerin yuklenmesi, secimi ve split Islemi

# Veriyi yükleyelim

iris = load_iris()

X = pd.DataFrame(iris.data, columns=iris.feature_names)

y = iris.target

# Veriyi eğitim ve test setlerine ayıralım

X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=0.2, random_state=42) 



# Polinom özellikler oluşturma

poly = PolynomialFeatures(degree=2, include_bias=False) 
X_train_poly = poly.fit_transform(X_train)
X_test_poly = poly.transform(X_test) 

# Log dönüşümü veri dağılımının normallesmesine yardımcı olabilir (Pozitif değerler icin...). 
log_transformer = FunctionTransformer(func=np.log1p, inverse_func=np.expm1, validate=True)

X_train_log = log_transformer.transform(X_train)

X_test_log = log_transformer.transform(X_test) 


#Box-Cox veya Yeo-Johnson Donusumu (PowerTransformer)

# Veri dağılımmı daha normal hale getirir.

pt = PowerTransformer(method='yeo-johnson', standardize=True) 
X_train_pt = pt.fit_transform(X_train)
X_test_pt = pt.transform(X_test) 

#Kuantim Donusumu

# Özellikleri belirli bir kuantil dağılımına (örn. uniform veya normal) dönüştürür

qt = QuantileTransformer(n_quantiles=100, random_state=42, output_distribution= 'uniform')
X_train_gt = qt.fit_transform(X_train)

X_test_qt = qt.transform(X_test)

print(X_train_poly[0])

#Sonuc olarak veri satirlarini uygun dagilim ile yeniden olusturuluyor

