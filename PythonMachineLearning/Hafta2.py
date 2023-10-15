#!/usr/bin/env python
# coding: utf-8

# In[16]:


# ! pip install TensorFlow
# ! yaparak komutlar çalıştırabilir
get_ipython().system(' pip install --trusted-host pypi.org --trusted-host files.pythonhosted.org TensorFlow')


# In[3]:


import math

print (math.sqrt(16)) # Karekök alır.


# In[4]:


import datetime

zaman_bilgisi = datetime.datetime.now()

print(zaman_bilgisi)
#datetime: Tarih ve saat işlemleri için kullanılır.


# In[9]:


#Pandas: Veri analizi ve manipülasyonu için en popüler kütüphanedir. Veri çerçeveleri oluşturma, veriyi temizleme, farklı veri kaynaklarından veri yükleme gibi işlemleri kolaylaştırır.
#Görselleştirmelerin özelleştirilebilir olması ve detaylı grafikler oluşturma yeteneği ile popülerdir.

# ! pip install --trusted-host pypi.org --trusted-host files.pythonhosted.org pandas

import matplotlib.pyplot as plt

plt.plot([1, 2, 3], [1, 4, 9])

plt.show()


# In[5]:


# ! pip install --trusted-host pypi.org --trusted-host files.pythonhosted.org numpy

#NumPy: Bilimsel hesaplamalar için temel pakettir. Büyük, çok boyutlu diziler ve matrisler üzerinde çalışma yeteneği ile bilinir. 
#Ayrıca bu diziler üzerinde matematiksel işlem yapmak için geniş bir fonksiyon koleksiyonuna sahiptir. Hızlı ve verimli hesaplamalar için optimize edilmiştir.

import numpy as np

dizi = np.array([1, 2, 3, 4])

print(dizi)
#


# In[18]:


#Scikit-learn (sklearn): Makine öğrenimi algoritmalarını içeren bir kütüphanedir. Sınıflandırma, regresyon, 
#kümeleme gibi birçok algoritmayı barındırır. Ayrıca veri madenciliği ve veri analizi için de kullanılır. Kullanıcı dostu arayüzü ve geniş dokümantasyonu ile bilinir. 
#Aşağıda verilen kod sadece algoritmik anlama açısından verilmiş olup kodun işlem detayları ileri bölümlerde ayrıntılı bir şekilde anlatılacaktır.
# kütüphaneyi projeye dahil etme

# ! pip install --trusted-host pypi.org --trusted-host files.pythonhosted.org scikit-learn

from sklearn.linear_model import KNeighborsClassifier()

from sklearn.model_selection import train_test_split

#veri yükleme

df = pd.read_csv(ornek.csv', delimiter=';')

#veri hazırlama – detaylar ileriki bölümlerde verilecektir.

train, X_test, y_train, y_test = train_test_split(df, target, test_size=0.20, random_state=0)

#model oluşturma

knn = KNeighborsClassifier()

#model eğitimi

knn.fit(X_train, y_train)

#modeli test etme

y_pred = knn.predict(X_test)

#modelin performans skorunu belirleme

knn_acc = accuracy_score(y_test, y_pred)


# In[19]:


#TensorFlow ve Keras: Derin öğrenme modelleri oluşturmak için kullanılır. 
#TensorFlow, Google tarafından geliştirilmiştir ve büyük veri setleriyle çalışabilme yeteneği ile bilinir. 
#Keras ise TensorFlow'un üzerine inşa edilmiş, derin öğrenme modellerini daha hızlı ve kolay bir şekilde oluşturmayı sağlayan bir arayüzdür. 
#Aşağıda verilen kod sadece algoritmik anlama açısından verilmiş olup kodun işlem detayları ileri bölümlerde ayrıntılı bir şekilde anlatılacaktır.

get_ipython().system(' pip install --trusted-host pypi.org --trusted-host files.pythonhosted.org tensorflow')

get_ipython().system(' pip install --trusted-host pypi.org --trusted-host files.pythonhosted.org keras')

import tensorflow as tf

# Örnek veri

x_train = [1, 2, 3, 4]

y_train = [0, -1, -2, -3]

# Model parametreleri

W = tf.Variable([0.], dtype=tf.float32)

b = tf.Variable([0.], dtype=tf.float32)

# Modelin tanımı

def linear_model(x):

return x * W + b

# Hata fonksiyonu (loss)

def loss(predicted_y, desired_y):

return tf.reduce_sum(tf.square(predicted_y - desired_y))

# Optimizasyon (SGD - Stochastic Gradient Descent)

optimizer = tf.optimizers.SGD(learning_rate=0.01)

# Eğitim döngüsü

for i in range(1000):

with tf.GradientTape() as tape:

current_loss = loss(linear_model(x_train), y_train)

grads = tape.gradient(current_loss, [W, b])

optimizer.apply_gradients(zip(grads, [W, b]))

# Sonuçları ekrana yazdırma

print(f"W: {W.numpy()}, b: {b.numpy()}")


# In[20]:


#NLTK: Doğal dil işleme (NLP) projeleri için oluşturulmuş bir kütüphanedir. 
#Metin madenciliği, metin analizi ve dil işleme görevleri için geniş bir araç ve İngilizce dilindeki metinler için büyük miktarda veritabanı ve kaynak içerir.
import nltk

from nltk.tokenize import word_tokenize

from nltk.probability import FreqDist

# Örnek metin

text = "Doğal dil işleme için örnek metin girişi buraya yazılır."

# Kelimelere ayırma (tokenization)

tokens = word_tokenize(text)

# Sıklık dağılımını hesaplama

fdist = FreqDist(tokens)

# En yaygın 5 kelimeyi yazdırma

print(fdist.most_common(5))


# In[14]:


#Aşağıda verilen örnekte scikit-learn kütüphanesi kullanılarak basit bir SVM uygulamasını göstermektedir. 
#Uygulamanın karmaşıklığına bağlı olarak bu işlem adımları genişletebilir veya özelleştirebilir.
# Gerekli kütüphanelerin yüklenmesi

from sklearn import datasets

from sklearn.model_selection import train_test_split

from sklearn.preprocessing import StandardScaler

from sklearn.svm import SVC

# Veri setinin yüklenmesi

iris = datasets.load_iris()

X = iris.data

y = iris.target

# Veri setinin eğitim ve test olarak bölünmesi

X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=0.3, random_state=42)

# Veri normalleştirme

sc = StandardScaler()

X_train_std = sc.fit_transform(X_train)

X_test_std = sc.transform(X_test)

# SVM modelinin oluşturulması

svm = SVC(kernel='linear', C=1.0, random_state=42)

svm.fit(X_train_std, y_train)

# Modelin test verisi üzerinde değerlendirilmesi

accuracy = svm.score(X_test_std, y_test)

print(f"Model Doğruluğu: {accuracy * 100:.2f}%")


# In[ ]:




