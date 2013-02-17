using System;
using System.Collections;
using System.Collections.Generic;

class Combinations
{
	static int numberN;
	static int numberK;
	static int[] combinations;
	static List<string> finalList = new List<string> { };

	static void Main()
	{
		numberN = GetNumber();
		numberK = GetNumber(numberN);
		combinations = new int[numberK];
		GetCombinations();
	}

	static int GetNumber(int maximum = int.MaxValue)
	{
		int number;
		do
		{
			Console.WriteLine("Please enter an integer number <= {0}", maximum);
		}
		while (!int.TryParse(Console.ReadLine(), out number) || number > maximum);
		return number;
	}
	static void PrintLoops()
	{
		Console.WriteLine("{0}", String.Join(",", combinations));
	}
	static void SetToOne(int[] variations, int index)
	{
		for (int i = 0; i <= index; i++)
		{
			variations[i] = 1;
		}
	}
	static void GetCombinations()
	{
		SetToOne(combinations, numberK - 1);
		int count = 1;
		while (combinations[numberK - 1] <= numberN)
		{
			for (int i = 1; i <= numberN; i++)
			{
				combinations[0] = i;
				Array.Sort(combinations);
				string tempList = String.Join(",", combinations);
				if(!finalList.Contains(tempList))
				{
					finalList.Add(tempList);
					PrintLoops();
				}
			}
			combinations[1]++;
			for (int i = 0; i < numberK - 1; i++)
			{
				if (combinations[i] == numberN + 1)
				{
					combinations[i + 1]++;
					SetToOne(combinations, i);
				}
			}
			count++;
		}
	}
}
