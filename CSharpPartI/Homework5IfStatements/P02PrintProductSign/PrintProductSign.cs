using System;

class PrintProductSign
{
	static void Main()
	{
		Console.WriteLine("Please enter number 1 (integer)");
		int number1 = GetNumber();
		Console.WriteLine("Please enter number 2 (integer)");
		int number2 = GetNumber();
		Console.WriteLine("Please enter number 3 (integer)");
		int number3 = GetNumber();
		byte countNegativeNumbers = 0;
		if (number1 < 0)
			countNegativeNumbers++;
		if (number2 < 0)
			countNegativeNumbers++;
		if (number3 < 0)
			countNegativeNumbers++;
		if(countNegativeNumbers % 2 == 1)
			Console.WriteLine("The sign of the product is \"-\".");
		else
			Console.WriteLine("The sign of the product is \"+\".");
	}

	static int GetNumber()
	{
		int number;
		while (!int.TryParse(Console.ReadLine(), out number))
		{
			Console.WriteLine("Please enter an integer number.");
		}
		return number;
	}
}
