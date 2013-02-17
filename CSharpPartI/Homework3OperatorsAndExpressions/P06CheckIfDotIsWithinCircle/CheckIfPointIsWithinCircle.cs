using System;

class CheckIfPointIsWithinCircle
{
	static void Main()
	{
		bool result = false;
		const float radius = 5f;
		float positionX = 0f;
		float positionY = 0f;
		Console.WriteLine("Please position X.");
		positionX = getPosition();
		Console.WriteLine("Please position Y.");
		positionY = getPosition();

		result = ((Math.Pow(positionX,2) + Math.Pow(positionY,2)) <= Math.Pow(radius,2));
		Console.WriteLine(result == true ? "This point is within circle's area." : "This point is outside circle's area.");
	}

	static float getPosition()
	{
		float position;
		while (!float.TryParse(Console.ReadLine(), out position))
		{
			Console.WriteLine("Please enter correct value.");
		}
		return position;
	}
}
