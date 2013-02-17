using System;
using System.Numerics;

class Tribonacci
{
	static void Main()
	{
		BigInteger mem1 = BigInteger.Parse(Console.ReadLine());
		BigInteger mem2 = BigInteger.Parse(Console.ReadLine());
		BigInteger mem3 = BigInteger.Parse(Console.ReadLine());
		BigInteger theResult = 0;
		short memberIndex = short.Parse(Console.ReadLine());
		if (memberIndex == 1)
			theResult = mem1;
		else if (memberIndex == 2)
			theResult = mem2;
		else if (memberIndex == 3)
			theResult = mem3;
		else
		{
			for (short i = 4; i <= memberIndex; i++)
			{
				theResult = mem1 + mem2 + mem3;
				mem1 = mem2;
				mem2 = mem3;
				mem3 = theResult;
			}
		}
		Console.WriteLine(theResult);
	}
}
