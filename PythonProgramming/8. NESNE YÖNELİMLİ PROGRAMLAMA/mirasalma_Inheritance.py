class Cokgen: 
    def _init_(self, kenar_sayisi): 
        self.n = kenar_sayisi 
        self.kenar = [0 for i in range(kenar_sayisi)] 
    def kenar_uzunlarini_al (self): 
        self.kenar = [float(input(str(1+1)+".kenarin uzunluğu : ")) for i in range(self.n)] 
    def kenar_uzunlugunu_goster (self): 
        for i in range(self.n): 
            print(i+1,". kenarin uzungu ",self.kenar[i]) 

##class Ucgen(Cokgen) : 
  ##  def init (self): 
        #Cokgen: init__(self, 3) #3 kenarli bir cokgen oluştur 
    ##    super (). __init__ (3) 

class Ucgen(Cokgen): 
    def _init_(self):
        super (). __init__ (3)  
        Cokgen._init_(self,3) #3 kenarli bir cokgen oluştur 
    def alani_hesapla(self): 
        a,b,c = self.kenar 
    #'yari çevreyi hesaplamak 
        s=(a+b+c)/2 
        alan = (s*(s-a)*(s-b)*(s-c)) ** 0.5 
        print('Üçgenin alani {}'.format(alan)) 
    
ucgen = Ucgen() 
ucgen.kenar_uzunlarini_al() 
ucgen.kenar_uzunlugunu_goster() 
ucgen.atani_hesapla() 