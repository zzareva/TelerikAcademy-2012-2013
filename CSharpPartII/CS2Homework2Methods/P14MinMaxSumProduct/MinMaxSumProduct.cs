using System;

class MinMaxSumProduct
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

	private static int GetMin(params int[] array)
	{
		int min = array.Length > 0 ? array[0] : 0;
		foreach (var item in array)
		{
			if (item.CompareTo(min) < 0)
			{
				min = item;
			}
		}
		return min;
	}

	private static int GetMax(params int[] array)
	{
		int max = array.Length > 0 ? array[0] : 0;
		foreach (var elem in array)
		{
			if (elem.CompareTo(max) > 0)
			{
				max = elem;
			}
		}
		return max;
	}

	private static int GetSum(params int[] array)
	{
		int sum = 0;
		foreach (var elem in array)
		{
			sum += elem;
		}
		return sum;
	}

	private static double GetAverage(params int[] array)
	{
		int sum = GetSum(array);
		double length = (double)array.Length;
		double average = sum / length;
		return average;
	}

	private static int GetProduct(params int[] array)
	{
		int multiply = 1;

		foreach (var elem in array)
		{
			multiply *= elem;
		}
		return multiply;
	}

	static void Main()
	{
		int[] numbers = GetInputArray();

		Console.WriteLine("Minumum: {0}", GetMin(numbers));
		Console.WriteLine("Maximum: {0}", GetMax(numbers));
		Console.WriteLine("Average: {0}", GetAverage(numbers));
		Console.WriteLine("Sum: {0}", GetSum(numbers));
		Console.WriteLine("Product: {0}", GetProduct(numbers));
	}
}