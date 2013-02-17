using System;

class CompareCharArrays
{
	static void Main()
	{
		Console.WriteLine("Please enter the first string:");
		string firstString = Console.ReadLine();
		Console.WriteLine("Please enter the second string:");
		string secondString = Console.ReadLine();
		if (firstString.Length == secondString.Length)
		{
			bool doTheseMatch = true;
			for (int i = 0; i < firstString.Length; i++)
			{
				if (firstString[i] != secondString[i])
				{
					doTheseMatch = false;
					Console.WriteLine("Char #{0} doesn't match.", i + 1);
				}
			}
			if (doTheseMatch == true)
			{
				Console.WriteLine("The two chars in the two char arrays match.");
			}
		}
		else
		{
			Console.WriteLine("The char arrays have different lengths.");
		}
	}
}
