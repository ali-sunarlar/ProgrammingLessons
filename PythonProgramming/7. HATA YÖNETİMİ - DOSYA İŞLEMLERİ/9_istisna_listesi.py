"""İstisna

Açiklama

Exception

Tüm istisnalarin temel sinifi

StopIteration

Bir iterasyonun next() metodu bir nesneyi göstermediğinde oluşur.

SystemExit

sys.exit() fonksiyonu tarafindan oluşturulur.

StandardError

StopIteration ve SystemExit dişinda, bu tüm yerleşik fonksiyonalr için temel sinif görevi görür.

ArithmeticError

Sayisal hesaplamalarda oluşan tüm hatalar için temel siniftir.

OverflowError

Bu hata, hesaplama sayisal bir tür için olasi maksimum değeri aşarsa ortaya çikan hata

FloatingPointError

Ondalikli hesaplama işlemleri başarisiz olduğunda oluşur.

ZeroDivisionError

Sifira bölme işleminde ortaya çikar.

AssertionError

Assert ifadesinin başarisiz olmasi durumunda ortaya çikar.

AttributeError

Öznitelik referansi veya atama işleminin başarisiz olmasi durumunda ortaya çikan hata.

EOFErroR

Girdi olmadiğinda ve dosyanin sonuna ulaşildiğinda ortaya çikar.

ImportError

Bir import işlemi başarisiz olduğunda oluşur.

KeyboardInterrupt

Programin yürütülmesinde bir kesinti olduğunda tetiklenir

LookupError

Tüm arama hatalari bu temel sinifa girer

IndexError

Sirali yapilarda indis bulunamadiğinda çikan durumlarda

KeyError

Sözlükte belirtilen anahtar değeri tutulmadiğinda ortaya çikar

NameError

Yerel veya global kapsamda bir değişken bulunmadiğinda ortaya çikar.

UnboundLocalError

Kendisine herhangi bir değer atanmadan yerel bir değişken kullanildiğinda ortaya çikar.

EnvironmentError

Python çevresinin dişinda ortaya çikan tüm istisnalar için temel siniftir.

IOError

Girdi/Çikiş işlemlerinin başarisiz olduğu durumlarda ortaya çikar

SyntaxError

Bu istisna, tüm python sözdizimine yönelik hatalari işler

IndentationError

Uygun olmayan girinti bu tür hatalara yol açacaktir.

SystemError

Yorumlayici dahili hata algiladiğinda tetiklenir.

SystemExit

Python yorumlayicisi sys.exit() işlevini kullandiğinda, bu istisnaya yol açar.

TypeError

Eğer veri türünde bir hata oluşursa ortaya çikar

ValueError

Bir fonksiyon, doğru türde ancak uygun olmayan değerde bir argüman aldiğinda ortaya çikar

RuntimeError

Oluşan hata hiç birbir kategoriye girmediğinde oluşur.

NotImplementedError

Kalitimli bir sinifta uygulanmasi gereken soyut (abstract) bir yöntem gerçekte uygulanmadiğinda ortaya çikar."""