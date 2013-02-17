using System;

class SumAndPrint
{
	static void Main()
	{
		Console.WriteLine("Please circle's radius.");
		float radius = getIntNumber();
		Console.WriteLine("Circle's perimeter is {0:F2}", 2 * Math.PI * radius);
		Console.WriteLine("Circle's area is {0:F2}", Math.PI * Math.Pow(radius,2));
	}
	static float getIntNumber()
	{
		
		float r;
		while(!float.TryParse(Console.ReadLine(), out r) || r <= 0)
		{
			Console.WriteLine("Please enter positive floating point number.");
		}
		return r;
	}
}
