using System;
class Print10Numbers
{
	static void Main()
	{
		for (sbyte m = 1, i = 2; i < 12; m *= -1, i++)
		{
			Console.WriteLine(m * i);
		}
	}
}