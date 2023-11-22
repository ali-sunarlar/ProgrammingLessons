using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesaplama4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcı adı ve şifre iste
            //eğer veriler doğru ise yas ve emeklilik primi istenecek
            //-->yas 40 dan büyük, emeklilik 5000 günden fazla ise emeklilik hakkı kazansın ve maas bilgisi+toplam çalışma yılı istensin.
            //çalışma yılı 20 den fazla ise
            //maaş*yil %77,5 si ikramiye ver
            //çalışma yılı 20 den az ise
            //maaş*yil %50,5 si kadar ikramiye ver
            //-->değilse 5000 prim hesaplat kaç gün prim günü kaldığını söyle
            //ve kullanıcıya prim günü borç ödemek iister misin diye sor evet ise 50 bin tl borcu 5 taksit olarak ödemesi gereken tutarı yazdır

            double ikramiye = 0;
            Console.WriteLine("Kullanıcı Adını Giriniz: ");
            string kad=Console.ReadLine();
            Console.WriteLine("Şifreyi Girinz: ");
            string sifre=Console.ReadLine();

            if (kad=="yasemin" && sifre=="123")
            {
                Console.WriteLine("Yaşınızı Giriniz :");
                int yas=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Prim Gün Sayısını Giriniz :");
                int gun = Convert.ToInt32(Console.ReadLine());
                if(yas>=40 && gun>=5000)
                {
                    Console.WriteLine("Emeklilik hakkı kazandınız");
                    Console.WriteLine("Son maaş tutarınız giriniz: ");
                    float maas=Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Çalışma Yılını Giriniz: ");
                    int yil=Convert.ToInt32(Console.ReadLine());

                    if(yil>=20)
                    {
                        ikramiye = (maas * yil) * 77.5 / 100;
                        Console.WriteLine("Emeklilik Primi: "+ikramiye);

                    }

                    else
                    {
                        ikramiye= (maas * yil) * 50.5 / 100;
                        Console.WriteLine("Emeklilik Primi: " + ikramiye);
                    }
                }
                else
                {
                    int prim = 5000 - gun;
                    Console.WriteLine("Emeklilik için "+prim+ "kadar gününüz kaldı");
                    Console.WriteLine("Prim günü borç ödemek ister misiniz? E/H");
                    char cevap=Convert.ToChar(Console.ReadLine());

                    if (cevap=='E' || cevap=='e')
                    {
                        Console.WriteLine("50 bin tl brcu 5 taksit olaraak ödeyebilirsiniz. ödenecek tutar: "+5000/5);
                    }
                }
            }
            else 
            {
                Console.WriteLine("Hatalı Giriş Yaptınız.");

            }
            Console.ReadLine();






        }
    }
}
