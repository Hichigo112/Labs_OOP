#pragma once
#include "Rectangle.h"
#include "Triangle.h"

class Factory
{
public:
	Shape* createShape(const Point* cords, int number);
	virtual ~Factory() {}
};