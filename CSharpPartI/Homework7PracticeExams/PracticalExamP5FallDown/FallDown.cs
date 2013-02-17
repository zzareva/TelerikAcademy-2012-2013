using System;

class FallDown
{
	static void Main()
	{
		int[] numbers = new int[8];
		int[] onesPerColumn = { 0, 0, 0, 0, 0, 0, 0, 0 };
		for (byte i = 0; i <= 7; i++)
		{
			numbers[i] = byte.Parse(Console.ReadLine());
		}
		for (sbyte numberIndex = 7; numberIndex >= 0; numberIndex--)
		{
			int number = numbers[numberIndex];
			for (sbyte col = 0; col < 8; col++)
			{
				if (((number >> col) & 1) == 1)
				{
					onesPerColumn[col]++;
				}
			}

		}
		int[] fallDownNumbers = { 0, 0, 0, 0, 0, 0, 0, 0 };
		for (sbyte column = 7; column >= 0; column--)
		{
			int count = onesPerColumn[column];
			for (sbyte row = 7; row > 7 - count; row--)
			{
				int currentNumber = fallDownNumbers[row];
				fallDownNumbers[row] = (1 << column) | currentNumber;
			}
		}
		foreach (int p in fallDownNumbers)
		{
			Console.WriteLine(p);
		}
	}
}