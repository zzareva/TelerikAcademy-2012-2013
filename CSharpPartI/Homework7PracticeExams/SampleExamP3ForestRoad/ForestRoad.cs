using System;

class ForestRoad
{
	static void Main()
	{
		int n = int.Parse(Console.ReadLine());
		for (int posY = 0; posY < n; posY++)
		{
			for(int posX = 0; posX < n; posX++)
			{
				Console.Write("{0}",(posY==posX) ? '*' : '.');
			}
			Console.WriteLine("");
		}
		for (int y = n - 1; y > 0; y--)
		{
			for (int x = n - 1; x >= 0; x--)
			{
				Console.Write("{0}", (x == n - y) ? '*' : '.');
			}
			Console.WriteLine("");
		}
	}
}
