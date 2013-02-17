using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Dictionary
{
	static void Main()
	{
		Dictionary<string, string> sampleDictionary = new Dictionary<string, string>();
		sampleDictionary.Add(".NET","platform for applications from Microsoft");
		sampleDictionary.Add("CLR","managed execution environment for .NET");
		sampleDictionary.Add("namespace", "hierarchical organization of classes");
		Console.WriteLine("Please enter the word you want to look up in the dictionary:");
		string key = Console.ReadLine();
		try
		{
			Console.WriteLine("Definition: {0}",sampleDictionary[key]);
		}
		catch (Exception)
		{
			Console.WriteLine("There is no definition for \"{0}\" in the dictionary",key);
		}
	}
}
