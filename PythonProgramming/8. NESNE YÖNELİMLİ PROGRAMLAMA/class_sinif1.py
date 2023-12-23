# Araba Sinifi tanimlama 
class Araba:
    "Bir araba sinifi tanimlanmasi"
    model = 2020
    marka = "BMW"

    def hizlan():
        return 'Hizlandim'

print(Araba.model) 
print (Araba.marka) 
print(Araba.hizlan()) 
print(Araba.__doc__) 