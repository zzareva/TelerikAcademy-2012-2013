using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SampleExamP05Liquid
{
	class Liquid
	{
		static int rowNumber, colNumber, levels;
		static int[, ,] cuboid;
		static int[, ,] water;
		//static int sum = 0;

		static void GetInputData()
		{
			string[] input = Console.ReadLine().Split();
			rowNumber = int.Parse(input[1]);
			colNumber = int.Parse(input[0]);
			levels = int.Parse(input[2]);
			cuboid = new int[rowNumber, colNumber, levels];
			water = new int[rowNumber, colNumber, levels];
			string[] input2 = new string[levels];
			for (int row = 0; row < rowNumber; row++) //Rows
			{
				string line = Console.ReadLine();
				input2 = line.Split('|');
				for (int column = 0; column < colNumber; column++)//Columns
				{
					for (int level = 0; level < levels; level++)//Levels
					{
						string[] columnLine = input2[level].Trim().Split();
						int number = int.Parse(columnLine[column]);
						cuboid[row, column, level] = number;
						if (level == 0)
							water[row, column, level] = number;
					}
				}
			}
		}
		static int SumWater(int level)
		{
			int counter = 0;
			for (int i = 0; i < rowNumber; i++)
			{
				for (int j = 0; j < colNumber; j++)
				{
					counter += water[i, j, level];
				}
			}
			return counter;
		}
		static void CalculateWater()
		{
			for (int level = 0; level < levels; level++)
			{
				if(level > 0)
				{
					int[,] remainingWater = new int[rowNumber, colNumber];
					for (int i = 0; i < rowNumber; i++)
					{
						for (int j = 0; j < colNumber; j++)
						{
							remainingWater[i, j] = water[i, j, level - 1] - cuboid[i, j, level - 1];
						}
					}
					for (int i = 0; i < rowNumber; i++)
					{
						for (int j = 0; j < colNumber; j++)
						{
							if (remainingWater[i, j] > 0)
							{
								if (i - 1 > 0)
									while (remainingWater[i - 1, j] < 0 && remainingWater[i, j] > 0)
									{
										water[i - 1, j, level - 1]++;
										remainingWater[i, j]--;
									}
								if (i + 1 < rowNumber)
									while (remainingWater[i + 1, j] < 0 && remainingWater[i, j] > 0)
									{
										water[i + 1, j, level - 1]++;
										remainingWater[i, j]--;
									}
								if (j - 1 > 0)
									while (remainingWater[i, j - 1] < 0 && remainingWater[i, j] > 0)
									{
										water[i, j - 1, level - 1]++;
										remainingWater[i, j - 1]--;
									}
								if (j + 1 < colNumber)
									while (remainingWater[i, j + 1] < 0 && remainingWater[i, j] > 0)
									{
										water[i, j + 1, level - 1]++;
										remainingWater[i, j]--;
									}
							}
						}
					}
					for (int i = 0; i < rowNumber; i++)
					{
						for (int j = 0; j < colNumber; j++)
						{
							int liquidPerCell = cuboid[i, j, level] - water[i, j, level - 1];
							if (liquidPerCell <= 0)
								water[i, j, level] = cuboid[i, j, level];
							else
							{
								water[i, j, level] = water[i, j, level - 1];
							}
						}
					}

					//For testing
					//Console.WriteLine("---------------------------");
					//for (int i = 0; i < rowNumber; i++)
					//{
					//	for (int j = 0; j < colNumber; j++)
					//	{
					//		Console.Write(water[i, j, level] + " ");
					//	}
					//	Console.WriteLine();
					//}
					//For testing
				}
				if (level == levels - 1)
				{
					Console.WriteLine(SumWater(level));
					return;
				}
			}
		}
		static void Main()
		{
			//Console.SetIn(new StreamReader(@"C:\Users\xx\Desktop\input.txt", true));
			GetInputData();
			CalculateWater();
		}
	}
}
