using System;

class CompareTwoArrays
{
	static void Main()
	{
		Console.Write("Please enter the array size:");
		int arraySize = GetNumber();
		string[] firstArray = new string[arraySize];
		string[] secondArray = new string[arraySize];
		for (int j = 0; j < firstArray.Length; j++)
		{
			Console.Write("Please enter element {0} from the first array: ",j + 1);
			firstArray[j] = Console.ReadLine();
		}
		for (int k = 0; k < secondArray.Length; k++)
		{
			Console.Write("Please enter element {0} from the second array: ", k + 1);
			secondArray[k] = Console.ReadLine();
		}
		bool areEqual = true;
		for (int i = 0; i < firstArray.Length; i++)
		{
			if (firstArray[i] != secondArray[i])
			{
				areEqual = false;
				break;
			}
		}
		Console.WriteLine("The arrays {0} have equal elements.",areEqual == true? "" : "don't");
	}
	static int GetNumber()
	{
		int number = 0;
		while (!int.TryParse(Console.ReadLine(), out number) || number < 1)
		{
			Console.WriteLine("Please enter a valid number (>= 1).");
		}
		return number;
	}
}
