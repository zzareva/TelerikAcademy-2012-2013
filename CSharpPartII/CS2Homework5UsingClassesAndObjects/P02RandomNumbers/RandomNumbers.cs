using System;

class RandomNumbers
{
	static readonly Random randomGenerator = new Random();
	
	static void Main()
	{
		Console.WriteLine("Here are 10 randomly generated numbers between 100 and 200:");
		for (int i = 0; i < 10; i++)
		{
			Console.WriteLine(randomGenerator.Next(100, 200));
		}
	}
}
