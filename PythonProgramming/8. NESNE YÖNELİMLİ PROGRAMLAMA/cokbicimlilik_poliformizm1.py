class Personel: 
    def zam(self): 
        zam_oran = 0.1 
        hesap = 100 + 100 * zam_oran 
        print("Eleman: ", hesap, "TL") 
class Doktor (Personel): 
    def zam(self): 
        zam_oran = 0.2 
        hesap = 100 + 100 * zam_oran 
        print("Doktor: ", hesap, "TL") 
class Hakim(Personel): 
    def zam(self): 
        zam_oran = 0.3 
        hesap = 100 + 100 * zam_oran 
        print("Hakim: ", hesap, "TL") 

personel = Personel() 
doktor_zam = Doktor() 
hakim_zam = Hakim() 
personel_listesi = (doktor_zam, hakim_zam) 
for eleman in personel_listesi: 
    eleman.zam() 