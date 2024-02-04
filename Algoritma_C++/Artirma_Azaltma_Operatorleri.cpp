#include <iostream>

using namespace std;

int main()


{
	
	int a,b,c,d=10,e=10,f=10,g=10;
	a=++d; //once a'nin degeri bir artar sonra atama islemi yapilir
	cout<<"a=++d > "<<a<<endl;
	a=e++; //once atama islemi yapilir.Sonra a'nin degeri bir artar
	cout<<"a=e++ > "<<a<<endl<<endl;
	
	a=--f; //once f'nin degeri bir eksilir sonra atama islemi yapilir.
	cout<<"a=--f > " <<a<<endl;
	a=g--; //once atama islemi yapilir.Sonra g'nin degeri bir azalir
	cout<<"a=g-- > " <<a<<endl;
	
	return 0;
	
	
}
