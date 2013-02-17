using System;
using System.Linq;
using System.Collections.Generic;

class SumOfSubsets
{
	static void Main()
	{
		long S = long.Parse(Console.ReadLine());
		int N = int.Parse(Console.ReadLine());
		long[] nValues = new long[N];
		int sums = 0;

		for (int t = 0; t < N; t++)
		{
			nValues[t] = long.Parse(Console.ReadLine());
		}
		for (int i = 0; i < (1 << nValues.Length); i++) //loops from 0 to 2^N
		{
			List<long> subset = new List<long>();
			for (int k = 0; k < nValues.Length; k++) //loop from 0 to N -1
			{
				if ((i & (1 << k)) > 0) //checks the position of 1 in k and if any add k's value to the subset.
				{
					subset.Add(nValues[k]);
				}
			}
			if (subset.Count >= 1 && subset.Sum() == S)
			{
				sums++;
			}
		}
		Console.WriteLine(sums);
	}
}