// HousingCosts.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>

using namespace std;


int main()
{
	double rent, utilities, phones, cable, month_total, year_total;
	
	cout << "Monthly/Yearly Housing Expenditures Calculator";

	cout << "Estimated monthly rent/house payment? ";
	cin >> rent;
	cout <<"Estimated monthy utilities? ";
	cin >> utilities;
	cout << "Estimated monthly phone costs? ";
	cin >> phones;
	cout << "Estimated monthly cable cost? ";
	cin >> cable;

	month_total = rent + utilities + phones + cable;
	year_total = month_total * 12;
	
	cout << "Total monthly expenses: $" << fixed << showpoint << setprecision(2) << month_total << endl;
	cout << "Total yearly expenses: $" << fixed << showpoint << setprecision(2) << year_total << endl;

	
	system("pause");

    return 0;
}

