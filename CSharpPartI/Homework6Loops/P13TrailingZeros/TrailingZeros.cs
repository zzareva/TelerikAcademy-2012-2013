using System;
using System.Numerics;

class TrailingZeros
{
	static BigInteger GetBigIntNumber()
	{
		BigInteger number;
		do
		{
			Console.WriteLine("Please enter and integer number N.");
		}
		while (!BigInteger.TryParse(Console.ReadLine(), out number));
		return number;
	}
	static void Main()
	{
		BigInteger numberN = GetBigIntNumber();
		int result = 1000;
		int deviderPower = 1;
		int devider;
		int zeros = 0;
		while(result > 1)
		{
			devider = (int)Math.Pow(5,deviderPower);
			result = (int)(numberN / devider);
			deviderPower++;
			zeros += result;
		}
		Console.WriteLine("There are {0} trailing zeros in {1}!",zeros,numberN);
	}
}
