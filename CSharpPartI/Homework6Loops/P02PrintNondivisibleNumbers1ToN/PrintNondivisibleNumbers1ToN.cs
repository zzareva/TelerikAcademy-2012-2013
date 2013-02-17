using System;

class PrintNondivisibleNumbers1ToN
{
	static void Main()
	{
		int theNumber = GetNumber();
		Console.Clear();
		Console.WriteLine("The numbers from 1 to {0}, that are not divisible by 3 and 7 at the same time are:", theNumber);
		for (int i = 1; i <= theNumber; i++)
		{
			if (i % 3 != 0 || i % 7 != 0)
			{
				Console.WriteLine(i);
			}
		}
	}

	static int GetNumber()
	{
		int number;
		do
		{
			Console.WriteLine("Please enter a positive integer number.");
		}
		while (!int.TryParse(Console.ReadLine(), out number) || number < 1);
		return number;
	}
}
