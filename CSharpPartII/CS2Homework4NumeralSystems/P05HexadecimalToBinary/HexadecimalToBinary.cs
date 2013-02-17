using System;
using System.Text;

class HexadecimalToBinary
{
	private static string ConvertToBinary(char[] number)
	{
		StringBuilder binary = new StringBuilder();
		for (int i = 0; i < number.Length; i++)
		{
			int value = number[i] <= '9' ? number[i] - '0' : number[i] - 'A' + 10;
			binary.Append(Convert.ToString(value,2));
		}
		return binary.ToString();
	}
	static void Main()
	{
		Console.WriteLine("Please enter the hexadecimal number:");
		char[] hexlNumber = Console.ReadLine().ToUpper().ToCharArray();
		string binaryNum = ConvertToBinary(hexlNumber);
		Console.WriteLine("Binary number: {0}", binaryNum);
	}
}
