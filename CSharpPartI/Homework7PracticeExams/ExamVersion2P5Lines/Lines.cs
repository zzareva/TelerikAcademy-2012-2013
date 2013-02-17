using System;

class Lines
{
	static readonly byte[] linesBySize = { 0, 0, 0, 0, 0, 0, 0, 0 };
	static readonly byte[] transposedNumbers = { 0, 0, 0, 0, 0, 0, 0, 0 };

	static void Main()
	{
			byte[] numbers = new byte[8];
			
			for (byte i = 0; i < 8; i++)
			{
				numbers[i] = byte.Parse(Console.ReadLine());
				CountLinesInNumber(numbers[i]);
				TransposeBits(i, numbers[i]);
			}
			foreach (byte j in transposedNumbers)
			{
				CountLinesInNumber(j);
			}
			RemoveDoubleCountingInSingles();
			byte maxCount = 0;
			byte maxCountLength = 0;
			for (byte c = 8; c >= 1; c--)
			{
				if (linesBySize[c - 1] > maxCount)
				{
					maxCountLength = c;
					maxCount = linesBySize[c - 1];
					break;
				}
			}
			Console.WriteLine(maxCountLength);
			Console.WriteLine(maxCount);
	}

	static void CountLinesInNumber(byte currentNumber)
	{
		byte currentBitCount = 0;
		byte currentBit = 0;
		byte previousBit = 0;
		while (currentNumber > 0)
			{
				currentBit = (byte)(1 & currentNumber);
				if (currentBit == 1)
				{
					currentBitCount++;
					if (currentNumber == 1)
					{
						linesBySize[currentBitCount - 1]++;
					}
				}
				else if (currentBit == 0 && previousBit == 1)
				{
					linesBySize[currentBitCount - 1]++;
					currentBitCount = 0;
				}
				
				previousBit = currentBit;
				currentNumber >>= 1;
			}
	}
	static void TransposeBits(byte numberIndex, byte currentNumber)
	{
		byte currentBit = 0;
		byte currentPosition = 0;
		while (currentNumber > 0)
		{
			currentBit = (byte)(1 & currentNumber);
			if (currentBit == 1)
			{
				transposedNumbers[currentPosition] |= (byte)(1 << numberIndex);
			}
			currentNumber >>= 1;
			currentPosition++;
		}
	}
	static void RemoveDoubleCountingInSingles()
	{
		if (linesBySize[0] != 0)
			linesBySize[0] /= 2;
	}
}
