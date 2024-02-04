#include <iostream> //öniþlemci direktifi

/*
iostream, en temel giriþ/çýkýþ iþlemlerinden sorumludur. 
*/

using namespace std; //using direktifi

/*

Bu program ekrana

"Ilk C++ Programý" yazar 

*/

int main()

{
	cout << "ilk C++ Programi \n";  
	/* 
	<< operatorune ekleme operatoru denir.Sag taraftaki degiskenin 
	degerini sol taraftaki nesneye yonlendirir.
	*/
	
	/*
	usging direktifinde namespace(isim uzayinda) std tanimlanmasaydi asagidaki gibi islem yapilirdi
	std::cout<<"ilk C++ Programi \n";
	*/

	//  "\n" bir satir atlatir 
	
	#define pi=3.141618
	/*
	C++ programlama dili de kullanýmý tavsiye edilmemekle birlikte sabit tanýmý 
	#define ile tanýmlanabilir. const’an farklý olarak #define ile yapýlan 
	sabit tanýmlarýnda tip belirtilmez. 
	*/
	
	//const float pi=3.141618;
	
	/*
	Sabit tanýmlamak için kullanýlýr ve deðiþkenin deðerinin program sonuna kadar 
	deðiþmeyeceðini bildirir. Bu tür deðiþkenlerin içeriðini deðiþtirme giriþiminde 
	bulunulduðunda hata mesajý ile karþýlaþýlýr.
	*/
	
	
	
	return 0;
}
