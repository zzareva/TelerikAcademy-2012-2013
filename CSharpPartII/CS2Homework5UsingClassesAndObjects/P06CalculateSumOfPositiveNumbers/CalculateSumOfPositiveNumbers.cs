using System;

class CalculateSumOfPositiveNumbers
{
	private static long CalculateSum(params int[] input)
	{
		long sum = 0;
		foreach (var item in input)
		{
			sum += item;
		}
		return sum;
	}
	private static int[] GetInput()
	{
		Console.WriteLine("Please enter all numbers separated by space");
		string[] strInput = Console.ReadLine().Split(' ');
		int[] numInput = new int[strInput.Length];
		for (int i = 0; i < strInput.Length; i++)
		{
			int num = 0;
			int.TryParse(strInput[i], out num);
			numInput[i] = num;
		}
		return numInput;
	}
	static void Main()
	{
		int[] inputArray = GetInput();
		long sum = CalculateSum(inputArray);
		Console.WriteLine("The sum is: {0}",sum);
	}
}
