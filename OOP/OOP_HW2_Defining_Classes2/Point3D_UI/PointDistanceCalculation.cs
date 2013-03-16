using System;
using System.Linq;

public static class PointDistanceCalculation
{
	public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
	{
		double pointDistance = 0;
		pointDistance = Math.Sqrt(Math.Pow(firstPoint.X - secondPoint.X, 2) + Math.Pow(firstPoint.Y - secondPoint.Y, 2) + Math.Pow(firstPoint.Z - secondPoint.Z, 2));

		return pointDistance;
	}
}
