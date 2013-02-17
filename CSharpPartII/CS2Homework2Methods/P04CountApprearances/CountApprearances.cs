using System;

public class CountApprearances
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

	public static int CountApperances(int num, int[] arr)
	{
		int count = 0;
		for (int i = 0; i < arr.Length; i++)
		{
			if (arr[i] == num)
				count++;
		}
		return count;
	}

	static void Main()
	{
		int[] array = GetInputArray();
		int number = GetIntNumber();
		int numberOfAppearances = CountApperances(number,array);
		Console.WriteLine("{0} appears {1} times in the array.", number, numberOfAppearances);
	}
}
