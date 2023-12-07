# -*- coding: utf-8 -*-
#1.kutuphaneler
import numpy as np
import matplotlib.pyplot as plt
import pandas as pd

#2.veri onisleme
#2.1.veri yukleme
veriler = pd.read_csv('eksikveriler.csv')
#pd.read_csv("veriler.csv")
#test
print(veriler)

#veri on isleme

#boy = veriler[['boy']]
#print(boy)

#boykilo = veriler[['boy','kilo']]
#print(boykilo)


#eksik veriler
#sci - kit learn

#impute eksik veriler icin
from sklearn.impute import SimpleImputer

imputer = SimpleImputer(missing_values=np.nan, strategy='mean')

#kategorik verilerden encoding cevirme islemi
Yas = veriler.iloc[:,1:4].values
print("Yas\n",Yas)
imputer = imputer.fit(Yas[:,1:4])
Yas[:,1:4] = imputer.transform(Yas[:,1:4])
print("Yas2\n",Yas)

ulke = veriler.iloc[:,0:1].values
print("ulke1\n",ulke)

from sklearn import preprocessing

#
le = preprocessing.LabelEncoder()

ulke[:,0] = le.fit_transform(veriler.iloc[:,0])

print("ulke2\n",ulke)

#kolon basliklarini etiket basliklarina tasimak 1 veya 0 koymak
ohe = preprocessing.OneHotEncoder()
ulke = ohe.fit_transform(ulke).toarray()
print("ulke3\n",ulke)

print(list(range(22))) #range satir sayisi kadar index olmasi saglanir
sonuc = pd.DataFrame(data=ulke, index = range(22), columns = ['fr','tr','us']) #dataframe'lerin index'i ve kolon basliklarini vardir. #dataframe'den dizilerden farki da budur.  
print("Ulke sonuc\n",sonuc)

sonuc2 = pd.DataFrame(data=Yas, index = range(22), columns = ['boy','kilo','yas'])
print("Yas sonuc2\n",sonuc2)

cinsiyet = veriler.iloc[:,-1].values
print("cinsiyet\n",cinsiyet)

sonuc3 = pd.DataFrame(data = cinsiyet, index = range(22), columns = ['cinsiyet'])
print("Cinsiyet sonuc3\n",sonuc3)

#dataframe'leri birlestirme
#concat fonksiyonu birlestirme saglar
s=pd.concat([sonuc,sonuc2], axis=1)
print("s\n",s)

s2=pd.concat([s,sonuc3], axis=1)
print("s2\n",s2)


#verilerin egitim ve test icin bolunmesi
from sklearn.model_selection import train_test_split

x_train, x_test,y_train,y_test = train_test_split(s,sonuc3,test_size=0.33, random_state=0)

#verilerin olceklenmesi
from sklearn.preprocessing import StandardScaler

sc=StandardScaler()

X_train = sc.fit_transform(x_train)
X_test = sc.fit_transform(x_test)










