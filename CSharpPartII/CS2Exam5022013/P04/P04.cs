using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

class P04
{
	static void Main()
	{
		//Console.SetIn(new StreamReader(@"C:\Users\zzareva\Desktop\input1.txt"));
		int lines = int.Parse(Console.ReadLine());
		string indent = Console.ReadLine();
		string line = "";
		int indN = 0;
		char next = '0';
		bool afterLineBreak = false;
		StringBuilder lineOutput = new StringBuilder();
		StringBuilder finalOutput = new StringBuilder();
		for (int i = 0; i < lines; i++)
		{
			line = Console.ReadLine().Trim();
			bool done = false;
			for (int c = 0; c < line.Length; c++)
			{
				char current = line[c];
				if (c + 1 < line.Length - 2)
					next = line[c + 1];
				if (current == '}')
				{
					indN--;
				}
				if (current == '{' || current == '}')
				{
					if (c != 0)
					{
						if (lineOutput.ToString().Trim().Length > 0 && lineOutput.ToString().Replace(indent, "").Length > 0)
						{
							finalOutput.AppendLine(lineOutput.ToString().Trim());
						}
						lineOutput.Clear();
						done = false;
					}
					afterLineBreak = true;
				}
				if ((current != ' ' || next != ' ') && (current != ' ' || afterLineBreak == false))
				{
					lineOutput.Append(current);
					if (current != '{' && current != '}')
						afterLineBreak = false;
				}
				if (lineOutput.ToString() != "" && !done)
				{
					done = true;
					if (lineOutput.ToString().Trim().Length > 0)
					{
						for (int k = 0; k < indN; k++)
						{
							lineOutput.Insert(0, indent);
						}
					}
				}
				if (current == '{' || current == '}')
				{
					if (current == '{')
					{
						indN++;
					}
					if (c < line.Length - 1 || c == 0)
					{
						if (lineOutput.ToString().Trim().Length > 0 && lineOutput.ToString().Replace(indent, "").Length > 0)
						{
							if (lineOutput.ToString().Trim().Length > 0 && lineOutput.ToString().Replace(indent, "").Length > 0)
							{
								finalOutput.AppendLine(lineOutput.ToString().Trim());
							}
							lineOutput.Clear();
							done = false;
						}
						lineOutput.Clear();
						done = false;
					}
				}
				next = '0';

			}
			if (lineOutput.ToString().Trim().Length > 0 && lineOutput.ToString().Replace(indent,"").Length > 0)
			{
				finalOutput.AppendLine(lineOutput.ToString().Trim());
			}
			lineOutput.Clear();
			done = false;
		}
		Console.WriteLine(finalOutput.ToString());
	}
}
