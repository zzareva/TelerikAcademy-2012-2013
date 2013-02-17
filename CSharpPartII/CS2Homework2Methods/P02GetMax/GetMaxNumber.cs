using System;

class GetMaxNumber
{
	static int GetIntNumber()
	{
		int number = 0;
		Console.Write("Please enter an integer number:");
		while(!int.TryParse(Console.ReadLine(), out number))
		{
			Console.WriteLine("Invalid number! Please enter an integer number.");
		}
		return number;
	}
	static int GetMax(int operant1, int operant2)
	{
		if (operant1 > operant2)
			return operant1;
		else
			return operant2;
	}
	static void Main()
	{
		int[] inputNumbers = new int[3];
		for (int j = 0; j < inputNumbers.Length; j++)
		{
			inputNumbers[j] = GetIntNumber();
		}
		int maxNumber = int.MinValue;
		for (int i = 0; i < inputNumbers.Length - 1; i++)
		{
			maxNumber = GetMax(inputNumbers[i], inputNumbers[i + 1]);
		}
		Console.WriteLine("The biggest number is: {0}",maxNumber);

	}
}
