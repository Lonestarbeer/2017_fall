// StadiumSeating.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
	const double Ticket_A = 15, Ticket_B = 12, Ticket_C = 9;
	double Sold_A, Sold_B, Sold_C, Income;

	cout << "Income generated from ticket sales\n\n";
	cout << "Class A tickets sold: ";
	cin >> Sold_A;
	cout << "Class B tickets sold: ";
	cin >> Sold_B;
	cout << "Class C tickets sold: ";
	cin >> Sold_C;

	Income = (Ticket_A * Sold_A) + (Ticket_B * Sold_B) + (Ticket_C * Sold_C);
	cout << "Income generated is: $";
	cout << fixed << showpoint << setprecision(2) << Income << endl;

	system("pause");

    return 0;
}

