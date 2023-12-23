class Ogrenciler:
    def __init__(self, ad, soyad, ogrenci_no,bolum):
        self.__ad = ad #Dis dunyadan gizlendi
        self.__soyad = soyad #Dis dunyadan gizlendi
        self.__ogrenci_no = ogrenci_no #Dis dunyadan gizlendi
        self.bolum = bolum 
    def bilgilere_ulas(self):
        print("Adi:{}\n Soyadi:{}\n Ogrenci Numarasi:{} \nBolum:{}" \
              .format(self.__ad,self.__soyad,self.__ogrenci_no,self.bolum))
        

ogrenci_1 = Ogrenciler("Ahmet","Caliskan", "260002001" , "Enformatik") 

ogrenci_1.bilgilere_ulas()


#Bu nitelige ulasilir       
print(ogrenci_1.bolum) 
#Burdan sonrasina ulasilamaz
print(ogrenci_1.ad) 
print(ogrenci_1.soyad) 
print(ogrenci_1.ogrenci_no) 