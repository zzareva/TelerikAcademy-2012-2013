using System;

class PrintNumbers1ToN
{
	static void Main()
	{
		int theNumber = GetNumber();
		Console.Clear();
		Console.WriteLine("And all numbers 1 to {0} are:", theNumber);
		for (int i = 1; i <= theNumber; i++)
		{
			Console.WriteLine(i);
		}
	}

	static int GetNumber()
	{
		int number;
		do
		{
			Console.WriteLine("Please enter a positive integer number (>= 1).");
		}
		while(!int.TryParse(Console.ReadLine(), out number) || number < 1);
		return number;
	}
}
