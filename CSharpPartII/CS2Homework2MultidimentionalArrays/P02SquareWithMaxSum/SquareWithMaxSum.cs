using System;

class SquareWithMaxSum
{
	static void Main()
	{
		Console.WriteLine("Please enter the number of the number of the rows in the matrix:");
		int n = GetMatrixSize();
		Console.WriteLine("Please enter the number of the number of the columns in the matrix:");
		int m = GetMatrixSize();
		int[,] matrix = new int[n,m];
		for (int i = 0; i < n; i++)//row
		{
			for (int j = 0; j < m; j++)//column
			{
				Console.Write("Enter matrix[{0},{1}]:",i,j);
				matrix[i, j] = GetNumber();
			}
		}
		int maxSum = 0;
		int tempSum = 0;
		string tempSubset = "";
		string maxSubset = "";
		for (int p = 0; p < m - 2; p++) //column
		{
			for (int q = 0; q < n - 2; q++) //row
			{
				tempSum = matrix[q, p] + matrix[q, p + 1] + matrix[q, p + 2];
				tempSum += (matrix[q + 1, p] + matrix[q + 1, p + 1] + matrix[q + 1, p + 2]);
				tempSum += (matrix[q + 2, p] + matrix[q + 2, p + 1] + matrix[q + 2, p + 2]);
				tempSubset = "" + matrix[q, p] + ", " + matrix[q, p + 1] + ", " + matrix[q, p + 2] + "\n";
				tempSubset += (matrix[q + 1, p] + ", " + matrix[q + 1, p + 1] + ", " + matrix[q + 1, p + 2] + "\n");
				tempSubset += (matrix[q + 2, p] + ", " + matrix[q + 2, p + 1] + ", " + matrix[q + 2, p + 2] + "\n");
				if ((p == 0 && q == 0) || (tempSum > maxSum))
				{
					maxSum = tempSum;
					maxSubset = tempSubset;
				}
			}
		}
		Console.WriteLine("The maximum sum is: {0}",maxSum);
		Console.WriteLine("And the field with the maximum sum is: \n{0}",maxSubset);
	}
	static int GetMatrixSize()
	{
		int number = 0;
		while (!int.TryParse(Console.ReadLine(), out number) || number < 3)
		{
			Console.ForegroundColor = System.ConsoleColor.Red;
			Console.WriteLine("Incorrect data input! Please privide a valid integer number > 3.");
			Console.ForegroundColor = System.ConsoleColor.Gray;
		}
		return number;
	}
	static int GetNumber()
	{
		int number = 0;
		while(!int.TryParse(Console.ReadLine(), out number))
		{
			Console.ForegroundColor = System.ConsoleColor.Red;
			Console.WriteLine("Incorrect data input! Please privide a valid integer number.");
			Console.ForegroundColor = System.ConsoleColor.Gray;
		}
		return number;
	}
}
