using System;
using System.Collections.Generic;
using System.Text;

namespace Laba56
{
	public class Triangle : Shape
	{
		public Triangle(Point[] cords) : base (cords, 3) { TrueShape(); }


		public override bool TrueShape()
        {
			if ((_lengthSide[0] + _lengthSide[1] > _lengthSide[2]) && (_lengthSide[1] + _lengthSide[2] > _lengthSide[0]) && (_lengthSide[2] + _lengthSide[0] > _lengthSide[1]))
			{
				return true;
			}
			return false;
		}

        public override double Area()
        {
			double area, semiPerimeter;
			semiPerimeter = Perimeter() / 2;
			area = Math.Sqrt(semiPerimeter * (semiPerimeter - _lengthSide[0]) * (semiPerimeter - _lengthSide[1]) * (semiPerimeter - _lengthSide[2]));
			return area;
		}

        public override double GetRadius()
        {
			double semiPerimeter = Perimeter() / 2;
			double radius;
			radius = (_lengthSide[0] * _lengthSide[1] * _lengthSide[2]) / 4 * Math.Sqrt(semiPerimeter * (semiPerimeter - _lengthSide[0]) * (semiPerimeter - _lengthSide[1]) * (semiPerimeter - _lengthSide[2]));
			return radius;
		}

        public override Point CenterOfGravity()
        {
			Point centerOfGravity;
			centerOfGravity.x = ((_cords[0].x + _cords[1].x + _cords[2].x) / 3);
			centerOfGravity.y = ((_cords[0].y + _cords[1].y + _cords[2].y) / 3);
			return centerOfGravity;
		}

		public double Perimeter()
        {
			double perimeter = _lengthSide[0] + _lengthSide[1] + _lengthSide[2];
			return perimeter;
		}
    }
}
