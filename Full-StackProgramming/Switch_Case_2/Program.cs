using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Case_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tıp için Tıp");
            Console.WriteLine("Sosyal Biilimler için Sb");
            Console.WriteLine("Eğitim Fakültesi için Eğitim yazınız");

            string fakulte=Console.ReadLine();
            switch(fakulte)
            {
                case "Tıp":
                    Console.WriteLine("Branşını seç: ");
                    Console.WriteLine("Genel Cerrah için g");
                    Console.WriteLine("Dahiliye için d");

                    char brans=Convert.ToChar(Console.ReadLine());

                    switch (brans)
                    {
                        case 'g':
                            Console.WriteLine("Genel Cerrah Ekranı");
                            Console.WriteLine("Yıllık Bölüm fiyatını giriniz ");
                            float yillik = Convert.ToSingle(Console.ReadLine());

                            Console.WriteLine("Durumunuzu Seçiniz: ");
                            Console.WriteLine("1- Burslu");
                            Console.WriteLine("2- Burssuz");

                            int durum = Convert.ToInt32(Console.ReadLine());

                            if (durum == 1)
                            {
                                Console.WriteLine("Burs Oranı Giriniz:");
                                int oran = Convert.ToInt32(Console.ReadLine());

                                yillik -= yillik * oran / 100;
                                Console.WriteLine("%" + oran + "Burslu Yıllık Tutar " + yillik);
                            }
                            else
                            {
                                Console.WriteLine("Ödeme peşin yada taksit");
                                string odeme = Console.ReadLine();

                                if (odeme == "taksit")
                                {
                                    Console.WriteLine("2- Taksit");
                                    Console.WriteLine("4- Taksit");
                                    Console.WriteLine("7- Taksit");

                                    int taksit = Convert.ToInt32(Console.ReadLine());
                                    if (taksit == 2)
                                    {
                                        yillik = yillik / 2;
                                        Console.WriteLine("2 Taksit Tutarı: " + yillik);
                                    }
                                    else if (taksit == 4)
                                    {
                                        yillik = yillik / 4;
                                        Console.WriteLine("4 Taksit Tutarı: " + yillik);
                                    }
                                    else if (taksit == 7)
                                    {
                                        yillik = yillik / 7;
                                        Console.WriteLine("7 Taksit Tutarı: " + yillik);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Yanlış Seçim Yaptınız!");
                                    }
                                    
                                }
                               
                            }
                            break;
                        case 'd':
                            Console.WriteLine("Dahiliye Ekranı");
                            break;
                        default:
                            Console.WriteLine("Yanlış Seçim Yaptınız..");
                            break;
                    }
                    break;
                case "Sb":
                    break;
                case "Eğitim Bilimleri":
                    break;

                default:
                    Console.WriteLine("Yanlış Seçim Yaptınız");
                    break;
                  }
            Console.ReadLine();

                            }

                    }


            }


        
    

