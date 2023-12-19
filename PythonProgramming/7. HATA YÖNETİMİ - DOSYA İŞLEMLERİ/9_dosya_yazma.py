#Yazma icin Yontem 

with open("test.txt", "w" ,encoding = 'utf-8') as dosya:
    dosya.write("İlk satir\n") 
    dosya.write("ikinci satir \n\n") 
    dosya.write("üçüncü satir\n")

#Yazma icin yontem 2
try: 
    dosya = open("test1.txt", "w", encoding = 'utf-8') 
    dosya.write("ilk satirin\n") 
    dosya.write(" kine satir \n\n") 
    dosya.write("üçüncü satir\n")

finally: 
    dosya.close()

dosya = open("test2.txt", "w", encoding = "utf-8")
dosya.write("ilk satir\n")
dosya.write("ikinci satir \n\n")
dosya.write( "üçüncü satir\n")
dosya.close()
#testi dosyasina ekleme yapali

with open ("test1.txt", "a", encoding = 'utf-8') as dosya: 
    dosya.write("dördüncü satir\n") 
    dosya.write("beşinci satir \n\n") 
    dosya.write("altinci satin\n") 