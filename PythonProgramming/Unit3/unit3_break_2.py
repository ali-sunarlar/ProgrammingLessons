cevaplar = ["D","A","B","","C"]
i=0
for cevap in cevaplar:
    i+=1
    if cevap=="":
        print("Soru",i," : cevaplanmamis")
        break
    print("Soru",i," : cevap",cevap)
    