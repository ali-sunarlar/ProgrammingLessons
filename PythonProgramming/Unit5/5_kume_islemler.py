# Kumeler

kumel = {1,2,3,4,5,6,7}

kume2 = {3,5,7,8,9,10}

print("1. Kümenin içeriği :{}".format(kumel))

print("2. Kümenin içeriği :{}".format(kume2))

# İki kümenin farki

fark_kumesi = kumel - kume2

print("fark kümesinin içeriği :{}".format(fark_kumesi)) 
fark_kumesi = kumel.difference(kume2)

print("fark kümesinin içeriği :{}".format(fark_kumesi))

# İki kümenin kesişimi

kesisim_kumesi = kumel & kume2

print("Kesigim kümesinin içeriği :{}".format(kesisim_kumesi)) 
kesisim_kumesi = kumel.intersection(kume2)

print("Kesişim kümesinin içeriği :{}".format(kesisim_kumesi)) 
# İki kümenin birleşimi

birlesim_kumesi = kumel | kume2

print("Birlesim kümesinin içeriği :{}".format(birlesim_kumesi)) 
birlesim_kumesi = kumel.union(kume2)

print("Birlesim kümesinin içeriği :{}".format(birlesim_kumesi)) 
# ortak elemanlari bulunmayan (ayrik) küme tespiti

ayrik_kumemi = kumel.isdisjoint(kume2)

print("İki küme ayrik'mi :{}".format(ayrik_kumemi))

# Kapsayan küme tespiti

kapsayan_kume = kume2.issuperset(kumel)

print("İki küme kbirbirini kapsiyormu? :{}".format(kapsayan_kume)) 
# alt küme tespiti

alt_kume = kumel.issubset(kume2)

print("Birinci küme ikinci kümenin alt kimesimi kesisen'mi :{}".format(alt_kume)) 