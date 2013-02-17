using System;

class TriangleSurface
{
	private static double DegreeToRadian(double angle)
	{
		return Math.PI * angle / 180.0;
	}
	
	private static double CalculateSurfaceByThreeSides(double sideA, double sideB, double sideC)
	{
		double semiperimeter = (sideA + sideB + sideC) / 2;
		double surface = Math.Sqrt(semiperimeter * (semiperimeter - sideA) * (semiperimeter - sideB) * (semiperimeter - sideC));
		return surface;
	}

	private static double CalculateSurfaceBySidesAndAngle(double sideA, double sideB, double angle)
	{
		return sideA * sideB * Math.Sin(DegreeToRadian(angle)) / 2;
	}

	private static double CalculateSurfaceBySideAndAltitude(double sideA, double altitude)
	{
		return (sideA * altitude) / 2;
	}

	private static double GetSide(string element)
	{
		double side = 0;
		do
		{
			Console.WriteLine("Please enter the length of {0}.",element);
		}
		while(!double.TryParse(Console.ReadLine(), out side) || side < 0);
		return side;
	}
	private static double GetAngle()
	{
		double angle = 0;
		do
		{
			Console.WriteLine("Please enter the angle between sides A and B (0 < angle < 180)");
		}
		while (!double.TryParse(Console.ReadLine(), out angle) || angle < 0 || angle > 180);
		return angle;
	}
	static void Main()
	{
		Console.WriteLine("This program is now going to calculate a triangle's surface using three different formulas.");
		double sideA = GetSide("side A");
		double sideB = GetSide("side B");
		double sideC = GetSide("side C");
		double altitudeA = GetSide("the altitude towards side A");
		double angleA = GetAngle();
		Console.WriteLine("Surface claculated based on the three sides:");
		Console.WriteLine(CalculateSurfaceByThreeSides(sideA,sideB,sideC));
		Console.WriteLine("Surface claculated based on sides A, B, and the angle between them:");
		Console.WriteLine(CalculateSurfaceBySidesAndAngle(sideA, sideB, angleA));
		Console.WriteLine("Surface claculated based on side A and the altitude:");
		Console.WriteLine(CalculateSurfaceBySideAndAltitude(sideA, altitudeA));
	}
}
