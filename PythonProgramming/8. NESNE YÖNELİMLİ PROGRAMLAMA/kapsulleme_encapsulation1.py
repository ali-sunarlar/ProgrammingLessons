class Ogrenciler: 
    def __init__(self, ad, soyad, ogrenci_no,bolum) : 
        self.ad = ad 
        self.soyad = soyad 
        self.ogrenci_no = ogrenci_no 
        self.bolum = bolum 
        
        
        
ogrenci_1 = Ogrenciler("Ahmet","Caliskan", "260002001" , "Enformatik") 
print (ogrenci_1.ad) 
print (ogrenci_1.soyad) 
print(ogrenci_1.ogrenci_no) 
print(ogrenci_1.bolum) 

ogrenci_1.ad = "Veli" 
print (ogrenci_1.ad) 
print (ogrenci_1.soyad) 
print(ogrenci_1.ogrenci_no) 
print (ogrenci_1.bolum) 