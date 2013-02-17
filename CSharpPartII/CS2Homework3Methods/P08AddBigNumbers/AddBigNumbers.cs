using System;
using System.Collections.Generic;

class AddBigNumbers
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

	static void PrintSum(int[] result)
	{
		Console.WriteLine(string.Join("",result));
	}

	static int[] AddDigits(int[] first, int[] second)
	{
		int maxLength = first.Length > second.Length ? first.Length + 1 : second.Length + 1;
		List<int> result = new List<int> { };

		int carried = 0;
		int firstNumberIndex = first.Length - 1;
		int secondNumberIndex = second.Length - 1;
		for (int index = maxLength - 1; index >= 0; index--)
		{
			int sum = 0;
			sum += firstNumberIndex >= 0 ? first[firstNumberIndex] : 0;
			sum += secondNumberIndex >= 0 ? second[secondNumberIndex] : 0;
			firstNumberIndex--;
			secondNumberIndex--;
			sum += carried;
			result.Add(sum % 10);
			carried = sum / 10;
		}

		if (result[result.Count - 1] == 0)
		{
			result.RemoveAt(result.Count - 1);
		}
		result.Reverse();

		return result.ToArray();
	}

	static void Main()
	{
		int[] firstArray = GetInputArray();
		int[] secondArray = GetInputArray();
		int[] theResult = AddDigits(firstArray, secondArray);
		PrintSum(theResult);
	}
}