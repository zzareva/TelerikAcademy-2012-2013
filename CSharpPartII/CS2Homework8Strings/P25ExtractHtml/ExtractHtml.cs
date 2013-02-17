using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;

class ExtractHtml
{
	static void Main()
	{
		List<string> data = new List<string>();
		string input = @"C:\Users\user\Desktop\index.html";
		string output = "";
		using (StreamReader sr = new StreamReader(input))
		{
			string line = sr.ReadLine();
			while(line!= null)
			{
				Regex objRegExp = new Regex("<(.|\n)+?>|\t");
				output = objRegExp.Replace(line, String.Empty);
				if (Regex.IsMatch(output, @"[a-zA-Z0-9]+"))
					data.Add(output);
				line = sr.ReadLine();
			}
		}
		Console.WriteLine(string.Join(", ",data));
	}
}