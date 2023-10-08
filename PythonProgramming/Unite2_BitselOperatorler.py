
# Operatör          # Operatör Sembolü # Örnek
# Ve (and)          # &                # a & b
# Veya (or)         # |                # a | b
# Özel Veya (Xor)   # ^                # a ^b
# Değil (not)       # ~                # ~a
# Sola kaydır       # <<               # a<<2
# Sağa Kaydır       # >>               # a>>2


#ikili iki tane degisken tanimlayalim
ikili_sayi1=0B00001010 #10 Sayisi
ikili_sayi2=0B00000111 #7 sayisi
#ikili sayinin parantez icinde onlu karsiliklarini goster
print(str(bin(ikili_sayi1))+"\t"+"("+str(ikili_sayi1)+")")
print(str(bin(ikili_sayi2))+"\t"+"("+str(ikili_sayi2)+")")
#bitsel and islemi yapalim
print(str(bin(ikili_sayi1))+" ve "+str(bin(ikili_sayi2))+" = ",str(bin(ikili_sayi1&ikili_sayi2))+"("+str(ikili_sayi1&ikili_sayi2)+")")
#bitsel veya islemi yapalim
print(str(bin(ikili_sayi1))+" veya "+str(bin(ikili_sayi2))+" = ",str(bin(ikili_sayi1|ikili_sayi2))+"("+str(ikili_sayi1|ikili_sayi2)+")")
#bitsel xor islemi yapalim
print(str(bin(ikili_sayi1))+" XOR "+str(bin(ikili_sayi2))+" = ",str(bin(ikili_sayi1^ikili_sayi2))+"("+str(ikili_sayi1^ikili_sayi2)+")")
#bitsel değil yap
print("~"+str(bin(ikili_sayi1))+" = ",str(bin(~ikili_sayi1))+"("+str(~ikili_sayi1)+")")
#bitsel sağa 1 kere kaydir
print(str(bin(ikili_sayi1))+" >> 1 "+" = ",str(bin(ikili_sayi1>>1))+"("+str(~ikili_sayi1>>1)+")")
#bitsel sola 2 kere kaydir
print(str(bin(ikili_sayi1))+" <<2 "+" = ",str(bin(ikili_sayi1<<2))+"("+str(~ikili_sayi1<<2)+")")
