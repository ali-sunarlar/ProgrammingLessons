#!/usr/bin/env python
# coding: utf-8

# In[48]:


import matplotlib.pyplot as plt                         #veriyi gorsellestirmek icin
import pandas as pd                                     #verisetini diziye donusturme icin
import seaborn as sns                                   #Grafik cizimi kolerasyon matrisi icin
from sklearn.neighbors import KNeighborsClassifier      #K-nn algoritmasini kullanmak icin

from sklearn.model_selection import train_test_split    #veriti egitim ve test gruplarina bolmek icin
from sklearn.metrics import accuracy_score              #agin performans metrigi icin dogruluk skoru

from sklearn.metrics import confusion_matrix            #agin dogru ve yanlis bulma matrisi
from sklearn.metrics import precision_score             #agin basari metrikleri
from sklearn.metrics import recall_score,f1_score       #agin basari metrikleri
from sklearn.metrics import classification_report       #agin basari metrikleri

import warnings
warnings.filterwarnings("ignore")                       #kod icinde kutuphane hatalarini gostermemesi icin


# In[49]:


df=pd.read_csv('lenf.csv',delimiter=';')
df


# In[50]:


df.info() #dataframe'nin infosu pandas kütüphanesinin özelliği
#null yok #tamami sayisal veri #calisabilir durumda


# In[51]:


description=df.describe() #tarif et kaç adet ortalama % yuzdeleri maksimum minimum 
print(description)


# In[52]:


df.corr() #sutunlarin birbiri ile iliskileri eger - eksi ise zıt iliski #modelde boyut azaltma
#X1 olmadan hangi veriler kullanılırsa Y'yi tahminleme #hangi veriler olmadan Y doğru tahmin edilebilir cevabi aranir 


# In[53]:


plt.figure(figsize=(16,5))       #1 en yuksek iliski 0 en dusuk iliski #hangi ozelliklerimin oncellikli #eger bir model kurgulanacaksa Y ile en yuksek iliskili degerlerle siniflandirma olusturabilir
sns.heatmap(df.corr(),annot=True, vmin=0, vmax=1,center=True, linewidths=2)


# In[54]:


plt.figure(figsize=(3,3))
df['Y1'].value_counts().plot(kind='pie',textprops={'color':'black'},autopct='%.2f',cmap='cool') #plot cizdir demektir. 
plt.title('Output Label',fontsize=15)
plt.legend(['Var','Yok'])
plt.show()     #Burada veri setindeki cikis verisinin gorsel dagilimini goruyoruz.


# In[79]:


#%80 egitim and %20 test #random_state bölme isleminde karistirma islemi yapar 0'sa karistirma islemi yapmaz ornegin 1,3 se 1 ile 3 yerlerini degistirir
X_train,X_test,y_train,y_test =train_test_split(df,test_size=0.01,random_state=0)


# In[56]:


X_Train


# In[60]:


y_train


# In[63]:


print("Egitim Verileri : ", x_train.shape)
print("Egitim Etiketleri :",y_train.shape)
print("Test Verileri : ", x_test.shape)
print("Test Etiketleri : ", y_test.shape)


# In[72]:


def knn(x_train,y_train,x_test,y_test):
    knn=KneighborsClassifier(n_neighbors=3,metrix="minkowski",p=1)
    knn.fit(x_train,y_train)
    
    y_pred=knn.predict(X_test)
    print_stats_percentage_train_test(knn,y_yest,y_ped)
    
    cnf_matrix=confusion_matrix(y_test,y_ped)
    cnf_matrix_t=cnf_matrix.astype(int)
    sns.heatmap(cnf_matrix_t,annot=True, fmt=".0f")
                
    return


# In[77]:


#Bir alt fonksiyon ile makine öğrenmesi algoritmalarinin yazdirmak

def print_stats_percentrage_train_test(algorithm_name,y_test,y_pred):
    print("----------------------------------------------------------")
    print("algorithm is : ", algorithm_name)
    print("----------------------------------------------------------")
    acc=accuracy_score(y_test,y_pred)
    print('Accuracy : %.3f' %acc)
    print('train_score : %.2f'%algorithm_name.score(x_train,y_train))
    print('train_score : %.2f'%algorithm_name.score(x_test,y_test))
    print("----------------------------------------------------------")
    confmat=confusion_matrix(y_true=y_test, y_pred=y_ped,)
    print("confusion matrix")
    print(confmat)
    print("----------------------------------------------------------")
    print('Precision: %.3f'%precision_score(y_true=y_test,y_pred=y_pred, avreage='weighted'))
    print('Recall: %.3f'%precision_score(y_true=y_test,y_pred=y_pred, avreage='weighted'))
    print('F1-measure: %.3f'%precision_score(y_true=y_test,y_pred=y_pred, avreage='weighted'))
    print("----------------------------------------------------------")
    
    report=classification_report(y_true=y_test, y_pred=y_pred)
    print(f'Classification Report: \n{report}')
    
    print("----------------------------------------------------------")
    return


# In[78]:


knn(x_train,y_train,x_test,y_test)


# In[ ]:




