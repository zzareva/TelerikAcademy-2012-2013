using System;

class CalculateRectangularArea
{
	static void Main()
	{
		float triangleWidth = 0f;
		float triangleHeight = 0f;
		Console.WriteLine("Please enter triangle width.");
		while (!float.TryParse(Console.ReadLine(), out triangleWidth))
		{
			Console.WriteLine("Please enter correct value.");
		}
		Console.WriteLine("Please enter triangle height.");
		while (!float.TryParse(Console.ReadLine(), out triangleHeight))
		{
			Console.WriteLine("Please enter correct value.");
		}
		float triangleArea = triangleHeight*triangleWidth/2;
		Console.WriteLine("The triangle is {0}",triangleArea);
	}
}
