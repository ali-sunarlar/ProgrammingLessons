#include <iostream>

using namespace std;

int main()

{
	
	int ftemp;
	
	cout<<"fahrenheit sicaklik giriniz : ";
	
	cin>>ftemp;
	
	int ctemp=(ftemp-32)*5/9;
	
	cout<<"derece: "<<ctemp<<endl;
	
	return 0;
	
}
