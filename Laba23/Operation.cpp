#include "Operation.h"

int Operation::Compare(const Shape& shape1, const Shape& shape2) const
{
	double area1 = shape1.Area();
	double area2 = shape2.Area();

	if (area1 > area2)
	{
		return 1;
	}
	else if (area1 < area2)
	{
		return -1;
	}
	return 0;
}

double Operation::GetLength(const Point& dot1, const Point& dot2) const
{
	double length = sqrt(pow(dot2.x - dot1.x, 2) + pow(dot2.y - dot1.y, 2));
	return length;
}

bool Operation::IsIntersect(const Shape& shape1, const Shape& shape2) const
{
	double radiusF = shape1.GetRadius();
	double radiusS = shape2.GetRadius();

	Point centerF = shape1.CenterOfGravity();
	Point centerS = shape2.CenterOfGravity();
	double length = GetLength(centerF, centerS);

	if (radiusF + radiusS >= length && length > abs(radiusF - radiusS))
	{
		return true;
	}
	else
	{
		return false;
	}
}

bool Operation::IsInclude(const Shape& shape1, const Shape& shape2) const
{
	double radiusF = shape1.GetRadius();
	double radiusS = shape2.GetRadius();

	Point centerF = shape1.CenterOfGravity();
	Point centerS = shape2.CenterOfGravity();
	double length = GetLength(centerF, centerS);

	if (length <= abs(radiusF - radiusS))
	{
		return true;
	}
	return false;
}