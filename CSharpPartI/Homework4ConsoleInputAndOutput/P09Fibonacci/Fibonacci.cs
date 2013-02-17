using System;
using System.Numerics;

class Fibonacci
{
	static void Main()
	{
		BigInteger firstValue = 0;
		BigInteger secondValue = 1;
		BigInteger temp;

		Console.WriteLine(firstValue);
		Console.WriteLine(secondValue);

		for (int i = 3; i <= 100; i++)
		{
			temp = firstValue;
			firstValue = secondValue;
			secondValue += temp;
			Console.WriteLine(secondValue);
		}
	}
}
