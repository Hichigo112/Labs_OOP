using System;
using System.Collections.Generic;
using System.Text;

namespace Laba56
{
    public class Operation
    {
        public int Compare(Shape shape1, Shape shape2) 
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

		public bool IsIntersect(Shape shape1, Shape shape2)
        {
			double radiusF = shape1.GetRadius();
			double radiusS = shape2.GetRadius();

			Point centerF = shape1.CenterOfGravity();
			Point centerS = shape2.CenterOfGravity();
			double length = GetLength(centerF, centerS);

			if (radiusF + radiusS >= length && length > Math.Abs(radiusF - radiusS))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public double GetLength(Point dot1, Point dot2)
        {
			double length = Math.Sqrt(Math.Pow(dot2.x - dot1.x, 2) + Math.Pow(dot2.y - dot1.y, 2));
			return length;
		}

		public bool IsInclude(Shape shape1, Shape shape2)
        {
			double radiusF = shape1.GetRadius();
			double radiusS = shape2.GetRadius();

			Point centerF = shape1.CenterOfGravity();
			Point centerS = shape2.CenterOfGravity();
			double length = GetLength(centerF, centerS);

			if (length <= Math.Abs(radiusF - radiusS))
			{
				return true;
			}
			return false;
		}
	}
}
