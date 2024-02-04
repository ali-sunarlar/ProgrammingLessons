#include <iostream>

#include <iomanip> //setw icin

/*
setw manip�lat�r�
Ekrana bas�lacak karakterlerin belirli bir formatta n karakterlik 
bir alanda yaz�lmas�n� sa�lar setw(n), Burada n setw(n) fonksiyonunun arg�man�d�r.

setw(10) kendisinden sonra gelen de�i�keni 10 karakterlik alanda yazd�r�r. 
Say�lar sa�a, metinler sola dayal�d�r. 
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
