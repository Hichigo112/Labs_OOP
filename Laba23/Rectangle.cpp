#include "Rectangle.h"
#include <stdexcept>

using std::logic_error;


void Rectangle::TrueShape() const
{
	if (_lengthSide[0] == _lengthSide[2] && _lengthSide[1] == _lengthSide[3] && (_lengthSide[0] != 0 && _lengthSide[1] != 0))
	{
		return;
	}
	throw logic_error("WRONG_RECTANGLE");
}

double Rectangle::Area() const
{
	return _lengthSide[0] * _lengthSide[1];
}

Point Rectangle::CenterOfGravity() const
{
	Point centerOfGravity;
	centerOfGravity.x = (_cords[0].x + _cords[1].x + _cords[2].x + _cords[3].x) / _countSides;
	centerOfGravity.y = (_cords[0].y + _cords[1].y + _cords[2].y + _cords[3].y) / _countSides;
	return centerOfGravity;
}

double Rectangle::GetRadius() const
{
	double radius;
	Point centerOfGravity = CenterOfGravity();
	radius = GetLength(centerOfGravity, _cords[0]);
	return radius;
}