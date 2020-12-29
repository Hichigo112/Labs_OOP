using System;
using System.Collections.Generic;
using System.Text;

namespace Laba56
{
	public struct Point
	{
		public double x;
		public double y;
		public string GetString()
        {
			return "x: " + x + " y: " + y + "\n";
		}
	}
	abstract public class Shape
	{
		protected Point[] _cords = null;
		protected double GetLength(Point dot1, Point dot2)
		{
			double length = Math.Sqrt(Math.Pow(dot2.x - dot1.x, 2) + Math.Pow(dot2.y - dot1.y, 2));
			return length;
		}
		protected int _countSides;
		protected double[] _lengthSide;
		public Shape(Point[] cords, int countSides)
		{
			_countSides = countSides;
			_cords = new Point[_countSides];
			_lengthSide = new double[_countSides];
			Array.Copy(cords, _cords, _countSides);

			for (int i = 0; i < _countSides; i++)
			{
				_lengthSide[i] = GetLength(cords[i], cords[(i + 1) % _countSides]);
			}
		}

		abstract public Point CenterOfGravity();
		abstract public double Area();
		abstract public bool TrueShape();
		abstract public double GetRadius();

		public void Move(int x, int y)
		{
			for (int i = 0; i < _countSides; i++)
			{
				_cords[i].y += y;
				_cords[i].x += x;
			}
		}
		public void Rotate(int angle)
		{
			Point centerOfGravity = CenterOfGravity();
			double sinA = Math.Sin((Convert.ToDouble(angle) * Math.Acos(-1) / 180));
			double cosA = Math.Cos((Convert.ToDouble(angle) * Math.Acos(-1) / 180));
			for (int i = 0; i < _countSides; i++)
			{
				_cords[i].x -= centerOfGravity.x;
				_cords[i].y -= centerOfGravity.y;

				double newx = _cords[i].x * cosA - _cords[i].y * sinA;
				double newy = _cords[i].x * sinA + _cords[i].y * cosA;

				_cords[i].x = newx + centerOfGravity.x;
				_cords[i].y = newy + centerOfGravity.y;
			}
		}
		public string GetString()
		{
			string res = "";
			for (int i = 0; i < _countSides; i++)
			{
				res += (i) + ") - x: " + string.Format("{0:F3}", _cords[i].x) + " y: " + string.Format("{0:F3}", _cords[i].y) + "\n";
			}
			return res;
		}

	}
}
