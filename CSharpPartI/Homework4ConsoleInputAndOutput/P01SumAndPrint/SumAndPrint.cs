using System;

class SumAndPrint
{
	static void Main()
	{
		int number1 = getIntNumber();
		int number2 = getIntNumber();
		int number3 = getIntNumber();
		Console.WriteLine("The sum is {0}", number1 + number2 + number3);
	}
	static int getIntNumber()
	{
		Console.WriteLine("Please enter an integer number");
		int number;
		while(!int.TryParse(Console.ReadLine(), out number))
		{
			Console.WriteLine("Please enter correct integer number.");
		}
		return number;
	}
}
