using System;
using System.Linq;
using System.Collections.Generic;

class FindMaximumSumOfKElements
{
	static void Main()
	{
		long k = int.Parse(Console.ReadLine());
		int n = int.Parse(Console.ReadLine());// validate n - should be >= k
		long[] nValues = new long[n];
		long maxSum = 0;
		string maxSubset = "";
		for (int t = 0; t < n; t++)
		{
			nValues[t] = long.Parse(Console.ReadLine());
		}
		for (int i = 0; i < (1 << nValues.Length); i++)
		{
			List<long> subsets = new List<long>();
			for (int j = 0; j < nValues.Length; j++)
			{
				if ((i & (1 << j)) > 0)
				{
					subsets.Add(nValues[j]);
				}
			}
			if (subsets.Count == k && subsets.Sum() > maxSum)
			{
				maxSum = subsets.Sum();
				maxSubset = string.Join(", ",subsets);
			}
		}
		//Console.WriteLine(maxSum);
		Console.Write("The subset of {0} elements with maximum sum is: {1}",k,maxSubset);
		Console.WriteLine();
	}
}