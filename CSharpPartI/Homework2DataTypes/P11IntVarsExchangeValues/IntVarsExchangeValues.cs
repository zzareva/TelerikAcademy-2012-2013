using System;
class IntVarsExchangeValues
{
	static void Main()
	{
		int variable1 = 5;
		int variable2 = 10;
		int tempVar = variable1;
		variable1 = variable2;
		variable2 = tempVar;
		Console.WriteLine("Variable 1: {0}",variable1);
		Console.WriteLine("Variable 2: {0}", variable2);
	}
}
