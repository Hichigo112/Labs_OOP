#pragma once
#include "Shape.h"

class Rectangle : public Shape
{
public:
	Rectangle(const Point* cords) : Shape(cords, 4) { TrueShape(); }

	double Area() const override;
	Point CenterOfGravity() const override;
	void TrueShape() const override;
	double GetRadius() const override;
};