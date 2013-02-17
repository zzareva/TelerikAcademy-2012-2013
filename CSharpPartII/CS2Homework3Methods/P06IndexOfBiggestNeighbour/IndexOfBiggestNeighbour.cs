using System;

class IndexOfBiggestNeighbour
{
	static int[] GetInputArray()
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
		return theIntInput;
	}
	
	static int GetIntNumber()
	{
		int number = 0;
		Console.Write("Please enter an integer number:");
		while (!int.TryParse(Console.ReadLine(), out number))
		{
			Console.WriteLine("Invalid number! Please enter an integer number.");
		}
		return number;
	}

	static bool IsBiggerThanNeighbors(int index, int[] numbers)
	{
		bool isBigger = false;
		if (index >= 1 && index < numbers.Length - 1)
		{
			if (numbers[index] > numbers[index - 1] && numbers[index] > numbers[index + 1])
				isBigger = true;
		}
		else if(index == 0 && numbers[index] > numbers[index + 1])
			isBigger = true;
		else if (index == numbers.Length - 1 && numbers[index] > numbers[index - 1])
			isBigger = true;
		return isBigger;
	}
	static int GetFirstBiggestNeighbourIndex(int[] numbers)
	{
		for (int index = 0; index < numbers.Length; index++)
		{
			if (IsBiggerThanNeighbors(index, numbers))
				return index;
		}
		return -1;
	}
	static void Main()
	{
		int[] inputArray = GetInputArray();
		int result = GetFirstBiggestNeighbourIndex(inputArray);
		Console.WriteLine("The first biggest number among its neighbours is at position:\n {0}\n(Please note that the indices start from 0 and the first and last positions are compared with just 1 neighbour!)",result);
	}
}

