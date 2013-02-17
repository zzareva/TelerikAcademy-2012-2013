using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Diagnostics;

class FallingRocksGame
{
	static int dwarfPosition = Console.WindowWidth / 2;
	static int startTime = Environment.TickCount;
	static int gameScore = 0;
	static int gameLevel = 1;
	static int timeBetweenNewRocks = 5;
	static bool gameExit = false;
	class Rock
	{
		public int row;
		public int col;
		public string form;
		public int size;
		public Rock(int row, int col, string form, int size)
		{
			this.row = row;
			this.col = col;
			this.form = form;
			this.size = size;
		}
	}
	static string[] forms = {"^","@","*","&","+","%","$","#","!",".",";"};

	static Random randomNumber = new Random();
	static List<Rock> rocks = new List<Rock>()
		{
		new Rock(1,randomNumber.Next(0, Console.WindowWidth - 2),forms[randomNumber.Next(0,forms.Length - 1)],randomNumber.Next(1,3))
		};

	static void GenerateNewRock()
	{
		Rock newRock;
		int randomNewRocksNumber = randomNumber.Next(1,gameLevel+1);
		for (int newRocksNum = 1; newRocksNum <= gameLevel; newRocksNum++)
		{
			do
			{

				int newSize = randomNumber.Next(1, randomNumber.Next(2, 4));//just reducing the chance for the big rocks
				newRock = new Rock(1, randomNumber.Next(0, Console.WindowWidth - newSize), forms[randomNumber.Next(0, forms.Length - 1)], newSize);
			}
			while (rocks.Contains(newRock));
			rocks.Add(newRock);
		}
	}

	static void ConsoleFormat()
	{
		Console.BufferHeight = Console.WindowHeight;
		Console.BufferWidth = Console.WindowWidth;
	}
	static void PrintDwarf()
	{
		Console.SetCursorPosition(dwarfPosition,Console.WindowHeight - 1);
		Console.ForegroundColor = System.ConsoleColor.Red;
		Console.Write("(0)");
	}
	static void PrintRocks()
	{
		foreach (Rock stone in rocks)
		{
			Console.SetCursorPosition(stone.col, stone.row);
			switch (stone.form)
			{
				case "^":
				case ".":
					Console.ForegroundColor = System.ConsoleColor.Cyan;
					break;
				case "@":
					Console.ForegroundColor = System.ConsoleColor.Yellow;
					break;
				case "*":
					Console.ForegroundColor = System.ConsoleColor.Magenta;
					break;
				case "&":
				case "+":
					Console.ForegroundColor = System.ConsoleColor.Blue;
					break;
				case "%":
				case "$":
					Console.ForegroundColor = System.ConsoleColor.Green;
					break;
				case "#":
				case "!":
					Console.ForegroundColor = System.ConsoleColor.Blue;
					break;
				default:
					Console.ForegroundColor = System.ConsoleColor.Yellow;
					break;
				
			}
			for(var f = 1;f <= stone.size;f++)
			Console.Write(stone.form);
		}
	}
	static void MoveRocks()
	{
		foreach(var rock in rocks)
		{
			if (rock.row < Console.WindowHeight - 1)
			{
				rock.row++;
			}
		}
	}
	static void RemoveRocks()
	{
		for(var i = 0; i < rocks.Count; i++)
		{
			if ((rocks[i].row == Console.WindowHeight - 1) && (((rocks[i].col >= dwarfPosition) && (rocks[i].col <= dwarfPosition + 2)) || (rocks[i].size > 1 && (rocks[i].col + 1 >= dwarfPosition) && (rocks[i].col + 1 <= dwarfPosition + 2)) || (rocks[i].size > 2 && (rocks[i].col + 2 >= dwarfPosition) && (rocks[i].col + 2 <= dwarfPosition + 2))))
			{
				Console.SetCursorPosition(Console.WindowWidth / 2 - 10, Console.WindowHeight / 2);
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write("Game over!");
				gameExit = true;
			}
			else if (rocks[i].row == Console.WindowHeight - 1)
			{
				rocks[i].form = "";
				rocks.RemoveAt(i);
				gameScore++;
				if (gameScore % 10 == 0)
				{
					gameLevel++;
				}
			}
		}
	}
	static void MoveDwarfLeft()
	{
		if (dwarfPosition > 0)
		{
			dwarfPosition--;
		}
	}
	static void MoveDwarfRight()
	{
		if (dwarfPosition < Console.WindowWidth - 4)
		{
			dwarfPosition++;
		}
	}
	static void PrintPoints()
	{
		Console.SetCursorPosition(0,0);
		Console.ForegroundColor = System.ConsoleColor.Green;
		Console.Write("Points: {0} | Level: {1}",gameScore, gameLevel);
	}
	static void Main()
	{
		ConsoleFormat();
		while (true)
		{
			if (gameExit == false)
			{
				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo keyInfo = Console.ReadKey();
					if (keyInfo.Key == ConsoleKey.LeftArrow)
					{
						MoveDwarfLeft();
					}
					else if (keyInfo.Key == ConsoleKey.RightArrow)
					{
						MoveDwarfRight();
					}
				}
				Console.Clear();
				PrintPoints();
				PrintDwarf();
				MoveRocks();
				PrintRocks();
				RemoveRocks();
				int currentTime = Environment.TickCount;
				if (((currentTime - startTime)/10) % timeBetweenNewRocks == 0)
				{
					GenerateNewRock();
				}
			}
			Thread.Sleep(150);
		}
	}
}