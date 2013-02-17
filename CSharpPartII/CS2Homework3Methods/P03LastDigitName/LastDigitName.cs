using System;

class LastDigitName
{
	static int GetIntNumber()
	{
		int number = 0;
		Console.Write("Please enter an integer number:");
		while (!int.TryParse(Console.ReadLine(), out number))
		{
			Console.WriteLine("Invalid number! Please enter an integer number.");
		}
		return number;
	}
	static string GetLastDigitName(int number)
	{
		int lastDigit = number % 10;
		string[] digitNames = { "zero","one","two","three","four","five","six","seven","eight","nine"};
		return digitNames[lastDigit];
	}
	static void Main()
	{
		int inputNumber = GetIntNumber();
		string outputName = GetLastDigitName(inputNumber);
		Console.WriteLine("Last digit name: {0}",outputName);
	}
}
