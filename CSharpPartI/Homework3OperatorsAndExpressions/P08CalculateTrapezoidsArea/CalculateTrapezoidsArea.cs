using System;

class CalculateTrapezoidsArea
{
	static void Main()
	{
		Console.WriteLine("Please enter trapezoid's side a.");
		float sideA = getValue();
		Console.WriteLine("Please enter trapezoid's side b.");
		float sideB = getValue();
		Console.WriteLine("Please enter trapezoid's height.");
		float height = getValue();
		float area = (sideA + sideB) * height;
		Console.WriteLine("The trapezoid's area is {0}",area);

	}
	static float getValue()
	{
		float value;
		while (!float.TryParse(Console.ReadLine(), out value))
		{
			Console.WriteLine("Please enter correct floating point number.");
		}
		return value;
	}
}
