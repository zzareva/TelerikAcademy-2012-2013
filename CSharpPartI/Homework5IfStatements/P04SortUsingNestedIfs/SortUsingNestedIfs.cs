using System;

class SortUsingNestedIfs
{
	static int[] numbers = new int[3];
	static void Main()
	{
		Console.WriteLine("Please enter the first integer number.");
		numbers[0] = GetNumber();
		Console.WriteLine("Please enter the second integer number.");
		numbers[1] = GetNumber();
		Console.WriteLine("Please enter the third integer number.");
		numbers[2] = GetNumber();

		byte countSwaps = 1;
		while (countSwaps > 0)
		{
			countSwaps = 0;
			for (byte i = 0; i < numbers.Length - 1; i++)
			{
				if(numbers[i]< numbers[i+1])
				{
					SwapValues(i,i+1);
					countSwaps++;
				}
			}
		}
		
		Console.WriteLine("The sorted numbers are {0}",string.Join(", ",numbers));
	}
	static int GetNumber()
	{
		int number;
		while(!int.TryParse(Console.ReadLine(),out number))
		{
			Console.WriteLine("Please enter an integer number.");
		}
		return number;
	}
	static void SwapValues(int pos1,int pos2)
	{
		int tempNumber = numbers[pos1];
		numbers[pos1] = numbers[pos2];
		numbers[pos2] = tempNumber;
	}
}
