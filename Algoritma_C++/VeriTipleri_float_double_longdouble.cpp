#include <iostream>

using namespace std;

int main()

{
	float yaricap;
	
	const float PI=3.14159F;
	
	cout<<"Yari cap giriniz...:";
	
	cin>>yaricap;
	
	cout<<endl;
	
	float alan=PI*yaricap*yaricap;
	
	cout<<alan<<endl;
	
	return 0;
	
	/*
	C++�da kayan noktal� de�i�kenler; float, double, long double �eklindedir. 

	double ve long double : float� a g�re bellekte daha fazla yer kaplarlar ve 
	daha geni� de�er aral���n� kapsarlar. 8 byte yer kaplarlar ve noktadan sonra 
	15 basamak ondal�k k�sma sahiptirler. 
	*/
	
}
