#pragma once
#include <iostream>
#include <string>
#include <cmath>
using std::string;


struct Point
{
	double x;
	double y;
};

class Shape
{
public:
	Shape(const Point* cords, int _countSide);
	virtual ~Shape();

	virtual double Area() const = 0;
	virtual Point CenterOfGravity() const = 0;
	void Move(int x, int y);
	void Rotate(const int angle);
	string ToString() const;
	virtual void TrueShape() const = 0;
	virtual double GetRadius() const = 0;

protected:
	Point* _cords;
	double GetLength(const Point& dot1, const Point& dot2) const;
	int _countSides;
	double* _lengthSide;
	const double PI;
};