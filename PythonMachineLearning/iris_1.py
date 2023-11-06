
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

df=pd.read_csv('iris_data.csv',delimiter=';')
df.info()

