#include "Triangle.h"
#include <stdexcept>

using std::logic_error;


void Triangle::TrueShape() const
{
	if ((_lengthSide[0] + _lengthSide[1] > _lengthSide[2]) && (_lengthSide[1] + _lengthSide[2] > _lengthSide[0])\
		&& (_lengthSide[2] + _lengthSide[0] > _lengthSide[1]))
	{
		return;
	}
	throw logic_error("WRONG_TRIANGLE");
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