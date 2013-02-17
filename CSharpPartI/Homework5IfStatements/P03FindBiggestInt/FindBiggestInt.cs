using System;


class FindBiggestInt
{
	static void Main()
	{
		Console.WriteLine("Please enter number 1 (integer)");
		int number1 = GetNumber();
		Console.WriteLine("Please enter number 2 (integer)");
		int number2 = GetNumber();
		Console.WriteLine("Please enter number 3 (integer)");
		int number3 = GetNumber();
		int biggestNumber = number1;
		if (number2 > number1)
		{
			biggestNumber = number2;
		}
		if (number3 > number2)
		{
			biggestNumber = number3;
		}
			Console.WriteLine("The biggest number is {0}",biggestNumber);
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
