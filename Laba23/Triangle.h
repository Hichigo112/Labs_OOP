#pragma once
#include "Shape.h"

class Triangle : public Shape
{
public:
	Triangle(const Point* cords);

	double Area() const override;
	Point CenterOfGravity() const override;
	bool TrueShape() const override;
	double GetRadius() const override;
private:
	double Perimeter() const;
};