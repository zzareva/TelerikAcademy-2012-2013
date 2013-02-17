using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class Star3D
{
	static int rowNumber, colNumber, levels;
	static char[, ,] cuboid;
	//static int sum = 0;

	static void GetInputData()
	{
		string[] input = Console.ReadLine().Split();
		rowNumber = int.Parse(input[1]);
		colNumber = int.Parse(input[0]);
		levels = int.Parse(input[2]);
		cuboid = new char[rowNumber, colNumber, levels];
		string[] input2 = new string[levels];
		for (int row = 0; row < rowNumber; row++) //Rows
		{
			input2 = Console.ReadLine().Split(' ');
			for (int column = 0; column < colNumber; column++)//Columns
			{
				for (int level = 0; level < levels; level++)//Levels
				{
					string columnLine = input2[level].Trim();
					cuboid[row, column, level] = columnLine[column];
				}
			}
		}
	}
	static void CountStars()
	{
		Dictionary<char, int> stars = new Dictionary<char, int>();
		for (int row = 1; row < rowNumber - 1; row++) //Rows
		{
			for (int col = 1; col < colNumber - 1; col++)//Columns
			{
				for (int le = 1; le < levels - 1; le++)//Levels
				{
					int equals = 0;
					char ch = cuboid[row, col, le];
					if (ch == cuboid[row - 1, col, le] && ch == cuboid[row + 1, col, le])
						equals++;
					else continue;
					if (ch == cuboid[row, col - 1, le] && ch == cuboid[row, col + 1, le])
						equals++;
					else continue;
					if (ch == cuboid[row, col, le - 1] && ch == cuboid[row, col, le + 1])
						equals++;
					else continue;
					if (equals == 3)
						if (!stars.ContainsKey(ch))
							stars.Add(ch, 1);
						else
							stars[ch]++;
				}
			}
		}
		Console.WriteLine(stars.Sum(x => x.Value));
		foreach (var star in stars.OrderBy(x => x.Key))
		{
			Console.WriteLine("{0} {1}", star.Key, star.Value);
		}

	}
	static void Main(string[] args)
	{
		//Console.SetIn(new StreamReader(@"C:\Users\xx\Desktop\input.txt", true));
		GetInputData();
		CountStars();
	}
}