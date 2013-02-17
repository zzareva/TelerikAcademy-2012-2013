using System;
using System.IO;
using System.Linq;

class ReplaceWords
{
	static void Main(string[] args)
	{
		string path = "big text file.txt";

		using (StreamWriter writer = new StreamWriter(path))// generate file
		{
			writer.AutoFlush = true;
			for (int i = 0; i < 1600; i++)//1600000
			{
				writer.Write("some test start start test some\ntest");
			}
		}

		using (StreamWriter writer = new StreamWriter("result.txt",true))
		{
			using (StreamReader reader = new StreamReader(path))
			{
				string line = null ;
				line = reader.ReadLine();
				while (line != null)
				{
					string newLine = line.Replace("start", "finish");
					writer.Write(newLine);
					line = reader.ReadLine();
				}
					
			}
		}
	}
}