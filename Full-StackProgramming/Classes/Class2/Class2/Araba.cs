using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    internal class Araba
    {
        int arabano;
        string arabaadi;
        int motorgucu;
        string vitesdr;
        int fiyat;
        int otv;


        public int Araba
        {
            get { return arabano; }
            set { 
                if(value.ToString().Length == 6)
                {
                    arabano = value;
                }
                else
                {

                }
            
            }
        }

    }
}
