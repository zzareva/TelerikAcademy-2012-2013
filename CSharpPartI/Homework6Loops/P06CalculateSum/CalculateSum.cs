using System;

class CalculateSum
{
	static int GetNumber()
	{
		int number;
		do
		{
			Console.WriteLine("Please enter a valid integer number.");
		}
		while (!int.TryParse(Console.ReadLine(), out number));
		return number;
	}

	static void Main()
	{
		int numberN = GetNumber();
		int numberX = GetNumber();
		double theSum = 1;
		double powValue = 1;
		for (int i = 1; i <= numberN; i++)
		{
			long factoriel = 1L;
			powValue *= numberX;
			for(int j = 1; j <= i; j++)
			{
				factoriel *= j;
			}
			theSum += factoriel / powValue;
		}
		Console.WriteLine("Result: {0}", theSum);
	}
}
