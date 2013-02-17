using System;
using System.Linq;
using System.Collections.Generic;

class OddNumber
{
	static void Main()
	{
		int n = int.Parse(Console.ReadLine());
		List<long> candidateNumbers = new List<long>();
		int uniqueIndex = -1;
		for (int i = 0; i < n; i++)
		{
			long number = long.Parse(Console.ReadLine());
			uniqueIndex = candidateNumbers.IndexOf(number);
			if (uniqueIndex == -1)
			{
				candidateNumbers.Add(number);
			}
			else
			{
				candidateNumbers.RemoveAt(uniqueIndex);
			}
		}
		Console.WriteLine(candidateNumbers[0]);
	}
}
