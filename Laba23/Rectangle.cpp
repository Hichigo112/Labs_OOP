#include "Rectangle.h"
#include <stdexcept>

using std::logic_error;

Rectangle::Rectangle(const Point* cords)
{
	_countSides = 4;
	_cords = new Point[_countSides];
	_lengthSide = new double[_countSides];
	memcpy(_cords, &cords, sizeof(Point) * _countSides);

	for (int i = 0; i < _countSides; i++)
	{
		_lengthSide[i] = GetLength(_cords[i], _cords[(i + 1) % _countSides]);
	}

	if (!TrueShape())
	{
		throw logic_error("WRONG_RECTANGLE");
	}
}

bool Rectangle::TrueShape() const
{
	if (_lengthSide[0] == _lengthSide[2] && _lengthSide[1] == _lengthSide[3] && (_lengthSide[0] != 0 && _lengthSide[1] != 0))
	{
		return true;
	}
	return false;
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