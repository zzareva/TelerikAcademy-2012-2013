using System;

class BinaryToDecimal
{
	private static int ConvertToDecimal(char[] number)
	{
		int decNumber = 0;
		Array.Reverse(number);
		for (int index = 0; index < number.Length; index++)
		{
			if (number[index] == '1')
				decNumber += (int)Math.Pow(2, index);
		}
		return decNumber;
	}
	private static void Print(int number)
	{
		Console.Write("Decimal representation: ");
		Console.WriteLine(number);
	}

	static void Main()
	{
		Console.WriteLine("Please enter the binary number:");
		char[] binary = Console.ReadLine().ToCharArray();
		int decimalNumber = ConvertToDecimal(binary);
		Print(decimalNumber);
	}
}
