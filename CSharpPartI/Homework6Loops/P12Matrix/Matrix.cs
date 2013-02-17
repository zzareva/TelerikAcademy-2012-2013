using System;

class Matrix
{
	static void Main()
	{
		int theNumber = GetNumber();
		for (int row = 1; row <= theNumber; row++)
		{
			for (int column = row + 0; column < row + theNumber; column++)
			{
				Console.Write("|{0,2}", column);
			}
				Console.WriteLine("|");
		}
	}
	static int GetNumber()
	{
		int number;
		do
		{
			Console.WriteLine("Please enter a number between 2 and 20.");
		}
		while (!int.TryParse(Console.ReadLine(), out number) || number < 2 || number > 20);
		return number;
	}
}
