using System;

class FighterAttack
{
	static int pX1 = int.Parse(Console.ReadLine());
	static int pY1 = int.Parse(Console.ReadLine());
	static int pX2 = int.Parse(Console.ReadLine());
	static int pY2 = int.Parse(Console.ReadLine());

	static void SwapX()
	{
		int temp = pX2;
		pX2 = pX1;
		pX1 = temp;
	}
	static void SwapY()
	{
		int temp = pY2;
		pY2 = pY1;
		pY1 = temp;
	}
	static byte GetPointsFromHit(int x, int y, byte points)
	{
		if (x >= pX1 && x <= pX2 && y >= pY2 && y <= pY1)
		{
			return points;
		}
		else
		{
			return 0;
		}
	}
	static void Main()
	{
		int fX = int.Parse(Console.ReadLine());
		int fY = int.Parse(Console.ReadLine());
		int distance = int.Parse(Console.ReadLine());
		if(pX1 > pX2)
			SwapX();
		if(pY2 > pY1)
			SwapY();
		int hitX = fX + distance;
		int hitY = fY;

		int theDamage = 0;
		theDamage += GetPointsFromHit(hitX, hitY, 100);
		theDamage += GetPointsFromHit(hitX + 1, hitY, 75);
		theDamage += GetPointsFromHit(hitX, hitY + 1, 50);
		theDamage += GetPointsFromHit(hitX, hitY - 1, 50);
		Console.WriteLine("{0}%",theDamage);
	}
}
