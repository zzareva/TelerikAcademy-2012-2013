using System;

class BiggerNeighbours
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

	static int GetPosition(int min, int max)
	{
		int number = 0;
		Console.Write("Please enter an integer number between 0 and {0}:",max);
		while (!int.TryParse(Console.ReadLine(), out number) || number < 0 || number > max)
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
		else if (index == 0 && numbers[index] > numbers[index + 1])
			isBigger = true;
		else if (index == numbers.Length - 1 && numbers[index] > numbers[index - 1])
			isBigger = true;
		return isBigger;
	}

	static void Main()
	{
		int[] inputArray = GetInputArray();
		int position = GetPosition(0,inputArray.Length - 1);
		bool result = IsBiggerThanNeighbors(position, inputArray);
		Console.WriteLine("Is {0} bigger than it;s neighbours: {1}",inputArray[position],result);
	}
}
