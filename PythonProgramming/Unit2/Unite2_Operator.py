# Operatör      # Açıklama
# ()            # Parantezler
# **            # Üs alma
# +x, -x, ~x    # Birli Artı, Birli eksi, Bitsel değil
# *,/,//,%      # Çarpma, Bölme, Tam bölme, Bölümden kalan( mod)
# +,-           # Toplama, Çıkarma  
# # <<,>>       # Sola kaydır, Sağa kaydır
# &             # Bitsel ve
# ^             # Bitsel XOR
# |             # Bitsel veya
# ==,!=,>,      # Karşılaştırma
# >=,<,<=       # Karşılaştırma
# is,is not,    # Kimlik ve üyelik operatörleri
# in,not in     # Kimlik ve üyelik operatörleri
# not           # Mantıksal değil
# and           # Mantıksal ve
# or            # Mantıksal veya


a=10
b=20
c=15
d=8

#islem oncelikleri ornekleri
e=(a+b)*c/d
print("({}+{})*{}/{}={}".format(a,b,c,d,e))
e=(a+b*c)/d
print("({}+{}*{})/{}={}".format(a,b,c,d,e))
e=a+b*c/d
print("({}+{}*{}/{})={}".format(a,b,c,d,e))


