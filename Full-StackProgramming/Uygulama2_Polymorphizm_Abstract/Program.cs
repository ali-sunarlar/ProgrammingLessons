using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama2_Polymorphizm_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Polymorphizm: (Çok Biçimlilik, Çok Şekillilik)
            //Bir sınıfa aynı isimde farklı uygulamalar yapabilme özelliği sağlar.
            //Ana classta gövdesi yazılır
            //yavru classlarada varolan method ezilerek kendi işlemleri yapılabilir

            //Abstract: (Soyutlama)
            //Nesne Yönelimli Programlamada nesnesi oluşturulmayan sınıflara denir.
            //Abstract olarak tanımlanan bir sınıf temel sınıftır.
            //Bu sınıftan new anahtar kelimesi kullanılarak bir nesne oluşturulamaz
            //Sadece soyut sınıflarv içeriisinde kullanılablir.
            //Mirasçı sınıflarda ovveride edilmek zorundadırlar.

            Turk turk = new Turk();
            turk.Selamver();

            Ingilizler ing = new Ingilizler();
            ing.Selamver();

            Console.ReadLine();



        }
    }
}
