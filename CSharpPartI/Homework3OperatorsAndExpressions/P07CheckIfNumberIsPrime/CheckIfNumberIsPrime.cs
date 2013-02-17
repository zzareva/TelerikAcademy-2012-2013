using System;

class CheckIfNumberIsPrime
{
	static void Main()
	{
		Console.WriteLine("Please enter positive integer number up to 1000.");
		int givenNumber = getValue();
		bool isPrimeNumber = true;
		for (int k = 2; k <= Math.Sqrt(givenNumber); k++)
		{
			if (givenNumber % k == 0)
			{
				isPrimeNumber = false;
				break;
			}
		}
		Console.WriteLine("isPrimeNumber: {0}", isPrimeNumber);
	}
	static int getValue()
	{
		int value;
		while (!int.TryParse(Console.ReadLine(), out value) || value > 1000 || value < 0)
		{
			Console.WriteLine("Please enter correct integer value (0<= n <=1000).");
		}
		return value;
	}
}
