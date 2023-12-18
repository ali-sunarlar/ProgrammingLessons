using LINQ1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LINQ1.Controllers
{
    public class KitapController : Controller
    {
        List<Kitap> Kitaplar = new List<Kitap>() {

            new Kitap(){KitapID= 1,KitapAdi = "Suc Ve Ceza",YazarAdi="Dostoyevski", KitapSayfasi = 690} ,

            new Kitap(){KitapID= 2,KitapAdi = "Karamazov Kardesler",YazarAdi="Dostoyevski", KitapSayfasi = 850},

            new Kitap(){KitapID= 3,KitapAdi = "Martin Eden", YazarAdi="Jack London", KitapSayfasi = 520 } ,

            new Kitap(){KitapID= 4,KitapAdi ="Iki Şehrin Hikayesi",YazarAdi="Charles Dickens",KitapSayfasi= 400 } ,

            new Kitap(){KitapID= 5,KitapAdi = "Satranç" , YazarAdi="Stefan Zweig" , KitapSayfasi = 90 }

            };

        public IActionResult Index()
        {
            //Where
            var sonuc = from x in Kitaplar

                        where x.KitapSayfasi > 500 && x.KitapSayfasi < 1000

                        select x;
            var sonuc2 = Kitaplar.Where(x => x.KitapSayfasi > 500 && x.KitapSayfasi < 1000);

            //OrderBy- OrderByDescending Operatörü
            var sonuc3 = from x in Kitaplar

                         orderby x.KitapAdi

                         select x;

            var sonuc4 = Kitaplar.OrderBy(x => x.KitapAdi);

            
            var sonuc5 = from x in Kitaplar

                         orderby x.KitapAdi descending

                         select x;

            var sonuc6 = Kitaplar.OrderByDescending(x => x.KitapAdi);


            //Group By Operatörü

            var sonuc7 = from s in Kitaplar

                         group s by s.YazarAdi;

            var sonuc8 = Kitaplar.GroupBy(s => s.YazarAdi);

            //Select Operatörü
            var sonuc9 = (from x in Kitaplar where x.KitapSayfasi > 500 
                          select x.KitapAdi).ToList(); 
            var sonuc10 = Kitaplar.Where(x => x.KitapSayfasi > 500).Select(x => x.KitapAdi).ToList();


            var sonuc11 = Kitaplar.Select(s => new { Ad = s.KitapAdi, sayfa = s.KitapSayfasi }).ToList();


            //Contains-Any-All Metotları

            Kitap k = new Kitap()
            {
                KitapID = 8,
                KitapAdi = "x",
                YazarAdi = "y", KitapSayfasi = 10 }; 
            Kitaplar.Add(k); 
            var sonuc12 = Kitaplar.Contains(k); //returns true
            var sonuc13 = (from ktp in Kitaplar //returns true
                           select ktp).Contains(k);

            /*Any() metodu, bir veri kaynağının öğelerinden en az birinin belirli bir koşulu karşılayıp 
             * karşılamadığını kontrol etmek için kullanılır. Öğelerden herhangi biri verilen koşulu 
             * sağlıyorsa, true döndürür, aksi takdirde false döndürür. Ayrıca bir koleksiyonun veri 
             * içerip içermediğini kontrol etmek için de kullanılabilir. Aşağıdaki kod Kitaplar 
             * listesinde eleman olduğundan sonuc14 değişkenine true değeri döndürecektir.*/
            var sonuc14 = Kitaplar.Any();

            /*All() metodu bir veri kaynağının tüm öğelerinin belirtilen koşulu karşılayıp 
             * karşılamadığını kontrol eder. Tüm öğeler şartı karşılıyorsa true, karşılamıyorsa 
             * false değeri döndürür. Aşağıda Kitaplar listesindeki tüm kitapların sayfa 
             * sayılarının 500-1000 arasında olup olmadığı kontrol edilmiştir. Tüm kitaplara 
             * ait sayfa sayıları bu aralıkta olmadığından sonuc15 değişkeni false değerini alacaktır.*/
            var sonuc15 = Kitaplar.All(x => x.KitapSayfasi > 500 && x.KitapSayfasi < 1000);

            // Count Metodu

            var sonuc17 = Kitaplar.Count(x => x.KitapSayfasi < 500);

            var sonuc16 = Kitaplar.Count();



            //Max- Min- Sum-Avarage Metotları

            var sonuc18 = Kitaplar.Max(s => s.KitapSayfasi);

            var sonuc19 = Kitaplar.Min(s => s.KitapSayfasi);

            var sonuc20 = Kitaplar.Sum(s => s.KitapSayfasi);

            var sonuc21 = Kitaplar.Average(s => s.KitapSayfasi);



            return View(sonuc);
        }
        public IActionResult TekKitapGoster()
        {

            //First - FirstOrDefault Metotları

            var sonuc22 = Kitaplar.First(x => x.KitapID % 2 == 0);
            var sonuc23 = Kitaplar.FirstOrDefault(x => x.KitapID > 5);


            return View(sonuc22);
        }

        public string ErtelenmisSorgu() { 
        string txt = ""; 
        int[] sayilar = new int[7] { 0, 1, 2, 3, 4, 5, 6 }; 
        var SayiQuery = 
        from sayi in sayilar 
        where (sayi % 2) == 0 
        select sayi; 
        sayilar[1] = 8;
            //var data = from tt in sayilar
            //           where tt > 5
            //           select tt;
        foreach (int deger in SayiQuery) { 
        txt = txt + " - " + deger; 
        }
        return (txt);
        }

        public string AnlikSorgu() { 
            string txt = ""; 
            int[] sayilar = new int[7] { 0, 1, 2, 3, 4, 5, 6 }; 
            var SayiQuery = (
            from sayi in sayilar 
            where (sayi % 2) == 0 
            select sayi).ToList(); 
            sayilar[1] = 8; 
            txt = "Toplam Çift Eleman = " + SayiQuery.Count+"\n"; 
            foreach (int deger in SayiQuery) { 
            txt = txt + " - " + deger; 
            }
            return (txt); 
        }



    }
}


//Ertelenmiş Sorgu Yürütme (Deferred Query Execution)
/*Bu sorgu yürütme tekniği işe gereksiz kod işletilmesi önleyerek performans büyük ölçüde arttırılır. 
 * Bu teknik ile değer döndüren bir sorguda, sorgu değişkeninin kendisi hiçbir zaman sorgu sonuçlarını tutmaz, 
 * yalnızca sorgu komutlarını depolar. Sorgunun yürütülmesi, sorgu değişkeni bir foreach veya For döngüsü işletilene kadar ertelenir. 
 * Diğer bir deyişle, sorgu yürütme, sorgu oluşturulduktan bir süre sonra gerçekleşir. Bu da, bir sorgunun oluşturulup 
 * istenen sıklık ile çalıştırılabileceği anlamına gelir. Örneğin başka uygulamalar tarafından sürekli güncellenen 
 * bir varitabanında bu yaklaşım kullanışlı olabilir. Böyle bir durumda sorgu oluşturulduktan sonra, sorgu tekrar 
 * tekrar yürütülerek, her bir yürütme de sorguya ait güncel bilgiler döndürülebilir.*/

/*public string Deneme() { 
 * string txt = ""; 
 * int[] sayilar = new int[7] { ©, 1, 2, 3, 4, 5, 6 }; 
 * var SayiQuery = 
 * from sayi in sayilar where (sayi % 2) == @ 
 * select sayi; sayilar[1] = 8; 
 * foreach (int deger in SayiQuery) { 
 * txt = txt + " - " + deger; 
 * }
 * return (txt); */


//Anlık Sorgu Yürütme (Deferred Query Execution)
/*Anlık sorgu yürütme, ertelenmiş yürütmenin tersidir. 
 * LINQ sorgusunu yürütmeye zorlar ve sonucu hemen alır. 
 * Anlık olarak hesaplanması gereken Average(Ortalama), 
 * Count(Adet), First(İlk) ve Max(Maksimum) gibi durumlarda sorgunun hemen yürütülmesi gerekir.*/

/*public string Deneme() { 
 * string txt = ""; 
 * int[] sayilar = new int[7] { 6, 1, 2, 3, 4, 5, 6 }; 
 * var SayiQuery = (
 * from sayi in sayilar 
 * where (sayi % 2) == 0 
 * select sayi)sToList(); 
 * sayilar[1] = 8; 
 * txt = “Toplam Çift Eleman = " + SayiQuery.Count+"\n"; 
 * foreach (int deger in SayiQuery) { 
 * txt = txt + " - " + deger; 
 * }
 * return (txt); } 
 */

//Where Operatörü

/*var sonuc = from x in Kitaplar

where x.KitapSayfasi > 500 && x.KitapSayfasi < 1000

select x;*/

/*var sonuc2 = Kitaplar.Where(x => x.KitapSayfasi > 500 && x.KitapSayfasi < 1000);*/


//OrderBy- OrderByDescending Operatörü
/*var sonuc3 = from x in Kitaplar

orderby x.KitapAdi

select x;*/


/*var sonuc4 = Kitaplar.OrderBy(x => x.KitapAdi);*/

/*Kitapların isimlere göre tersten sıralanması sorgu sözdizimi ile

var sonuc5 = from x in Kitaplar

orderby x.KitapAdi descending

select x;

yöntem sözdimizi ile ise

var sonuc6 = Kitaplar.OrderByDescending(x => x.KitapAdi);

şeklindedir.*/



