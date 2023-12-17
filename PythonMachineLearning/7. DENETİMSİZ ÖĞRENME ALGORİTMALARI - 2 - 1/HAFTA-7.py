import pandas as pd # Verilerin array'a dönüştürülmesi

from mlxtend.frequent_patterns import apriori # Apriori algoritmasi kütüphanesi

from mlxtend.preprocessing import TransactionEncoder # Verilerin True-False arrayimi dönüştürmede 
from mlxtend.frequent_patterns import association_rules # Veriler arasindaki ilişki metrikleri 

import warnings
warnings.filterwarnings("ignore") # Kod içinde kütüphane hatalarimi göstermemesi 

df = pd.read_csv("sepet.csv", names=['products'], header = None, encoding="ISO-8859-1") #dataframe olusturuluyor
df 
print(df)

print(df.shape)

print(df.columns)

print(df.values) #array olarak listelenir

data = list(df["products"].apply(lambda x:x.split(';'))) #array data frame'i ayriliyor
print(data) 

# TronsoctionEncoded bize istediğimiz True-Folse arroyini dönüştürmede yardimci oluyor. 
te = TransactionEncoder()

te_data = te.fit(data).transform(data)

df = pd.DataFrame(te_data, columns = te.columns_ ) 
print(df) 

df1 = apriori(df, min_support=0.02, use_colnames = True, verbose=1) #support degerleri bulunuyor
print(df1) 

# Satilan ürünlerin birbiri (le {liskileri {cin metrikler ve eşik belirleme 
association_rules(df1, metric = "confidence", min_threshold = 0.6) 


"""antecedent support : Birincinin tek başima görülme olasiliği,

consequent support : İkimcinin tek başima görülme olasiliği,

support : İkisinin birlikte görülme olasiliği,

confidence : İlki satildiğinda ikinci Ürünün satilma olasiliği,

1ift : İlki satildiğinda ikinci ürünün satilma olasiliği su kadar kat artti yorumu yapilir. """

rules = association_rules(df1, metric = "confidence", min_threshold = 0.6) 
rules[(rules['confidence'] >= 0.8) & (rules['support'] >= 0.2) & (rules['lift'] >= 1.0)]


"""yapilan analize göre şu yorum raporlanabilir:
§ Alişverişlerde KOLA'nin tek başina görülme olasiliği %22, BEBEK BEZİ'nin tek başina görülme olasiliği
%44 (antecedent support ve consequent support verilerine göre yorumlandi).
§ 100 alişverişin 22'sinde mutlaka KOLA ve BEBEK BEZİ beraber satin aliniyor (destek-support bilgisine göre
yorumlandi).
§ KOLA satildiğinda BEBEK BEZİ satilma olasiliği 1.0 olup yani %100 (güven-confidence bilgisine göre
yorumlandi).
§ KOLA satilan satişlarda BEBEK BEZİ satilma olasiliği 2.25 kat artmaktadir (lift bilgisine göre yorumlandi).
Yapilan sorgu değiştirilerek farkli analizler yapilabileceği gibi önceki analizden farkli ürünler için de benzer
raporlamalar ortaya konulabilir.
Bu çalişmadan sonuç olarak anlamli bilgi çikarmak için:
§ KOLA alan biri %100 gibi yüksek bir ihtimalle BEBEK BEZİ almaktadir ve BEBEK BEZİ satişini 2.28
artirmaktadir.
§ Bu iki ürün birbirinden uzak yerlerde konumlandirilarak müşterinin market içi dolaşmasi sağlanabilir.
§ Bu süreçte müşteri diğer ürünlere göz atabilir ve yahut satin alabilir"""


