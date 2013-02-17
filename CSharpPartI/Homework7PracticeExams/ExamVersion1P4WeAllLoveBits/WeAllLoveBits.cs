using System;

class WeAllLoveBits
{
	static void Main()
	{
		int n = int.Parse(Console.ReadLine());
		int p = 0;
		for (int k = 0; k < n; k++)
		{
			p = int.Parse(Console.ReadLine());
			Console.WriteLine(ReverseBits(p));
		}
	}
	static int ReverseBits(int number)
	{
		int reversed = 0;
		while (number > 0)
		{
			reversed <<= 1;
			reversed += number & 1;
			number >>=  1;
		}
		return reversed;
	}
}
