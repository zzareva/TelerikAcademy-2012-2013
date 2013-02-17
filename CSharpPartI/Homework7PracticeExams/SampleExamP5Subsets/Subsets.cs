using System;
using System.Linq;
using System.Collections.Generic;

class Subsets
{
	static void Main()
	{
		long s = long.Parse(Console.ReadLine());
		int n = int.Parse(Console.ReadLine());
		long[] nValues = new long[n];
		int sums = 0; 
		for (int t = 0; t < n; t++)
		{
			nValues[t] = long.Parse(Console.ReadLine());
		}
		for (int i = 0; i < (1 << nValues.Length); i++)
		{
			List<long> subsets = new List<long>();
			for (int k = 0; k < nValues.Length; k++)
			{
				if ((i & (1 << k)) > 0)
				{
					subsets.Add(nValues[k]);
				}
			}
			if (subsets.Count >= 1 && subsets.Sum() == s)
				sums++;
		}
		Console.WriteLine(sums);
	}
}