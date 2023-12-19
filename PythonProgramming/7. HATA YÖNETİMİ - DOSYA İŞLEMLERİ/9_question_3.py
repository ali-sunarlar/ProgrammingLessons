try: 
    sayi1 = int(input("Birinci sayiyi giriniz:")) 
    sayi2 = int(input("Ikinci sayiyi giriniz:")) 
except ValueError: 
    print("Sayi dişinda değer girdiniz") 
except ZeroDivisionError: 
    print("Bölen sifir olamaz") 
except: print("Hata oluştu") 
finally: print("Bu kod her zaman çalişir") 