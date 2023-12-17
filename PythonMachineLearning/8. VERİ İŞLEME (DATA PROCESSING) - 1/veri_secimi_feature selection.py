#Kutuphanlerin Yuklenmesi

import pandas as pd

from sklearn.datasets import load_iris

from sklearn.ensemble import RandomForestClassifier 

from sklearn.model_selection import train_test_split 

#Verilerin Yuklenmesi ve Split Islemi

# Veriyi yükleyelim

iris = load_iris()

X = iris.data

y = iris. target

# Veriyi egitim ve test setlerine ayıralım

X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=0.2, random_state=42) 

#Makine Ogrenmesi Modelinin Egitimi

# Rastgele Orman modelini egitelim 
clf = RandomForestClassifier(n_estimators=100, random_state=42) 
clf.fit(X_train, y_train)


#Onemli Ozelliklerin Secimi

# Özelliklerin önemini alalım 
feature_importances = clf.feature_importances_ 
# Özelliklerin önemini bir DataFrame'e ekleyip sıralayalım 
features_df = pd.DataFrame({ 
                            'Feature': iris.feature_names,
                            'Importance': feature_importances
})
features_df = features_df.sort_values(by='Importance', ascending=False) 

# En önemli özellikleri gösterelim 
print(features_df) 

# Örneğin, en önemli 2 özelliği seçmek istiyorsanız: 
top_features = features_df["Feature"].head(2).tolist() 
print("\nEn önemli 2 özellik:", top_features) 