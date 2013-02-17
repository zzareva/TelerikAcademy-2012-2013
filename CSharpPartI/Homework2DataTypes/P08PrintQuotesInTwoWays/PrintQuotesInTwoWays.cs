using System;

class PrintQuotesInTwoWays
{
	static void Main()
	{
		string stringWithQuotes1 = "The \"use\" of quotations causes difficulties.";
		string stringWithQuotes2 = @"The ""use"" of quotations causes difficulties.";
		Console.WriteLine(stringWithQuotes1);
		Console.WriteLine(stringWithQuotes2);
	}
}
