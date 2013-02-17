using System;

class ShipDamage
{
	static int score = 0;
	static int posSX1;
	static int posSY1;
	static int posSX2;
	static int posSY2;
	static int posH;
	static int posCX1;
	static int posCY1;
	static int posCX2;
	static int posCY2;
	static int posCX3;
	static int posCY3;

	static void Main()
	{
		posSX1 = int.Parse(Console.ReadLine());
		posSY1 = int.Parse(Console.ReadLine());
		posSX2 = int.Parse(Console.ReadLine());
		posSY2 = int.Parse(Console.ReadLine());
		posH = int.Parse(Console.ReadLine());
		posCX1 = int.Parse(Console.ReadLine());
		posCY1 = int.Parse(Console.ReadLine());
		posCX2 = int.Parse(Console.ReadLine());
		posCY2 = int.Parse(Console.ReadLine());
		posCX3 = int.Parse(Console.ReadLine());
		posCY3 = int.Parse(Console.ReadLine());
		posCY1 = posH + (posH - posCY1);
		posCY2 = posH + (posH - posCY2);
		posCY3 = posH + (posH - posCY3);
		if (posSX1 > posSX2)
		{
			SwapX();
		}
		if (posSY1 < posSY2)
		{
			SwapY();
		}
		GetScore(posCX1, posCY1);
		GetScore(posCX2, posCY2);
		GetScore(posCX3, posCY3);
		Console.WriteLine("{0}%", score);
	}
	static void SwapX()
	{
		int temp = posSX1;
		posSX1 = posSX2;
		posSX2 = temp;
	}
	static void SwapY()
	{
		int temp = posSY1;
		posSY1 = posSY2;
		posSY2 = temp;
	}
	static void GetScore(int x, int y)
	{
		if ((x == posSX1 && y == posSY1) || (x == posSX1 && y == posSY2) || (x == posSX2 && y == posSY2) || (x == posSX2 && y == posSY1))
		{
			score += 25;
		}
		else if ((x > posSX1 && x < posSX2) && (y > posSY2 && y < posSY1))
		{
			score += 100;
		}
		else if (x < posSX1 || x > posSX2 || y > posSY1 || y < posSY2)
		{
			score += 0;
		}
		else
		{
			score += 50;
		}
	}
}