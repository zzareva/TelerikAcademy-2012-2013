using System;

class Trapezoid
{
	static void Main()
	{
		byte topSideWidth = byte.Parse(Console.ReadLine());
		for (byte j = 0; j < topSideWidth + 1; j++)
		{
			for (byte i = 0; i < topSideWidth * 2; i++) 
			{
				if (j == 0 && i > topSideWidth)
				{
					Console.Write('*');
				}
				else if (j == topSideWidth)
				{
					Console.Write('*');
				}
				else if (i == topSideWidth * 2 - 1)
				{
					Console.Write('*');
				}
				else if (i == topSideWidth - j)
				{
					Console.Write('*');
				}
				else
				{
					Console.Write('.');
				}
			}
			Console.WriteLine();
		}
		
	}
}
