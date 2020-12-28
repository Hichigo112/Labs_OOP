#include <iostream>
#include "ConsoleInteractor.h"

using std::cin;
using std::cout;

ConsoleInteractor::~ConsoleInteractor()
{
	for (int i = 0; i < _count; i++)
	{
		if (_names[i] != "")
		{
			delete _storage[i];
		}
	}
	delete[] _names;
	delete[] _storage;
}

ConsoleInteractor::ConsoleInteractor()
{
	cout << "how many shape?\n";
	cin >> _count;
	_names = new string[_count];
	_storage = new Shape* [_count];
}

int ConsoleInteractor::GetIndex(const string& name) const
{
	for (int i = 0; i < _count; i++)
	{
		if (name == _names[i])
		{
			return i;
		}
	}
	return -1;
}

void ConsoleInteractor::CreateShape() const
{
	Factory factory;
	string name;
	int countVertex;
	cout << "name the Shape\n";
	cin >> name;
	cout << "number of Vertex?\n";
	cin >> countVertex;
	Point* dots = new Point[countVertex];
	cout << "Enter dots\n";

	for (int i = 0; i < countVertex; i++)
	{
		cout << "\n" << i + 1 << ") x: \n>>";
		cin >> dots[i].x;
		cout << "\n" << i + 1 << ") y: \n>>";
		cin >> dots[i].y;
	}
	
	bool FreePlace = false;
	int index = 0;
	for (int i = 0; i < _count && !FreePlace; i++)
	{
		if (_names[i] == "")
		{
			FreePlace = true;
			index = i;
		}
	}



	if (FreePlace)
	{
		Shape* shape = nullptr;

		try
		{
			shape = factory.createShape(dots,countVertex);
			_names[index] = name;
			_storage[index] = shape;
		}
		catch (const std::logic_error & src)
		{
			cout << src.what() << "\n";
		}
	}
	else
	{
		cout << "you run out of place, delete shape\n";
	}
	delete[] dots;
}

void ConsoleInteractor::DeleteShape() const
{
	string name;
	cout << "name to delete?\n";
	cin >> name;

	if (GetIndex(name) != -1)
	{
		cout << "Can't find this name";
	}
	else
	{
		_names[GetIndex(name)] = "";
		delete _storage[GetIndex(name)];
		_storage[GetIndex(name)] = nullptr;
	}
}

void ConsoleInteractor::PrintShape() const
{
	string name;
	cout << "Name to print?\n";
	cin >> name;
	if (GetIndex(name) != -1)
	{
		cout << _storage[GetIndex(name)]->ToString() << "\n";
	}
	else
	{
		cout << "Name is not found\n";
	}
}

void ConsoleInteractor::Compare() const
{
	Operation operation;
	string name1, name2;
	cout << "Name of first shape\n>>";
	cin >> name1;
	cout << "Name of second shape\n>>";
	cin >> name2;
	if ((GetIndex(name1) && GetIndex(name2)) != -1)
	{
		switch (operation.Compare(*_storage[GetIndex(name1)], *_storage[GetIndex(name2)]))
		{
		case 1:
			cout << "First shape larger than second\n";
			break;
		case -1:
			cout << "Second shape larger than first\n";
			break;
		case 0:
			cout << "Shapes have the same area\n";
			break;
		}
	}
	else
	{
		cout << "Name in not found\n";
	}
}

void ConsoleInteractor::Move() const
{
	string name;
	int x , y;
	cout << "Name of shape?\n";
	cin >> name;
	if (GetIndex(name) != -1)
	{
		cout << "How much x and y\n>>";
		cin >> x >> y;
		_storage[GetIndex(name)]->Move(x, y);
	}
	else
	{
		cout << "Name is not found\n";
	}
}

void ConsoleInteractor::Rotate() const
{
	string name;
	int angle;
	cout << "Name of shape\n>>";
	cin >> name;
	if (GetIndex(name) != -1)
	{
		cout << "Enter angle\n>>";
		cin >> angle;
		_storage[GetIndex(name)]->Rotate(angle);
	}
	else
	{
		cout << "Name is not found\n";
	}
}

void ConsoleInteractor::Area() const
{
	string name;
	cout << "Name of shape\n>>";
	cin >> name;
	if (GetIndex(name) != -1)
	{
		cout << "Area of this shape is " << _storage[GetIndex(name)]->Area() << "\n";
	}
	else
	{
		cout << "Name is not found\n";
	}
}

void ConsoleInteractor::IsIntersect() const
{
	Operation operation;
	string name1, name2;
	cout << "Name of first shape\n>>";
	cin >> name1;
	cout << "Name of second shape\n>>";
	cin >> name2;
	if (GetIndex(name1) != -1 && (GetIndex(name2)) != -1)
	{
		if (operation.IsIntersect(*_storage[GetIndex(name1)], *_storage[GetIndex(name2)]))
		{
			cout << "Shapes intersect\n";
		}
		else
		{
			cout << "Shapes don't intersect\n";
		}
	}
	else
	{
		cout << "Name in not found\n";
	}
}

void ConsoleInteractor::CenterOfGravity() const
{
	string name;
	cout << "Name of shape\n>>";
	cin >> name;
	if (GetIndex(name) != -1)
	{
		Point centerOfGraviry = _storage[GetIndex(name)]->CenterOfGravity();
		cout << "Center of gravity this shape " << centerOfGraviry.x << " " << centerOfGraviry.y << "\n";
	}
	else
	{
		cout << "Name is not found\n";
	}
}

void ConsoleInteractor::IsInclude() const
{
	Operation operation;
	string name1, name2;
	cout << "Name of first shape\n>>";
	cin >> name1;
	cout << "Name of second shape\n>>";
	cin >> name2;
	if (GetIndex(name1) != -1 && (GetIndex(name2) != -1))
	{
		if (operation.IsInclude(*_storage[GetIndex(name1)], *_storage[GetIndex(name2)]))
		{
			cout << "Shapes is include\n";
		}
		else
		{
			cout << "Shapes don't include\n";
		}
	}
	else
	{
		cout << "Name in not found\n";
	}
}

void ConsoleInteractor::Help() const
{
	cout << "1 - Create new Shape\n 2 - Help\n 3 - Compare\n 4 - IsInclude \n 5 - IsIntersect\n 6 - Print Shape\n 7 - Move\n 8 - Rotate\n 9 - Area\n 10 - Get Center\n 11 - Delete Shape\n 12 - Exit\n";
}

void ConsoleInteractor::Init() const
{
	bool flag = true;
	while (flag)
	{
		int code;
		cout << "Enter \"2\" - Help\n";
		cout << ">> ";
		cin >> code;

		switch (code)
		{
		case 1:
			CreateShape();
			break;
		case 2:
			Help();
			break;
		case 3:
			Compare();
			break;
		case 4:
			IsInclude();
			break;
		case 5:
			IsIntersect();
			break;
		case 6:
			PrintShape();
			break;
		case 7:
			Move();
			break;
		case 8:
			Rotate();
			break;
		case 9:
			Area();
			break;
		case 10:
			CenterOfGravity();
			break;
		case 11:
			DeleteShape();
			break;
		case 12:
			flag = false;
			break;
		}
	}
}