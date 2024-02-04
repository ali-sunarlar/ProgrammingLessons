#include <iostream>

using namespace std;

int main()

{
	int sayi1;
	int sayi2;
	
	sayi1=20;
	sayi2=sayi1+10;
	
	cout<<"sayi1+10=";
	
	cout<<sayi2<<endl;
	
	/*
	endl manipülatörü çıktıda satır atlamasını sağlar. 
	Bu şekilde, bunu takip eden metin bir sonraki satırda görüntülenir.
	endl manipülatörü \n karakterleri ile aynı etkiye sahiptir ve bir manipülatör örneğidir.
	*/
	
	/*
	int tipinin yanı sıra iki tane tam sayı tipi daha vardır. 
	Bunlar long, short tipleridir. int tipinin büyüklüğünün siteme bağlı 
	olduğunu daha önce belirtmiştik. Ancak long ve short tamasayı tipleri 
	hangi sistemde kullanılırsa kullanılsın aynı büyüklüğe sahiptirler. 
	long her zaman bellekte 4 byte yer kaplar, short tamsayı tipi ise bellekte 2 Bayt yer kaplar. 
	*/
	
	return 0;
}
