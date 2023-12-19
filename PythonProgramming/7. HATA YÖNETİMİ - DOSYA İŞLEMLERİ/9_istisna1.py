#Hata Turleri
#Sözdizimi Hataları (Syntax Error) 
#Çalışma Zamanı Hataları (Run-Time Error) 
#Mantıksal Hatalar (Logical Error) 

#try:
#Hataya sebep olacak kodlar
#except istisna1:
#İstisna 1 tipinde hatada yapılacaklar
#except istisna2:
#İstisna 1 tipinde hatada yapılacaklar
#else:
#Hata oluşmadığında yapılacaklar
#finally:
#Her ne olursa olsun çalışacak kodlar

import sys 
listem = ['a', 0, 2] 
for girdi in listem: 
    try: 
        print("Girdin", girdi) 
        r= 1/int(girdi) 
        break 
    except: 
        print("Tah", sys.exc_info() [0], "hatası olustu.") 
        print("sonraki girdi.") 
        print() 
print("1/", girdi, "=", r)



