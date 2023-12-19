Listem = [10019999 ,'a', 0, 2] 
for girdi in Listem: 
    try: 
        print("Girdim", girdi) 
        r= 1/int(girdi) 
        break 
    except ValueError: # 
        print("string değeri tan sayiya çevrilenez") 
    except ZeroDivisionError: 
        print("Bir sayiyi 0'a bölemezsin") 
        print() 
    except Exception as e: 
        print(e) # yukarda yakaladiğiniz hata dişinda hata yakaladim 
    finally: 
        print("Finally Çalişti") #Burade hafiza temizleme , kaynak kapatma gibi işler yapilebili 