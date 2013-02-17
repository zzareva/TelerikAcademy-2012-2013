using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

class P02
{
	static void Main()
	{
		//Console.SetIn(new StreamReader(@"C:\Users\zzareva\Desktop\input1.txt"));
		string[] strCells = Console.ReadLine().Split(',');
		int[] cells = new int[strCells.Length];
		bool[] visited = new bool[strCells.Length];
		for (int i = 0; i < strCells.Length; i++)
		{
			cells[i] = int.Parse(strCells[i].Trim());
		}

		List<int> numberOfCells = new List<int>();
		int now = 0;
		int next = 0;
		int numCells = 1;
		for (int step = 1; step < cells.Length; step++)
		{
			for (int start = 0; start < cells.Length; start++)
			{
				Array.Clear(visited, 0, visited.Length);
				now = start;
				visited[now] = true;
				next = start + step;
				if (next >= cells.Length) { next -= cells.Length; };
				numCells = 1;
				while (cells[now] < cells[next] && !visited[next])
				{
					numCells++;
					visited[next] = true;
					now = next;
					next += step;
					if (next >= cells.Length) { next -= cells.Length; };
				}
				numberOfCells.Add(numCells);
			}
		}
		Console.WriteLine(numberOfCells.Max());
	}
}
