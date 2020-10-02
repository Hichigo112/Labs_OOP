#include <iostream>
#include "ConsoleInteractor.h"

using std::cin;
using std::cout;

ConsoleInteractor::ConsoleInteractor()
{
	int power, * setElement = nullptr;
	cout << "enter the power of the firstSet\n";
	cin >> power;
	setElement = new int[power];
	cout << "enter the element of the firstSet\n";
	for (int i = 0; i < power; i++)
	{
		cin >> setElement[i];
	}
	_firstSet.ChangeSet(setElement, power);
	delete[] setElement;
	cout << "enter the power of the secondSet\n";
	cin >> power;
	setElement = new int[power];
	cout << "enter the elements of the secondSet\n";
	for (int i = 0; i < power; i++)
	{
		cin >> setElement[i];
	}
	_secondSet.ChangeSet(setElement, power);
	delete[] setElement;
}

void ConsoleInteractor::AddElement()
{
	int digit, numeric;
	cout << "in which set do you want to add the element? First or Second?\n";
	cin >> digit;
	if (digit == 1)
	{
		cout << "enter the numeric which do you want\n";
		cin >> numeric;
		_firstSet.AddElement(numeric);
	}
	else if (digit == 2)
	{
		cout << "enter the numeric which do you want\n";
		cin >> numeric;
		_secondSet.AddElement(numeric);
	}
}

void ConsoleInteractor::GetPower() const
{
	cout << "enter the number set which power do you want know\n";
	int digit;
	cin >> digit;
	if (digit == 1)
	{
		cout << "power of this set is " << _firstSet.GetPower() << "\n";
	}
	else if (digit == 2)
	{
		cout << "power of this set is " << _secondSet.GetPower() << "\n";
	}
}

void ConsoleInteractor::Print() const
{
	cout << _firstSet << " - first set elements " << "\n";
	cout << _secondSet << " - second set elements " << "\n";
}

void ConsoleInteractor::GetElement() const
{
	cout << "enter the number set\n";
	int digit, numElement;
	cin >> digit;
	cout << "which element do you want to print\n";
	cin >> numElement;
	try
	{


		if (digit == 1)
		{
			cout << _firstSet[numElement] << "\n";
		}
		else if (digit == 2)
		{
			cout << _secondSet[numElement] << "\n";
		}
	}
	catch (const std::out_of_range& err)
	{
		cout << err.what() << " \n";
	}
}

void ConsoleInteractor::IsIntersect() const
{
	if(_firstSet.IsIntersect(_secondSet))
	{
		cout << "there is an intersection\n";
	}
	else
	{
		cout << "there is no an intersection\n";
	}
}
void ConsoleInteractor::Help() const
{
	cout << "\"1\" - AddElement\n\"2\"- GetPower\n\"3\"- IsIntersect\n\"4\" - Help\n\"5\" - Print\n\"6\" - GetElement\n\"7\" - Exit";
}

void ConsoleInteractor::Init()
{
	Help();
	int number;
	while(true)
	{
		cout << "enter the number\n";
		cin >> number;
		if (number == 1)
		{
			AddElement();
		}
		else if (number == 2)
		{
			GetPower();
		}
		else if (number == 3)
		{
			IsIntersect();
		}
		else if (number == 4)
		{
			Help();
		}
		else if (number == 5)
		{
			Print();
		}
		else if (number == 6)
		{
			GetElement();
		}
		else if (number == 7)
		{
			break;
		}
	}
}