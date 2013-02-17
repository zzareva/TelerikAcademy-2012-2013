using System;
using System.Collections.Generic;


class Factoriel
{
	private static int GetNumber()
	{
		int number = 0;
		Console.Write("Please enter an integer number between 1 and 100:");
		while (!int.TryParse(Console.ReadLine(), out number) || number < 1 || number > 100)
		{
			Console.WriteLine("Invalid number! Please enter an integer number between 1 and 100.");
		}
		return number;
	}
	private static int[] NFactoriel(int n)
	{
		int[] tempArray = { 1 };

		for (int multiplier = 1; multiplier <= n; multiplier++)
		{
			List<int> digitsList = new List<int>();
			int carried = 0;
			for (int i = 0; i< tempArray.Length; i++)
			{
				digitsList.Add((tempArray[i] * multiplier + carried) % 10);
				carried = (tempArray[i] * multiplier + carried) / 10;
			}
			Console.WriteLine(carried);
			if(carried > 0)
			{
				digitsList.Add(carried % 10);
				carried = carried / 10;
			}
			tempArray = digitsList.ToArray();
			digitsList.Clear();
		}
		Array.Reverse(tempArray);
		return tempArray;
	}
	private static void Print(int[] array)
	{
		Console.WriteLine(string.Join("", array));
	}
	static void Main()
	{
		int n = GetNumber();
		int[] arr = NFactoriel(n);
		Print(arr);
	}
}