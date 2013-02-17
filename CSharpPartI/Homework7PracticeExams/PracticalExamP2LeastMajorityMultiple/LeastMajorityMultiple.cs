using System;

class LeastMajorityMultiple
{
	static void Main()
	{
		int smallestNumber = 101;
		byte devisionCounter = 0;
		int[] numbers = new int[5];
		for (byte k = 0;k < numbers.Length;k++)
		{
			numbers[k] = int.Parse(Console.ReadLine());
			smallestNumber = (numbers[k] < smallestNumber) ? numbers[k] : smallestNumber;
		}
		int multiplier = 1;
		int result = 0;
		while (devisionCounter < 3)
		{
			devisionCounter = 0;
			result = smallestNumber * multiplier;
			foreach (int t in numbers)
			{
				if (result % t == 0)
					devisionCounter++;
			}
			multiplier++;
		}
		Console.WriteLine(result);
	}
}
