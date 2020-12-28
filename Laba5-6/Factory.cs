using System;
using System.Collections.Generic;
using System.Text;

namespace Laba56
{
    class Factory
    {
        public Shape createShape(Point[] cords, int number )
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
				throw new ArgumentOutOfRangeException("WRONG_SHAPE");
			}
		}
    }
}
