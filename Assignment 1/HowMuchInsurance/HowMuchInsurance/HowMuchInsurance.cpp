// HowMuchInsurance.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
	double replacement_cost;

	cout << "Enter Replacement Cost of the Building in Question: ";
	cin >> replacement_cost;

	cout << "Recommended Minimum Insurance: $" << fixed << showpoint << setprecision(2) << replacement_cost*.8 << endl;

	system("pause");

    return 0;
}

