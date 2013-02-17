using System;

class DevidedByTwoNumbers
{
	static void Main()
	{
		const int constantOne = 5;
		const int constantTwo = 7;
		Console.WriteLine("Please enter an integer number.");
		int integerVariable = 0;
		while (!int.TryParse(Console.ReadLine(), out integerVariable))
		{
			Console.WriteLine("Please enter integer value.");
		}
		Console.WriteLine(((integerVariable % constantOne == 0) && (integerVariable % constantTwo == 0)) ? "The number is devided by both 5 and 7." : "The number isn't devided by both 5 and 7.");
	}
}
