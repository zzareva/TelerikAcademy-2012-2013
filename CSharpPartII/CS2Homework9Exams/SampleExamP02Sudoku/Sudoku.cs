using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SampleExamP02Sudoku
{
	class Sudoku
	{
		private static void GetInput()
		{
			string line = "";
			for (int row = 0; row < inputTable.GetLength(1); row++)
			{
				line = Console.ReadLine().Replace('-', '0');
				for (int col = 0; col < inputTable.GetLength(0); col++)
				{
					inputTable[row, col] = (byte)(line[col] - '0');
				}
			}
		}
		private static void PrintResult()
		{
			StringBuilder output = new StringBuilder();
			for (int row = 0; row < inputTable.GetLength(1); row++)
			{
				for (int col = 0; col < inputTable.GetLength(0); col++)
				{
					output.Append(inputTable[row, col]);
				}
				output.Append('\n');
			}
			Console.WriteLine(output.ToString());
		}
		static byte[,] inputTable = new byte[9, 9];
		static byte[,] tempTable = new byte[9, 9];
		static void Main()
		{
			StreamReader sr = new StreamReader(@"C:\Users\zzareva\Desktop\input.txt");
			Console.SetIn(sr);
			GetInput();

			

			PrintResult();
		}
	}
}
