using System;
using System.Text;

class DecimalToHexadecimal
{
	private static string ConvertToHexadecimal(int number)
	{
		StringBuilder hexNumber = new StringBuilder();
		while (number > 0)
		{
			int remainder = number % 16;
			char[] hexDigits = { '0','1','2','3','4','5','6','7','8','9','A','B','C','D','E','F'};
			number /= 16;
			hexNumber.Insert(0,hexDigits[remainder]);
		}
		return hexNumber.ToString();
	}
	private static int GetIntNumber()
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
		int decNumber = GetIntNumber();
		string hexNum = ConvertToHexadecimal(decNumber);
		Console.WriteLine("Hexadecimal number: {0}", hexNum);
	}
}
