#pragma once
#include "Shape.h"

class Rectangle : public Shape
{
public:
	Rectangle(const Point* cords);

	double Area() const override;
	Point CenterOfGravity() const override;
	bool TrueShape() const override;
	double GetRadius() const override;
	
};