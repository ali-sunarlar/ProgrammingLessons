#!/usr/bin/env python
# coding: utf-8

# In[1]:


import matplotlib.pyplot as plt                         #veriyi gorsellestirmek icin
import pandas as pd                                     #verisetini diziye donusturme icin
import seaborn as sns                                   #Grafik cizimi kolerasyon matrisi icin
from sklearn.neighbors import KNeighborsClassifier      #K-nn algoritmasini kullanmak icin
from sklearn.svm import SVC                             #SVM algoritmasi kullanmak icin

from sklearn.model_selection import train_test_split    #veriti egitim ve test gruplarina bolmek icin
from sklearn.metrics import accuracy_score              #agin performans metrigi icin dogruluk skoru

from sklearn.metrics import confusion_matrix            #agin dogru ve yanlis bulma matrisi
from sklearn.metrics import precision_score             #agin basari metrikleri
from sklearn.metrics import recall_score,f1_score       #agin basari metrikleri
from sklearn.metrics import classification_report       #agin basari metrikleri

import warnings
warnings.filterwarnings("ignore")                       #kod icinde kutuphane hatalarini gostermemesi icin


# In[2]:


df=pd.read_csv('lenf.csv',delimiter=';')
df


# In[3]:


df.info()


# In[4]:


df.corr()


# In[7]:


description=df.describe()
print(description)


# In[9]:


plt.figure(figsize=(16,5))
sns.heatmap(df.corr(),annot=True, vmin=0, vmax=1, center=True, linewidths=2)


# In[27]:


def svm(X_train, y_train, X_test, y_test):
    svm=SVC(kernel='linear', c=100.0, random_state=35)
    svm.fit(X_train,y_train)
    y_pred=svm.predict(X_test)
    
    print_states_percentage_train_test(svm,y_test,y_pred)
    
    cnf_matrix=confusion_matrix(y_test,y_pred)
    cnf_matrix_t=cnf_matrix.astype(int)
    sns.heatmap(cnf_matrix_t,annot=True,fmt=".0f")
    
    return

svm(X_train_std,y_train,X_test_std,y_test)


# In[26]:


svm(X_train_std,y_train,X_test_std,y_test)


# In[22]:


def gnb(X_train, y_train, X_test, y_test):
    gnb=GaussianNB(priors=None, var_smoothing=1e-02)
    gnb.fit(X_train,y_train)
    y_pred=gnb.predict(X_test)
    
    print_states_percentage_train_test(svm,y_test,y_pred)
    
    cnf_matrix=confusion_matrix(y_test,y_pred)
    cnf_matrix_t=cnf_matrix.astype(int)
    sns.heatmap(cnf_matrix_t,annot=True,fmt=".0f")
    
    return

gnb(X_train,y_train,X_test,y_test)


# In[23]:


gnb(X_train,y_train,X_test,y_test)


# In[ ]:




