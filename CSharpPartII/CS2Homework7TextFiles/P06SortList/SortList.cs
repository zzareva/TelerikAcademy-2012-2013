using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class SortList
{
	static void Main()
	{
		string inputPath = "input.txt";
		string resultPath = "output.txt";
		List<string> strings = new List<string>();
		using (StreamReader reader = new StreamReader(inputPath))
		{
			string line = reader.ReadLine();
			while (line != null)
			{
				strings.Add(line);
				line = reader.ReadLine();
			}
		}

		strings.Sort();

		using (StreamWriter writer = new StreamWriter(resultPath))
		{
			foreach (string item in strings)
			{
				writer.WriteLine(item);
			}
			Console.WriteLine("The result file is generated!");
		}
	}
}