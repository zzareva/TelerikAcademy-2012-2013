using System;

class BinarySearch
{
	static void Main()
	{
		Console.WriteLine("Please enter the array separating the elements with commas. Example: 0,1,2,3 ");
		Console.ForegroundColor = System.ConsoleColor.Red;
		Console.WriteLine("All invalid input will have value 0.");
		Console.ForegroundColor = System.ConsoleColor.Gray;
		string[] input = Console.ReadLine().Split(',');
		int[] theArray = new int[input.Length];
		int tempNum;
		for (int i = 0; i < input.Length; i++)
		{
			tempNum = 0;
			int.TryParse(input[i], out tempNum);
			theArray[i] = tempNum;
		}

		Console.Write("Please enter the element you are looking for:");
		int item;
		while (!int.TryParse(Console.ReadLine(), out item))
		{
			Console.WriteLine("Invalid data. Please re-enter the element.");
		}
		Array.Sort(theArray); //Array needs to be sorted
		int elementIndex = BinarySearchImplementation(theArray, item, 0, theArray.Length);
		Console.WriteLine("The position of the element within the sorted array is {0}",(elementIndex != -1) ? elementIndex.ToString(): "Item not found");
	}
	static int BinarySearchImplementation(int[] array, int key, int min, int max)
	{
		if (max < min)
			return -1;
		else
		{
			int mid = (min + max) / 2; ;
			if (array[mid] > key)
				return BinarySearchImplementation(array, key, min, mid - 1);
			else if (array[mid] < key)
				return BinarySearchImplementation(array, key, mid + 1, max);
			else
				return mid;
		}
	}
}