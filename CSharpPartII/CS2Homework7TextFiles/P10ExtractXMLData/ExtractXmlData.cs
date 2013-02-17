using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class ExtractXmlData
{
	static void Main()
	{
		List<string> data = new List<string>();
		string input = @"C:\Users\user\Desktop\output.txt";
		using (StreamReader sr = new StreamReader(input))
		{
			string line = sr.ReadLine();
			int closingTagIndex = -1;
			int openingTagIndex = -1;
 			while(line != null)
			{
				while(closingTagIndex < line.Length - 1)
				{
					closingTagIndex = line.IndexOf('>',openingTagIndex + 1);
					openingTagIndex = line.IndexOf('<',closingTagIndex + 1);
					if (closingTagIndex != openingTagIndex - 1 && closingTagIndex > 0 && openingTagIndex > 0)
					{
						data.Add(line.Substring(closingTagIndex + 1, openingTagIndex - closingTagIndex - 1));
					}
				}
				line = sr.ReadLine();
			}
		}
		Console.WriteLine(string.Join(", ", data));
	}
}