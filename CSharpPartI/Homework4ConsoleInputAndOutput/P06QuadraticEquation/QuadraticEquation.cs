using System;

class QuadraticEquation
{
	static void Main()
	{
		Console.WriteLine("Please enter number a.");
		double coefficientA = getNumber();
		Console.WriteLine("Please enter number b.");
		double coefficientB = getNumber();
		Console.WriteLine("Please enter number c.");
		double coefficientC = getNumber();
		double root1 = 0;
		double root2 = 0;
		double discrimant = Math.Pow(coefficientB, 2) - 4 * coefficientA * coefficientC;
		if (discrimant < 0)
		{
			Console.WriteLine("The equation doesn't have any real roots");
		}
		else if(discrimant ==0)
		{
			root1 = -(coefficientB / (2 * coefficientA));
			Console.WriteLine("There is only one real root and it is: {0}", root1);
		}
		else
		{
			root1 = (-coefficientB + discrimant) / (2 * coefficientA);
			root2 = (-coefficientB - discrimant) / (2 * coefficientA);
			Console.WriteLine("The first real root is: {0}", root1);
			Console.WriteLine("The second real root is: {0}", root2);
		}
	}
	static double getNumber()
	{
		double number;
		while (!double.TryParse(Console.ReadLine(), out number))
		{
			Console.WriteLine("Please enter a number.");
		}
		return number;
	}
}
