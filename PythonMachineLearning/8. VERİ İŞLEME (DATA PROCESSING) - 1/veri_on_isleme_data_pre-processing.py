#Kutuphanelerin Yuklenmesi

import pandas as pd

from sklearn.datasets import load_iris

from sklearn.model_selection import train_test_split

from sklearn.preprocessing import StandardScaler, MinMaxScaler, OneHotEncoder

from sklearn.impute import SimpleImputer

import warnings

warnings.filterwarnings ("ignore") # Kod içinde kütüphane hatalarımı göstermemesi icin 

#Verilerin Yuklenmesi, Secimi ve Split Islemi

# Veriyi yükleyelim

iris = load_iris()

X = pd.DataFrame(iris.data, columns=iris.feature_names)

y = iris.target

# Örnek olarak bazı eksik veriler ekleyelim

X.iloc[5:10, 1] = None

X.iloc[15:20, 2] = None

# Veriyi egitim ve test setlerine ayıralım

X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=0.2, random_state=42) 

print(X_train)

#Eksik Verileri Doldurma
# Eksik veri doldurma

imputer = SimpleImputer(strategy='mean') #ortalamasi aliniyor

X_train = pd.DataFrame(imputer.fit_transform(X_train), columns=X_train.columns) 
X_test = pd.DataFrame(imputer.transform(X_test), columns=X_test.columns) 

#Ozellik Olceklendirme(Normalizasyon-Standartlastirma)

# Özellik ölçeklendirme: Normalizasyon veya Standartlastirma

scaler = StandardScaler()

X_train = pd.DataFrame(scaler.fit_transform(X_train), columns=X_train.columns) 
X_test = pd.DataFrame(scaler.transform(X_test), columns=X_test.columns) 

#Model Icin Diger On Islemler

# Kategorik özellikleri one-hot encoding ile dönüştürme (Iris veri setinde bu gerekli değildir, ama genel bir örnek # encoder = ÖnekotEncoder()

# X_train_encoded = encoder. fit_transform(X_train[[ "categorical_feature']])

# X_test_encoded = encoder. transform(X_test[[ ‘categorical_feature']])

# X train = pd.concat([X_train, pd.Dataframe(X train encoded.toarray(), index=X_train.index)], axisel)

# X test = pd.concat([X_test, pd.DataFrame(X_test_encoded. toarray(), index=X_test.index)], axis=1)

# X_train.drop([ "categorical _feature'], axis=1, inploce=True)

# X_test.drop([ ‘categoricol_feature'], axis=l, inploce=True)

print (X_train.head()) 

