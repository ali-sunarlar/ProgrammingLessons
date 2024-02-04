#include <iostream>

#include <iomanip> //setw icin

/*
setw manipülatörü
Ekrana basýlacak karakterlerin belirli bir formatta n karakterlik 
bir alanda yazýlmasýný saðlar setw(n), Burada n setw(n) fonksiyonunun argümanýdýr.

setw(10) kendisinden sonra gelen deðiþkeni 10 karakterlik alanda yazdýrýr. 
Sayýlar saða, metinler sola dayalýdýr. 
*/

using namespace std;

int main()

{
	int not1=50,not2=67,not3=80;
	
	cout<<setw(8)<<"Adi"<<setw(8)<<"notu"<<endl;
	
	cout<<setw(8)<<"===================================="<<endl;
	
	cout<<setw(8)<<"Aysegul"<<setw(8)<<not1<<endl;
	cout<<setw(8)<<"Hasan"<<setw(8)<<not2<<endl;
	cout<<setw(8)<<"Abdullah"<<setw(8)<<not3<<endl;
	
	cout<<setw(8)<<"===================================="<<endl<<endl;
	
	return 0;
}
