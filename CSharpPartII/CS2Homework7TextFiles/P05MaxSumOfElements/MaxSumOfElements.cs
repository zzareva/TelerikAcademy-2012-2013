using System;
using System.IO;

class SquareWithMaxSum
{
	private static int[,] ReadInputData(string inputFile)
	{
		using (StreamReader sr = new StreamReader(inputFile))
		{
			int n = int.Parse(sr.ReadLine());
			int[,] matrix = new int[n, n];
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				string[] inputLines = sr.ReadLine().Split(' ');
				for (int j = 0; j < matrix.GetLength(0); j++)
				{
					matrix[i, j] = int.Parse(inputLines[j]);
				}
			}
			return matrix;
		}
	}

	private static int GetMaxSum(int[,] matrix)
	{
		int maxSum = 0;
		int tempSum = 0;
		for (int p = 0; p < matrix.GetLength(0) - 1; p++) //column
		{
			for (int q = 0; q < matrix.GetLength(0) - 1; q++) //row
			{
				tempSum = matrix[q, p] + matrix[q, p + 1];
				tempSum += (matrix[q + 1, p] + matrix[q + 1, p + 1]);
				if ((p == 0 && q == 0) || (tempSum > maxSum))
				{
					maxSum = tempSum;
				}
			}
		}
		return maxSum;
	}
	private static void PrintToFile(int output)
	{
		using(StreamWriter sw = new StreamWriter("output.txt"))
		{
			sw.WriteLine(output);
			Console.WriteLine("The result file is generated!");
		}
	}
	static void Main()
	{
		try
		{
			int[,] matrix = ReadInputData("input.txt");
			PrintToFile(GetMaxSum(matrix));
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}
}
