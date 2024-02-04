#include <iostream> //�ni�lemci direktifi

/*
iostream, en temel giri�/��k�� i�lemlerinden sorumludur. 
*/

using namespace std; //using direktifi

/*

Bu program ekrana

"Ilk C++ Program�" yazar 

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
	C++ programlama dili de kullan�m� tavsiye edilmemekle birlikte sabit tan�m� 
	#define ile tan�mlanabilir. const�an farkl� olarak #define ile yap�lan 
	sabit tan�mlar�nda tip belirtilmez. 
	*/
	
	//const float pi=3.141618;
	
	/*
	Sabit tan�mlamak i�in kullan�l�r ve de�i�kenin de�erinin program sonuna kadar 
	de�i�meyece�ini bildirir. Bu t�r de�i�kenlerin i�eri�ini de�i�tirme giri�iminde 
	bulunuldu�unda hata mesaj� ile kar��la��l�r.
	*/
	
	
	
	return 0;
}
