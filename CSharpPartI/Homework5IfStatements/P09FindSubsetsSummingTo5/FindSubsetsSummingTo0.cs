using System;
using System.Collections.Generic;

class FindSubsetsSummingTo0
{
	static void Main()
	{
		List<string> subsets = new List<string>();
		int sum = 0;
		int[] numbers = new int[5];
		for(int i = 0; i < numbers.Length; i++)
		{
			numbers[i] = GetNumber();
		}

		for(int k = 0; k < numbers.Length;k++)
		{
			if(numbers[k] == sum)
			subsets.Add(numbers[k].ToString());
			for (int t = k + 1; t< numbers.Length; t++)
			{
				if (numbers[k] + numbers[t] == sum)
				subsets.Add(numbers[k] + ", " + numbers[t]);
				for (int p = t + 1; p < numbers.Length;p++ )
				{
					if (numbers[k] + numbers[t] + numbers[p] == sum)
					subsets.Add(numbers[k] + ", " + numbers[t] + ", " + numbers[p]);
					for (int q = p + 1; q < numbers.Length; q++)
					{
						if (numbers[k] + numbers[t] + numbers[p] + numbers[q] == sum)
						subsets.Add(numbers[k] + ", " + numbers[t] + ", " + numbers[p] + ", " + numbers[q]);
						for (int r = q + 1; r < numbers.Length; r++)
						{
							if (numbers[k] + numbers[t] + numbers[p] + numbers[q] + numbers[r] == sum)
							subsets.Add(numbers[k] + ", " + numbers[t] + ", " + numbers[p] + ", " + numbers[q] + ", " + numbers[r]);
						}
					}
				}
			}
		}
		if (subsets.Count != 0)
		{
			Console.WriteLine("The subsets are:");
			foreach (string st in subsets)
			{
				Console.WriteLine(st);
			}
		}
		else
		{
			Console.WriteLine("There are no such subsets.");
		}
	}
	static int GetNumber()
	{
		int number;
		Console.WriteLine("Please enter an integer number.");
		while (!int.TryParse(Console.ReadLine(), out number))
		{
			Console.WriteLine("Please enter correct integer number.");
		}
		return number;
	}
}
