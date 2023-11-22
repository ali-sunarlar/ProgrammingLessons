using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dizinin elemanlarını dışarıdan alan ve boyutunu kullanıcının belirlediği program
            Console.WriteLine("Dizi boyutunu giriniz: ");
            int elemansayisi=Convert.ToInt32(Console.ReadLine());
           
            int[] yas=new int[elemansayisi];

            for(int i=0;i<yas.Length;i++)
            {
                Console.WriteLine(i+1+".Yaşı Giriniz");
                yas[i]=Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0; i<yas.Length;i++)
            {
                Console.WriteLine("Değerler: " + yas[i]);
            }
            Console.ReadLine();







        }
    }
}
