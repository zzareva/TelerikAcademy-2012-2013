using System;

class CheckPointPosition
{
	static void Main()
	{
		bool isWithinCircle = false;
		bool isOutsideRectangular = false;
		const float radius = 3f;
		const float circleCenterX = 1;
		const float circleCenterY = 1;
		const float topPointR = 1f;
		const float leftPointR = -1f;
		const float withtR = 6f;
		const float heightR = 2f;
		Console.WriteLine("Please position X.");
		float positionX = getPosition();
		Console.WriteLine("Please position Y.");
		float positionY = getPosition();

		isWithinCircle = ((Math.Pow(Math.Abs(positionX - circleCenterX), 2) + Math.Pow(Math.Abs(positionY - circleCenterY), 2)) <= Math.Pow(radius, 2));
		isOutsideRectangular = ((positionX < leftPointR) || (positionX > leftPointR + withtR) || (positionY > topPointR) || (positionY < topPointR - heightR));
		Console.WriteLine((isWithinCircle == true && isOutsideRectangular == true)? "This point is within circle's area and outside the rectangular." : "This point is either outside circle's area or within the rectangular");
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
