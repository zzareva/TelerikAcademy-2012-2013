using System;

class CartesianCoordinateSystem
{
	static void Main()
	{
		int theResult = 0;
		decimal posX = decimal.Parse(Console.ReadLine());
		decimal posY = decimal.Parse(Console.ReadLine());
		theResult = (posX == 0 && posY == 0) ? 0 :
			(posX > 0 && posY > 0) ? 1 :
			(posX < 0 && posY > 0) ? 2 :
			(posX < 0 && posY < 0) ? 3 :
			(posX > 0 && posY < 0) ? 4 :
			(posX == 0) ? 5 :
			(posY == 0) ? 6 : 0;
		Console.WriteLine(theResult);
	}
}