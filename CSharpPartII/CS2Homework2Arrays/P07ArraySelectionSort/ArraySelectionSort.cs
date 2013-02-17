using System;

class ArraySelectionSort
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
		SelectionSort(theIntInput, 0);
		Console.WriteLine("The sorted array is:");
		Console.WriteLine(string.Join(",", theIntInput));
	}
	static void SelectionSort(int[] input, int startPosition)
	{
		int temp = 0;
		int smallestMember = input[startPosition];
		int smallestIndex = startPosition;
		for (int i = startPosition; i < input.Length; i++)
		{
			if (input[i] < smallestMember)
			{
				smallestIndex = i;
				smallestMember = input[i];
			}

		}
		if (smallestIndex != startPosition)
		{
			temp = input[smallestIndex];
			input[smallestIndex] = input[startPosition];
			input[startPosition] = temp;
		}
		if (startPosition < input.Length - 1)
			SelectionSort(input, startPosition + 1);
	}
}