using System;
using System.Numerics;

class DancingBits
{
	static void Main()
	{
		int dancingBitsLength = int.Parse(Console.ReadLine());
		int n = int.Parse(Console.ReadLine());
		int[] numbers = new int[n];
		for (int i = 0; i < n; i++)
		{
			numbers[i] = int.Parse(Console.ReadLine());
		}
		BigInteger combinedNumbers = 0;
		int movePositions = 0;
		for (int j = n - 1; j >= 0; j--)
		{
			combinedNumbers = combinedNumbers | ((BigInteger)numbers[j] << movePositions);
			movePositions += GetBinaryLength(numbers[j]);
		}
		short currentCount = 0;
		short countOfDancingBits = 0;
		byte previousBit = 3;
		byte currentBit = 0;
		while (combinedNumbers > 0)
		{
			currentBit = (byte)(1 & combinedNumbers);
			if (currentBit == previousBit)
				currentCount++;
			if (currentBit != previousBit)
			{
				if (currentCount == dancingBitsLength - 1 && previousBit != 3)
					countOfDancingBits++;
				currentCount = 0;
				previousBit = currentBit;
			}
			if (combinedNumbers == 1)
				if (currentCount == dancingBitsLength - 1)
					countOfDancingBits++;
			combinedNumbers >>= 1;
		}
		Console.WriteLine(countOfDancingBits);
	}

	static int GetBinaryLength(int number)
	{
		int count = 0;
		while (number > 0)
		{
			count++;
			number >>= 1;
		}
		return count;
	}
}
