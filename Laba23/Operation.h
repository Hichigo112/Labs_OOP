#pragma once
#include "Shape.h"

class Operation
{
public:
	int Compare(const Shape& shape1, const Shape& shape2) const;
	bool IsIntersect(const Shape& shape1, const Shape& shape2) const;
	bool IsInclude(const Shape& shape1, const Shape& shape2) const;

	double GetLength(const Point& dot1, const Point& dot2) const;
};