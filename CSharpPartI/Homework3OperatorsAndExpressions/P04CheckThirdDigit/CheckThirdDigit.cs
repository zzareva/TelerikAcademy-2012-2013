using System;

class CheckThirdDigit
{
	static void Main()
	{
		Console.WriteLine("Please enter a number (>=100).");
		int integerVariable = 0;
		while (!int.TryParse(Console.ReadLine(), out integerVariable) || integerVariable < 100)
		{
			Console.WriteLine("Please enter integer number with at leats 3 digits.");
		}
		int thirdDigit = (integerVariable / 100) % 10;
		Console.WriteLine(thirdDigit == 7? "Yes, third digit is 7!":"No, third digit isn't 7.");
	}
}
