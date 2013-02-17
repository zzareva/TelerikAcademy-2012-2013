using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

struct Position
{
	public int r;
	public int c;
	public int z;
	public Position(int r, int c, int z)
	{
		this.r = r;
		this.c = c;
		this.z = z;
	}
}
class MaxWalk3D
{
	static int R, C, D;
	static int[, ,] cuboid;
	static bool[, ,] path;
	static int sum = 0;
	static List<Position> maxPeers = new List<Position>();

	static void Main()
	{
		//Console.SetIn(new StreamReader(@"C:\Users\xx\Desktop\input.txt",true));
		GetInputData();
		Position currentPosition = new Position(FindCenter(R), FindCenter(C), FindCenter(D));
		sum+=cuboid[currentPosition.r,currentPosition.c,currentPosition.z];
		if(R == 1 && C == 1 && D == 1)
			Console.WriteLine(sum);
		else
			MoveToMax(currentPosition);
	}

	static void GetInputData()
	{
		string[] input = Console.ReadLine().Split(' ');
		R = int.Parse(input[1]);
		C = int.Parse(input[0]);
		D = int.Parse(input[2]);
		cuboid = new int[R, C, D];
		path = new bool[R, C, D];
		string[] input2 = new string[3];
		for (int row = 0; row < cuboid.GetLength(0); row++) //Rows
		{
			input2 = Console.ReadLine().Split('|');
			for (int col = 0; col < cuboid.GetLength(1); col++)//Columns
			{
				for (int depth = 0; depth < cuboid.GetLength(2); depth++)//Depth
				{
					string[] columnLine = input2[depth].Trim().Split();
					cuboid[row, col, depth] = int.Parse(columnLine[col]);
				}
			}
		}
	}

	static int FindCenter(int input)
	{
		return (int)Math.Floor((decimal)input / 2);
	}

	static void MoveToMax(Position current)
	{
		path[current.r, current.c, current.z] = true;
		Position newCurrent = new Position();
		int newMax = int.MinValue;
		for (int row = 0; row < cuboid.GetLength(0); row++)
		{
			newCurrent = new Position(row, current.c, current.z);
			newMax = PopulateMaxPeers(current, newCurrent, newMax);
		}
		for (int col = 0; col < cuboid.GetLength(1); col++)
		{
			newCurrent = new Position(current.r, col, current.z);
			newMax = PopulateMaxPeers(current, newCurrent, newMax);
		}
		for (int dep = 0; dep < cuboid.GetLength(2); dep++)
		{
			newCurrent = new Position(current.r, current.c, dep);
			newMax = PopulateMaxPeers(current, newCurrent, newMax);
		}
		int maxValue = cuboid[maxPeers[0].r,maxPeers[0].c,maxPeers[0].z];
		if (maxPeers.Count == 1 && path[maxPeers[0].r, maxPeers[0].c, maxPeers[0].z] == false)
		{
			sum += maxValue;
			MoveToMax(maxPeers[0]);
		}
		else
		{
			Console.WriteLine(sum);
			return;
		}
		return;
	}
	static int PopulateMaxPeers(Position current, Position newCurrent, int newMax)
	{
		var newValue = cuboid[newCurrent.r, newCurrent.c, newCurrent.z];
		if (!current.Equals(newCurrent) && newValue >= newMax)
		{
			if (newValue > newMax)
			{
				maxPeers.Clear();
				newMax = newValue;
			}
			maxPeers.Add(newCurrent);
		}
		return newMax;
	}
}