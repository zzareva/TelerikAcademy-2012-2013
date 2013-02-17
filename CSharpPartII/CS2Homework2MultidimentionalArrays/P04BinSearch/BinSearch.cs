using System;

class BinSearch
{
	static void Main()
	{
		int k = GetNumber("K");
		int n = GetNumber("N");
		int[] theArray = new int[n];
		for (int i = 0; i < theArray.Length; i++)
		{
			theArray[i] = GetNumber("array[" + i + "]: ");
		}
		Array.Sort(theArray);
		int index = Array.BinarySearch(theArray, k);
		if (index > 0)
			Console.WriteLine("The largest number <= k is k = {0}!", k);
		else if(k < theArray[0])
			Console.WriteLine("All numbers are bigger than k.");
		else
		{
			for (int i = theArray.Length - 1; i >= 0; i--)
			{
				if (theArray[i] < k)
				{
					Console.WriteLine("The greatest number <= k is: {0}", theArray[i]);
					break;
				}
			}
		}
	}
	static int GetNumber(string varName)
	{
		int number = 0;
		do
		{
			Console.WriteLine("Please enter number {0}:", varName);
		}
		while (!int.TryParse(Console.ReadLine(), out number));
		return number;
	}
}
