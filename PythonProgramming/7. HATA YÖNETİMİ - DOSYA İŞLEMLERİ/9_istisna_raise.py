#Kullaniciya uyari amaçli bir mesaj göndermek i yada özelleştirilmiş bir hata mesaji oluşturulmak istendiğinde raise ifadesi kullanilmaktadir

def bolum(a, b): 
    if b==0: 
        raise ValueError('b 0\'dan farkli olmali') 
    else: 
        return a / b 

print(bolum(2,0)) 