using System;

class HexadecimalToDecimal
{
	private static int ConvertToDecimal(char[] number)
	{
		int decNumber = 0;
		int baseNum = 16;
		int value = 0;
		Array.Reverse(number);
		for (int i = 0; i < number.Length; i++)
		{
			value = number[i] <= '9' ? number[i] - '0': number[i] - 'A' + 10;
			decNumber += (int)(value*Math.Pow(baseNum,i));
		}
		return decNumber;
	}
	static void Main()
	{
		Console.WriteLine("Please enter the hexidecimal number in capital letters. Example: FFA9");
		char[] hexNumber = Console.ReadLine().ToUpper().ToCharArray();
		int output = ConvertToDecimal(hexNumber);
		Console.WriteLine("Decimal number: {0}", output);
	}
}
