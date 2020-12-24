#include "Factory.h"
#include <stdexcept>
using std::logic_error;

Shape* Factory::createShape(Point* cords, int number)
{
	if (number == 3)
	{
		return new Triangle(cords);
	}
	else if (number == 4)
	{
		return new Rectangle(cords);
	}
	else
	{
		throw logic_error("WRONG_SHAPE");
	}
}