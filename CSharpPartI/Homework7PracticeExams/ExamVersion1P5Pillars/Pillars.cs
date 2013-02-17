using System;

class Pillars
{
	static void Main()
	{
		int[] numbers = new int[8];
		int[] onesPerColumn = { 0, 0, 0, 0, 0, 0, 0, 0 };
		for (byte i = 0; i <= 7; i++)
		{
			numbers[i] = byte.Parse(Console.ReadLine());
		}
		for (sbyte row = 7; row >= 0; row--)
		{
			int number = numbers[row];
			for (sbyte col = 0; col < 8; col++)
			{
				if (((number >> col) & 1) == 1)
				{
					onesPerColumn[col]++;
				}
			}

		}
		int sumLeftPart;
		int sumRightPart;
		for (sbyte pillar = 7; pillar >= 0; pillar--)
		{
			sumLeftPart = 0;
			sumRightPart = 0;
			for (sbyte currentColumn = 7; currentColumn >= 0; currentColumn--)
			{
				if (currentColumn > pillar)
					sumLeftPart += onesPerColumn[currentColumn];
				else if (currentColumn < pillar)
					sumRightPart += onesPerColumn[currentColumn];
			}
			if(sumLeftPart == sumRightPart)
			{
				Console.WriteLine(pillar);
				Console.WriteLine(sumRightPart);
				break;
			}
			if(pillar == 0)
				Console.WriteLine("No");
		}
	}
}
