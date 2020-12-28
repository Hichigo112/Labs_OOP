#pragma once
#include "Shape.h"

class Triangle : public Shape
{
public:
	Triangle(const Point* cords) : Shape(cords, 3) { TrueShape(); }

	double Area() const override;
	Point CenterOfGravity() const override;
	void TrueShape() const override;
	double GetRadius() const override;
private:
	double Perimeter() const;
};