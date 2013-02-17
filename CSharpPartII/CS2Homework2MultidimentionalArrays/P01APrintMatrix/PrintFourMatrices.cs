using System;

class PrintFourMatrices
{
	static void Main()
	{
		sbyte matrixSize = GetNumber();
		int[,] matrix = new int[matrixSize,matrixSize];

		//Array A
		Console.WriteLine("Array A:");
		for (int i = 0; i < matrix.GetLength(0); i++) //column
		{
			for (int j = 0; j < matrix.GetLength(0); j++) //row
			{
				matrix[j, i] = i*matrix.GetLength(0) + j + 1;
			}
		}
		PrintMatrix(matrix);

		//Array B
		Console.WriteLine("Array B:");
		Array.Clear(matrix, 0, matrix.Length);

		for (int i = 0; i < matrix.GetLength(0); i++) //column
		{
			for (int j = 0; j < matrix.GetLength(0); j++) //row
			{
				if (i % 2 == 0)
				{
					matrix[j, i] = i * matrix.GetLength(0) + j + 1;
				}
				else
				{
					matrix[matrix.GetLength(0) - j - 1, i] = i * matrix.GetLength(0) + j + 1;
				}
			}
		}

		PrintMatrix(matrix);

		//Array C
		Console.WriteLine("Array C:");
		Array.Clear(matrix, 0, matrix.Length);

		int row = 0;
		int col = 0;
		int currentNumber = 1;
		for (int diagonalSum = 0; diagonalSum < matrixSize * 2; diagonalSum++) //row
		{
			row = Math.Min(matrixSize - 1, diagonalSum);
			int minRowMatrix = Math.Max(diagonalSum - row,0);
			while (row >= minRowMatrix)
			{
				col = diagonalSum - row;
				matrix[matrixSize - row - 1, col] = currentNumber;
				currentNumber++;
				row--;
			}
			
		}

		PrintMatrix(matrix);
		//Array D
		Console.WriteLine("Array D:");
		Array.Clear(matrix,0,matrix.Length);
		int num = 1;
		sbyte minRow = 0;
		sbyte maxRow = matrixSize; maxRow--;
		sbyte minColumn = 0;
		sbyte maxColumn = matrixSize; maxColumn--;
		for (sbyte step = 0; step <= Math.Round((float)matrixSize / 2, 0); step++)
		{
			for (sbyte i4 = minRow; i4 <= maxRow; i4++, num++) //Top To Bottom
			{
				matrix[i4, minColumn] = num;
			}
			minColumn++;
			for (sbyte i3 = minColumn; i3 <= maxColumn; i3++, num++) //Go Left To Right
			{
				matrix[maxRow, i3] = num;
			}
			maxRow--;
			for (sbyte i2 = maxRow; i2 >= minRow; i2--, num++) //Bottom To Top
			{
				matrix[i2, maxColumn] = num;
			}
			maxColumn--;
			for (sbyte i1 = maxColumn; i1 >= minColumn; i1--, num++)//Right To Left
			{
				matrix[minRow, i1] = num;
			}
			minRow++;
		}

		PrintMatrix(matrix);

	}
	static sbyte GetNumber()
	{
		sbyte number;
		do
		{
			Console.WriteLine("Please enter a number between 2 and 20.");
		}
		while (!sbyte.TryParse(Console.ReadLine(), out number) || number < 2 || number > 20);
		return number;
	}
	static void PrintMatrix(int[,] matrix)
	{
		int size = matrix.GetLength(0);
		for (byte k1 = 0; k1 < size; k1++)
		{
			for (byte k2 = 0; k2 < size; k2++)
			{
				Console.Write("|{0,-3}", matrix[k1, k2]);
			}
			Console.WriteLine("|");
		}
	}
}
