using System;
using System.Numerics;

class CatalanNumbers
{
	static uint GetNumber()
	{
		uint number;
		do
		{
			Console.WriteLine("Please enter an integer number");
		}
		while (!uint.TryParse(Console.ReadLine(), out number));
		return number;
	}

	static void Main()
	{
		uint numberN = GetNumber();
		BigInteger factorielN = 1;
		BigInteger factorielNplus2To2N = 1;
		BigInteger theResult;
		for (uint i = 1; i <= numberN; i++)
		{
			factorielN *= i;
		}
		for (uint j = numberN + 2; j <= numberN * 2; j++)
		{
			factorielNplus2To2N *= j;
		}
		theResult = factorielNplus2To2N / factorielN;
		Console.WriteLine("The Catalan number with index {0} is {1}", numberN, theResult);
	}
}
