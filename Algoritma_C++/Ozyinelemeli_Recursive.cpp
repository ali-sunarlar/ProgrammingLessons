#include <iostream>

using namespace std;

int fonksiyon(int s){
        
        static int c=0;
        if(s>0){
            
            c++;
            fonksiyon(s/10);
        }
        else{
            return c;
        }
    }

int main()

{
   int sayi;
   sayi=12;
   printf("sayi :",sayi);
   int sonuc=fonksiyon(sayi);
   
   printf("sonuc :",sonuc);
   return 0;
   
}
