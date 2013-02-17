using System;

class SortAndMaxNumber
{
	static int GetMaxMember(int[] input, int startPosition)
	{
		int maxMember = input[startPosition];
		int maxIndex = startPosition;
		for (int i = startPosition; i < input.Length; i++)
		{
			if (input[i] < maxMember)
			{
				maxIndex = i;
				maxMember = input[i];
			}
		}
		return maxIndex;
	}
	static void SortUsingMax(int[] input, int startPosition)
	{
		int temp = 0;
		int maxIndex = GetMaxMember(input, startPosition);
		if (maxIndex != startPosition)
		{
			temp = input[maxIndex];
			input[maxIndex] = input[startPosition];
			input[startPosition] = temp;
		}
		if (startPosition < input.Length - 1)
			SortUsingMax(input, startPosition + 1);
	}
	static void Main()
	{
		Console.WriteLine("Please enter the array valued separated by commas. All invalid input will be treated as 0.");
		string[] theInput = Console.ReadLine().Split(',');
		int[] theIntInput = new int[theInput.Length];
		for (int i = 0; i < theInput.Length; i++)
		{
			int tempNumber = 0;
			if (!int.TryParse(theInput[i], out tempNumber))
				tempNumber = 0;
			theIntInput[i] = tempNumber;
		}
		SortUsingMax(theIntInput, 0);
		Console.WriteLine("The sorted array is:");
		Console.WriteLine(string.Join(",", theIntInput));
	}
}