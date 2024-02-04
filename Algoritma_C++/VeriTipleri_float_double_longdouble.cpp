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
	C++’da kayan noktalý deðiþkenler; float, double, long double þeklindedir. 

	double ve long double : float’ a göre bellekte daha fazla yer kaplarlar ve 
	daha geniþ deðer aralýðýný kapsarlar. 8 byte yer kaplarlar ve noktadan sonra 
	15 basamak ondalýk kýsma sahiptirler. 
	*/
	
}
