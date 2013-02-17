using System;
using System.Collections.Generic;

class ReverseDigits
{
	static int ReverseNumber(int number)
	{
		char[] digits = number.ToString().ToCharArray();
		Array.Reverse(digits);
		return int.Parse(String.Join("", digits));
	}
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

	static void Main()
	{
		int number = GetIntNumber();
		int reversed = ReverseNumber(number);
		Console.WriteLine(reversed);
	}
}