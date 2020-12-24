#pragma once
#include "Shape.h"

class Operation
{
public:
	int Compare(Shape& shape1, Shape& shape2) const;
	bool IsIntersect(Shape& shape1, Shape& shape2) const;
	bool IsInclude(Shape& shape1, Shape& shape2) const;

	double GetLength(const Point& dot1, const Point& dot2) const;
};