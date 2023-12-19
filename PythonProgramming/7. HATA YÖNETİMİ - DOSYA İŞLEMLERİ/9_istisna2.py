# istisna türünü almak için sys modülünü ice aktarma 
import sys 
listem = ['a', 0, 21] 
for girdi in listem: 
    try: 
        print("Girdin", girdi) 
        r = 1/int(girdi)
        break 
    except ValueError: # 
        print("string değeri tam sayiya çevrilemez") 
    except ZeroDivisionError: 
        print("Bir sayiyi 0'a bölemezsin") 
        print() 
print("1/", girdi, "=", r) 