#include <iostream>

using namespace std;

int dobre, zle;
string odp;

int main()
{

	cout << "#1 Ten program jest napisany w jezyku: " << endl;
	cout << "a) Delphi" << endl;
	cout << "b) C++" << endl;
	cout << "c) Pascal" << endl;
	cout << "\nTwoja odpowiedz: ";
	cin >> odp;
	cout << "\n-------------------------------------\n" << endl;

	if (odp != "b")
	{
			
			zle++;
			
	}
	
	else if (odp == "b")
	{
		 
		 dobre++;
		 
	} 
	
	cout << "#2 Jaki system produkuje koncern Microsoft: " << endl;
	cout << "a) Windows" << endl;
	cout << "b) Linux" << endl;
	cout << "c) Mac OS X" << endl;
	cout << "\nTwoja odpowiedz: ";
	cin >> odp;
	cout << "\n-------------------------------------\n" << endl;
	
	if (odp != "a")
	{
			
			zle++;
			
	}
	
	else if (odp == "a")
	{
		 
		 dobre++;
		 
	}
	
	system("cls");
	cout << "Dobre: " << dobre << endl;
	cout << "Zle: " << zle << endl;
	cin.ignore();
	getchar();
	
}
