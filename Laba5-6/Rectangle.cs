using System;
using System.Collections.Generic;
using System.Text;

namespace Laba56
{
    public class Rectangle : Shape
    {
		public Rectangle(Point[] cords)
		{
			_countSides = 4;
			_cords = new Point[_countSides];
			_lengthSide = new double[_countSides];
			Array.Copy(cords, _cords, _countSides);

			for (int i = 0; i < _countSides; i++)
			{
				_lengthSide[i] = GetLength(cords[i], cords[(i + 1) % _countSides]);
			}

			if (!TrueShape())
			{
				throw new ArgumentOutOfRangeException("WRONG_RECTANGLE");
			}
		}
        public override bool TrueShape()
        {
			if (_lengthSide[0] == _lengthSide[2] && _lengthSide[1] == _lengthSide[3] && (_lengthSide[0] != 0 && _lengthSide[1] != 0))
			{
				return true;
			}
			return false;
		}

        public override double Area()
        {
			return _lengthSide[0] * _lengthSide[1];
		}

        public override Point CenterOfGravity()
        {
			Point centerOfGravity;
			centerOfGravity.x = (_cords[0].x + _cords[1].x + _cords[2].x + _cords[3].x) / _countSides;
			centerOfGravity.y = (_cords[0].y + _cords[1].y + _cords[2].y + _cords[3].y) / _countSides;
			return centerOfGravity;
		}

        public override double GetRadius()
        {
			double radius;
			Point centerOfGravity = CenterOfGravity();
			radius = GetLength(centerOfGravity, _cords[0]);
			return radius;
		}
    }
}
