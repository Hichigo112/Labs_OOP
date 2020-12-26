#include "Triangle.h"
#include <stdexcept>

using std::logic_error;

Triangle::Triangle(const Point* cords)
{
	_countSides = 3;
	_cords = new Point[_countSides];
	_lengthSide = new double[_countSides];
	memcpy(_cords, cords, sizeof(Point) * _countSides);

	for (int i = 0; i < _countSides; i++)
	{
		_lengthSide[i] = GetLength(cords[i], cords[(i+1)%_countSides]);
	}

	if (!TrueShape())
	{
		throw logic_error("WRONG_TRIANGLE");
	}
}
bool Triangle::TrueShape() const
{
	if ((_lengthSide[0] + _lengthSide[1] > _lengthSide[2]) && (_lengthSide[1] + _lengthSide[2] > _lengthSide[0])\
		&& (_lengthSide[2] + _lengthSide[0] > _lengthSide[1]))
	{
		return true;
	}
	return false;
}

double Triangle::Perimeter() const
{
	double perimeter = _lengthSide[0] + _lengthSide[1] + _lengthSide[2];
	return perimeter;
}

double Triangle::Area() const
{
	double area, semiPerimeter;
	semiPerimeter = Perimeter() / 2;
	area = sqrt(semiPerimeter*(semiPerimeter-_lengthSide[0])*(semiPerimeter - _lengthSide[1])*(semiPerimeter - _lengthSide[2]));
	return area;
}

Point Triangle::CenterOfGravity() const
{
	Point centerOfGravity;
	centerOfGravity.x = ((_cords[0].x + _cords[1].x + _cords[2].x) / 3);
	centerOfGravity.y = ((_cords[0].y + _cords[1].y + _cords[2].y) / 3);
	return centerOfGravity;
}

double Triangle::GetRadius() const
{
	double semiPerimeter = Perimeter() / 2;
	double radius;
	radius = (_lengthSide[0] * _lengthSide[1] * _lengthSide[2]) / 4 * sqrt(semiPerimeter * (semiPerimeter - _lengthSide[0]) * \
		(semiPerimeter - _lengthSide[1]) * (semiPerimeter - _lengthSide[2]));
	return radius;
}