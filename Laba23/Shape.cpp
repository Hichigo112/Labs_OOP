#include "Shape.h"

Shape::~Shape()
{
	delete[] _cords;
	delete[] _lengthSide;
}

Shape::Shape(const Point* cords, int countSide): PI(acos(-1)), _countSides(countSide)
{
	_cords = new Point[_countSides];
	_lengthSide = new double[_countSides];
	memcpy(_cords, cords, sizeof(Point) * _countSides);

	for (int i = 0; i < _countSides; i++)
	{
		_lengthSide[i] = GetLength(cords[i], cords[(i + 1) % _countSides]);
	}
}

void Shape::Move(int x, int y)
{
	for (int i = 0; i < _countSides; i++)
	{
		_cords[i].x += x;
		_cords[i].y += y;
	}
}

double Shape::GetLength(const Point& dot1, const Point& dot2) const
{
	double length = sqrt(pow(dot2.x - dot1.x, 2) + pow(dot2.y - dot1.y, 2));
	return length;
}

string Shape::ToString() const
{
	std::string res = "";
	for (int i = 0; i < _countSides; i++)
	{
		res += std::to_string(i) + ") - x: " + std::to_string(_cords[i].x) + " y: " + std::to_string(_cords[i].y) + "\n";
	}
	return res;
}

void Shape::Rotate(const int angle)
{
	Point centerOfGravity = CenterOfGravity();
	double sinA = sin((double)angle * PI / 180);
	double cosA = cos((double)angle * PI / 180);

	for (int i = 0; i < _countSides; i++)
	{
		_cords[i].x = (_cords[i].x - centerOfGravity.x) * cosA - (_cords[i].y - centerOfGravity.y) * sinA + centerOfGravity.x;
		_cords[i].y = (_cords[i].x - centerOfGravity.x) * sinA - (_cords[i].y - centerOfGravity.y) * cosA + centerOfGravity.y;
	}
}