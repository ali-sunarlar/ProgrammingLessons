using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class5
{
    internal class Araba
    {
        public string ARenk;
        public string AModel;
        public string AVites;
        public float AFiyat;
        private string plaka;

        public string Plaka
        {
            get { return plaka; }
            set {
                if(value=="34")
                {
                plaka= value;
                }
            else
                {
                    Console.WriteLine("34 haricinde kod kabul edilmemekte");
                }
            }
        }


    }


    }

