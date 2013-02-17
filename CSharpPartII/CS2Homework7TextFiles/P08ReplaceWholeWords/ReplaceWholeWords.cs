using System;
using System.IO;
using System.Linq;
using System.Text;

class ReplaceWholeWords
{
	static void Main()
	{
		string path = "big text file.txt";

		using (StreamWriter writer = new StreamWriter(path))// generate file
		{
			writer.AutoFlush = true;
			for (int i = 0; i < 1600000; i++)//1600000
			{
				writer.Write("start some test start starting start test some\ntest start ");
			}
		}

		using (StreamWriter writer = new StreamWriter("result.txt", true))
		{
			using (StreamReader reader = new StreamReader(path))
			{
				string line = null;
				line = " " + reader.ReadLine();
				while (line != null)
				{
					line = " " + line + " ";
					string newLine = line.Replace(" start ", " finish ");
					writer.Write(newLine.Trim());
					line = reader.ReadLine();
				}

			}
		}
	}
}