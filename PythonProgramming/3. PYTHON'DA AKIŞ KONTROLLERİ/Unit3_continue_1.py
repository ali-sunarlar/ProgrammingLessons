cevaplar = ["D","A","B","","C"]
i=0
for cevap in cevaplar:
    i+=1
    if cevap=="":
        print("Soru",i," : cevaplanmamis")
        continue
    print("Soru",i," : cevap",cevap)
print("Donguden Cikildi")