cpu_model=input("Lutfen CPU modelinizi Giriniz: ")
cpu_model.lower()

match cpu_model:
    case "celeron":
        print("Mayin Tarlasi oynamaya devam :) ")
    case "core i3":
        print("Iyi sanslar")
    case "core i5":
        print("Hadi Iyisin")
    case "core i7":
        print("Sana eglenceli oyun dilerim")
    case "core i9":
        print("Ooo cok hizli makinan var")
    case _: #alt çizgi karakteri hepsini yakalama olarak kullanilir.
        print("Bu bile bir sey mi?")