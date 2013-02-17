using System;

class SortStringArray
{
	static void SortStrings(string[] array)
	{
		Array.Sort(array, (elem1, elem2) => { return elem1.Length.CompareTo(elem2.Length); });
	}

	static void PrintArray(string[] array)
	{
		Console.WriteLine(string.Join("|",array));
	}

	static void Main()
	{
		Console.WriteLine("Please enter all string values separated by |. ");
		string[] array = Console.ReadLine().Split('|');
		SortStrings(array);
		Console.WriteLine("The sorted array is:");
		PrintArray(array);
	}
}

