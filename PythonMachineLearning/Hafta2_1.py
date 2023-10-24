# Gerekli kitlphanelerin ylklenmesi

from sklearn import datasets 
from sklearn.model_selection import train_test_split 
from sklearn.preprocessing import StandardScaler 
from sklearn.svm import SVC

# Veri setinin yiiklenmesi
iris = datasets.load_iris()
X = iris.data
y = iris.target

# Veri setinin egitim ve test olarak bollinmesi 
X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=0.3, random_state=42) 
# Veri normallestirme

sc = StandardScaler()
X_train_std = sc.fit_transform(X_train)
X_test_std = sc.transform(X_test)

# SVM modelinin olusturulmasi

svm = SVC(kernel='linear', C=1.0, random_state=42) 
svm.fit(X_train_std, y_train)

# Modelin test verisi tizerinde degerlendirilmesi 
accuracy = svm.score(X_test_std, y_test) 
print(f"Model Dogrulugu: {accuracy * 100:.2f}%") 