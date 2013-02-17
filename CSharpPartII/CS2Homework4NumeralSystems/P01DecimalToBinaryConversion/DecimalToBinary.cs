using System;

class DecimalToBinary
{
	private static bool[] ConvertToBinary(int number)
	{
		bool[] bits = new bool[32];
		for (int index = 0; index < bits.Length; index++)
		{
			bits[bits.Length - 1 - index] = ((1 << index) & number) != 0;
		}
		return bits;
	}
	private static void PrintBits(bool[] bits)
	{
		Console.Write("Binary representation: ");
		bool leadingZero = true;
		foreach (bool bit in bits)
		{
			if (bit)
				leadingZero = false;
			if (!leadingZero)
				Console.Write(bit ? 1 : 0);
		}
		Console.WriteLine();
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
		int decimalNumber = GetIntNumber();
		bool[] bits = ConvertToBinary(decimalNumber);
		PrintBits(bits);
	}
}
