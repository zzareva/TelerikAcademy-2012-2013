using System;

class PrintGreaterNumber
{
	static void Main()
	{
		Console.WriteLine("Please enter number 1.");
		int number1 = getNumber();
		Console.WriteLine("Please enter number 2.");
		int number2 = getNumber();
		int result = number1 > number2 ? number1 : number2;
		
		Console.WriteLine("The greater number is: {0}", result);
	}
	static int getNumber()
	{
		int number;
		while (!int.TryParse(Console.ReadLine(), out number))
		{
			Console.WriteLine("Please enter a number.");
		}
		return number;
	}
}
