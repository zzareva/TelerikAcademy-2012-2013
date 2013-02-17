using System;
using System.Collections.Generic;
using System.Text;

class ConvertToAnyNumericalSystem
{

	private static int ConvertToDecimal(int mainBase, string number)
	{
		char[] digits = number.ToCharArray();
		Array.Reverse(digits);
		int decimalNumber = 0;
		for (int index = 0; index < digits.Length; index++)
		{
			char[] hexDigits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
			decimalNumber += Array.IndexOf(hexDigits,number[index]) * (int)Math.Pow(mainBase, index);
		}
		return decimalNumber;
	}
	private static string ConvertToNewBase(int newBase, int number)
	{
		StringBuilder convertedNumber = new StringBuilder();
		while (number > 0)
		{
			int remainder = number % newBase;
			char[] hexDigits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
			number /= newBase;
			convertedNumber.Insert(0, hexDigits[remainder]);
		}
		return convertedNumber.ToString();
	}

	private static int GetBase(int baseNum = 1)
	{
		int theBase = 0;
		Console.WriteLine("Please enter the {0} base", baseNum == 1? "first" : "second");
		while (!int.TryParse(Console.ReadLine(), out theBase) || theBase < 2 || theBase > 16)
		{
			Console.WriteLine("The base should be an integer number between 2 and 16.");
		}
		return theBase;
	}

	static void Main()
	{
		int originalBase = GetBase();
		int newBase = GetBase(2);
		Console.WriteLine("Please enter the original number:");
		string number = Console.ReadLine();
		int decimalNumber = ConvertToDecimal(originalBase, number);
		string toNewBase = ConvertToNewBase(newBase, decimalNumber);
		Console.WriteLine("Converted number: {0}",toNewBase);
	}
}