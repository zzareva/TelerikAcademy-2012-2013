using System;

class ExchangeValues
{
	static void Main()
	{
		Console.WriteLine("Please enter the first integer number.");
		int number1 = GetNumber();
		Console.WriteLine("Please enter the second integer number.");
		int number2 = GetNumber();
		if (number1 > number2)
		{
			int tempNumber = number1;
			number1 = number2;
			number2 = tempNumber;
		}
		Console.WriteLine("Number 1 is {0}\nNumber 2 is {1}",number1,number2);
	}
	static int GetNumber()
	{
		int number;
		while(!int.TryParse(Console.ReadLine(),out number))
		{
			Console.WriteLine("Please enter an integer number.");
		}
		return number;
	}
}
