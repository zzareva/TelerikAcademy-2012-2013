using System;

class SpiralMatrix
{
	static void Main()
	{
		sbyte theNumber = GetNumber();
		int[,] matrix = new int[theNumber,theNumber];
		int num = 1;
		sbyte minRow = 0;
		sbyte maxRow = theNumber; maxRow--;
		sbyte minColumn = 0;
		sbyte maxColumn = theNumber; maxColumn--;
		for(sbyte step = 0; step <= Math.Round((float)theNumber/2,0);step++)
		{
			for (sbyte i1 = minColumn; i1 <= maxColumn; i1++, num++)
			{
				matrix[minRow, i1] = num;
			}
			minRow++;
			for (sbyte i2 = minRow; i2 <= maxRow; i2++, num++)
			{
				matrix[i2, maxColumn] = num;
			}
			maxColumn--;
			for (sbyte i3 = maxColumn; i3 >= minColumn; i3--, num++)
			{
				matrix[maxRow, i3] = num;
				
			}
			maxRow--;
			for (sbyte i4 = maxRow; i4 >= minRow; i4--, num++)
			{
				matrix[i4, minColumn] = num;
				
			}
			minColumn++;
		}

		for (byte k1 = 0; k1 < theNumber; k1++)
		{
			for (byte k2 = 0; k2 < theNumber; k2++)
			{
				Console.Write("|{0,-3}",matrix[k1,k2]);
			}
			Console.WriteLine("|");
		}

	}
	static sbyte GetNumber()
	{
		sbyte number;
		do
		{
			Console.WriteLine("Please enter a numter between 2 and 20.");
		}
		while (!sbyte.TryParse(Console.ReadLine(), out number) || number < 2 || number > 20);
		return number;
	}
}
