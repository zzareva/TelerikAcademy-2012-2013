using System;

class MinAndMax
{
	static void Main()
	{
		int count = GetNumberGreaterThanTwo();
		int[] theNumbers = new int[count];
		for(byte i = 0; i<theNumbers.Length; i++)
		{
			theNumbers[i] = GetNumber();
		}
		int min = theNumbers[0];
		int max = theNumbers[0];
		foreach(int k in theNumbers)
		{
			if(k > max)
				max = k;
			else if(k< min)
				min = k;
		}
		Console.WriteLine("The minimal value is {0}",min);
		Console.WriteLine("The maximal value is {0}",max);
	}

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
	static int GetNumberGreaterThanTwo()
	{
		int number;
		do
		{
			Console.WriteLine("Please enter a positive integer number (N > 2).");
		}
		while (!int.TryParse(Console.ReadLine(), out number) || number < 2);
		return number;
	}
}
