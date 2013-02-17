using System;

class SetBitPositionValue
{
	static void Main()
	{
		Console.WriteLine("Please enter number n.");
		int n = getNumber();
		Console.WriteLine("Please enter value v.");
		byte v = getBitValue();
		Console.WriteLine("Please enter position number.");
		int p = getNumber();
		int mask = ~(1 << p);
		int result = n & mask;
		mask = v << p;
		result = result | mask;
		Console.WriteLine("The new number is {0}",Convert.ToString(result,2));

	}
	static int getNumber()
	{
		int number;
		while (!int.TryParse(Console.ReadLine(), out number))
		{
			Console.WriteLine("Please enter correct integer value.");
		}
		return number;
	}
	static byte getBitValue()
	{
		byte bnumber;
		while (!byte.TryParse(Console.ReadLine(), out bnumber) || (bnumber != 0 && bnumber != 1))
		{
			Console.WriteLine("Please enter correct bit value.");
		}
		return bnumber;
	}
}
