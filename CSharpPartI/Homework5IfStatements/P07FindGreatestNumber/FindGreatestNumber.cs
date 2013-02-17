using System;

class FindGreatestNumber
{
	static void Main()
	{
		int[] numbers = new int[5];
		for (byte i = 0; i < numbers.Length; i++)
		{
			Console.WriteLine("Please enter number {0}",i + 1);
			numbers[i] = GetNumber(); 
		}
		int greatestNumber = numbers[0];
		for(byte k = 1; k < numbers.Length; k++)
		{
			if (numbers[k] > numbers[k - 1])
			{
				greatestNumber = numbers[k];
			}
		}
		Console.WriteLine("The greatest number is {0}", greatestNumber);
	}
	static int GetNumber()
	{
		int number;
		while(!int.TryParse(Console.ReadLine(),out number))
		{
			Console.WriteLine("Please enter correct number (integer)");
		}
		return number;
	}
}
