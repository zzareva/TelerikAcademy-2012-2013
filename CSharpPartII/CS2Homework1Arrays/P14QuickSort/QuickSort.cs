using System;

class QuickSort
{
	static void Main()
	{
		Console.WriteLine("Please enter the array valued separated by commas. All invalid input will be treated as 0.");
		string[] theInput = Console.ReadLine().Split(',');
		int[] theIntInput = new int[theInput.Length];
		for (int i = 0; i < theInput.Length; i++)
		{
			int tempNumber = 0;
			if(!int.TryParse(theInput[i], out tempNumber))
				tempNumber = 0;
			theIntInput[i] = tempNumber;
		}
		QuickSortImplementation(theIntInput, 0, theIntInput.Length - 1);
		Console.WriteLine("The sorted array is:");
		Console.WriteLine(string.Join(",", theIntInput));
	}
	
	static void QuickSortImplementation(int[] a, int left, int right)
	{
		if (a == null)
			return;
		int i = left;
		int j = right;
		int pivot = a[((left + right) / 2)];
		while (i <= j)
		{
			while (a[i] < pivot)
				i++;
			while (a[j] > pivot)
				j--;
			if (i <= j)
			{
				int tmp = a[i];
				a[i] = a[j];
				i++;
				a[j] = tmp;
				j--;
			}
		}
		if (j > 0)
		{
			QuickSortImplementation(a, left, j);
		}
		if (i < right)
		{
			QuickSortImplementation(a, i, right);
		}
	}
}