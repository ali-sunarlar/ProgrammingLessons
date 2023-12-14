# Burada ihtiyaç duyulan kütüphaneleri ekliyoruz. Lo BELDE Gr BL. | import matplotlib.pyplot as plt # veriyi görselleştirmek için

from matplotlib import pyplot as plt
import pandas as pd # verisetini diziye dönüştürme

import seaborn as sns # Grafik çizimi kolerasyon matrisi için

from sklearn.cluster import KMeans # K-Means algoritmasını kullanmak için

from sklearn.model_selection import train_test_split # veriti eğitim ve test gruplarına bölmek için 

from sklearn.metrics import accuracy_score # ağın performans metriği için doğruluk skoru

from sklearn.metrics import confusion_matrix # ağın doğru ve yanlış bulma matrisi

from sklearn.metrics import precision_score # ağın başarı metrikleri

from sklearn.metrics import recall_score, f1_score # ağın başarı metrikleri

from sklearn.metrics import classification_report # ağın başarı metrikleri

import warnings

warnings. filterwarnings ("ignore") # Kod içinde kütüphane hatalarımı göstermemesi icin 

df=pd.read_csv('lenf.csv',delimiter=';')
df

df.info()

description=df.describe()
print(description)

df.corr()

plt.figure(figsize=(16,5))
sns.heatmap(df.corr(),annot=True,vmin=0,vmax=1,center=True,linewidths=2)

plt.Figure(figsize=(3,3))
df['Y1'].value_counts().plot(kind='pie', textprops={ 'color': 'black' }, autopct='%.2f' ,cmap='cool')
plt.title( 'Output Label' ,fontsize=15)

plt.legend([ 'Var', 'Yok'])

plt.show() # Burada veri setindeki çıkış verisinin görsel dodiliminmt görüyoruz. 

## 80% egitim and 20% test 
X_train, X_test, y_train, y_test = train_test_split(df, target, test_size=0.30, random_state=0)

print ("eğitim verileri :" , X_train.shape) 
print ("Eğitim Etiketleri :" , y_train.shape) 
print("Test Verileri:", X_test.shape) 
print("Test Etiketleri: ", y_test.shape) 

# K-Means Algoritması Alt Fonksiyonu

def kmean(X_train, y_train, X_test, y_test): 
    km = KMeans(n_clusters = 2, init="random", n_init=22, max_iter=560, random_state=35) 
    km.fit(X_train, y_train) 
    y_pred = km.predict(X_test) 
    print_stats_percentage_train_test(km, y_test, y_pred) 
    cnf_matrix = confusion_matrix(y_test, y_pred) 
    cnf_matrix_t = cnf_matrix.astype(int) 
    sns.heatmap(cnf_matrix_t, annot=True, fmt=".0f") 
    plt.close() 
    
    return

#8 Bir alt fonksiyon {le makine öğrenmesi olgoritmalorimn metriklerint yozdurwok. Br Vv a 
def print_stats_percentage_train_test(algorithm_name, y_test, y_pred): 
    print("---------------------------------------------------")
    print ("algorith is; ", algorithm_name)
    print("---------------------------------------------------")
    acc = accuracy_score(y_test, y_pred) 
    print("Accuracy: %.3f" % acc) 
    print("train score: %.2f" % algorithm_name.score(X_train,y_train)) 
    print("test score: %.2f" % algorithm_name.score(X_test, y_test))
    print("---------------------------------------------------")
    confmat = confusion_matrix(y_true=y_test, y_pred=y_pred, ) 
    print ("confusion matrix") 
    print (confmat)
    print("---------------------------------------------------")
    print ("Precislon: %.3f" % precision_score(y_true=y_test, y_pred=y_pred, average='welghted')) 
    print("Recall; %.3f" % recall_score(y_true=y_test, y_pred= y_pred,average='veighted')) 
    print ("F1-messure: %.3f" % f1_score(y_true=y_test, y_pred= y_pred,average="weighted" )) 
    print("---------------------------------------------------")

     
    report = classification_report(y_true=y_test, y_pred=y_pred) 
    print(f' Classification Report:\n{report}') 
    print('Clessificotion Report: X.3f' % classification_report(y_true=y_test, y_pred= y_pred)) 
    print("---------------------------------------------------")
    
    return 

# Makine öğrenmesi - K-Means Algoritması 
kmean(X_train, y_train, X_test, y_test) 

 