using System;
using System.Linq;
using System.IO;

class DeleteOddLines
{
	static void Main()
	{
		string path = @"C:\Users\user\Desktop\output.txt";
		StringReader helpReader;//out of the using so we can rewrite the file...
		using (StreamReader reader = new StreamReader(path))
		{
			helpReader = new StringReader(reader.ReadToEnd().ToString());
		}

		using (StreamWriter writer = new StreamWriter(path))
		{
			string line = helpReader.ReadLine();
			int lineNumber = 1;
			while (line != null)
			{
				if (lineNumber % 2 == 0)
				{
					writer.WriteLine(line);
				}
				line = helpReader.ReadLine();
				lineNumber++;
			}
			helpReader.Close();
		}
	}
}