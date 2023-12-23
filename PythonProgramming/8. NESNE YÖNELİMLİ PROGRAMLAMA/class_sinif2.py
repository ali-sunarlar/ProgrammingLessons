# Araba Sinifi tanimlama 
class Arac: 
    "Bir araç sinifi tanimlanmasi" 
    # sinif nitelikleri 
    tekerlek_sayisi = 4 
    def __init__ (self, model, marka, tur): 
            self.model = model 
            self.marka = marka 
            self.tur = tur 
        #metotlarin tanimlanmasi 
    def vitese_al(self, vites): 
        return "() {}. vitese alindi".format(self.marka, vites) 
    def hizlan(self): return "{} Araç hizlandi".format(self.marka) 
    def yavasla(self): return "Araç yavaşladi" 


# Araç sinifindan nesnelerin turetilmesi 
bmw = Arac(2020, "BMW", "Sedan") 
mercedes = Arac(2021,"Mercedes", "Sedan") 
# sinif niteliklerine erişmek 
print("BMW'nin {} tekerleği bulunmakta".format(bmw.__class__.tekerlek_sayisi)) 
print("Mercedes'in {} tekerleği bulunmakta".format(mercedes.tekerlek_sayisi)) 
# Türetilmiş nesnenin nitelikleri 
print("{} {} model ve {} 'dir".format( bmw.marka, bmw.model,bmw.tur)) 
print("{} {} model ve {} 'dir".format( mercedes.marka, mercedes.model,mercedes.tur)) 

# metotların çarılması 
print(bmw.vitese_al("1")) 
print(bmw.yavasla()) 
print(bmw.hizlan()) 