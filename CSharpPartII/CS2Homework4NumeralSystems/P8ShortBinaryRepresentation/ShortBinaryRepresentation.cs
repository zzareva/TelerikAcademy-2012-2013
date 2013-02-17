using System;
using System.Text;

class ShortBinaryRepresentation
{
	private static string ConvertToBinary(short baseNumber)
	{
		short number = baseNumber;
		StringBuilder bits = new StringBuilder();
		if (baseNumber >= 0)
		{
			while(number > 0)
			{
				bits.Insert(0,number & 1);
				number >>= 1;
			}
			return bits.ToString().PadLeft(16, '0');
		}
		else
		{
			number = (short)(Math.Pow(2,15) - Math.Abs(baseNumber));
			bits.Append('1');
			bits.Append(ConvertToBinary(number).Substring(1));
			return bits.ToString();
		}
	}
	private static void PrintBits(string bits)
	{
		Console.Write("Binary representation: ");
		Console.WriteLine(bits);
	}
	private static short GetIntNumber()
	{
		short number = 0;
		Console.Write("Please enter a number of type short:");
		while (!short.TryParse(Console.ReadLine(), out number))
		{
			Console.WriteLine("Invalid number! Please enter an integer number.");
		}
		return number;
	}

	static void Main()
	{
		short decimalNumber = GetIntNumber();
		string bits = ConvertToBinary(decimalNumber);
		PrintBits(bits);
	}
}

