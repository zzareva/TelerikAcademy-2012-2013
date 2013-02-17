using System;

class UsingQuotasCausesProblems
{
	static void Main()
	{
		string usingQuotesCausesProblems1 = @"The ""use"" of quotations causes difficulties.";
		Console.WriteLine("Version 1: {0}",usingQuotesCausesProblems1);
		string usingQuotesCausesProblems2 = "The \"use\" of quotations causes difficulties.";
		Console.WriteLine("Version 2: {0}", usingQuotesCausesProblems2);

	}
}
