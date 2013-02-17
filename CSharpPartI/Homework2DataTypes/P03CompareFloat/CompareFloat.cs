using System;

class CompareFloat
{
	static void Main()
	{
		Console.WriteLine("Enter compare value 1 (float).");
		float compareFloatVariable1 = ReadFloatSecure();
		Console.WriteLine("Enter compare value 2 (float).");
		float compareFloatVariable2 = ReadFloatSecure();

		long var1ToLong = (long)(compareFloatVariable1 * Math.Pow(10, 6));
		long var2ToLong = (long)(compareFloatVariable2 * Math.Pow(10, 6));

		if (var1ToLong > var2ToLong)
		{
			Console.WriteLine("Variable 1 is greater than variable 2.");
		}
		else if (var1ToLong < var2ToLong)
		{
			Console.WriteLine("Variable 2 is greater than variable 1.");
		}
		else
		{
			Console.WriteLine("The variables are equal.");
		}

	}

	static float ReadFloatSecure()
	{
		float compareFloatVariable;
		while (!float.TryParse(Console.ReadLine(), out compareFloatVariable))
		{
			Console.WriteLine("Enter float");
		}
		return compareFloatVariable;
	}
}
