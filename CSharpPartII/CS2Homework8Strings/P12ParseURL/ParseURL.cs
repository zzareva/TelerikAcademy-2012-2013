using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class ParseURL
{
	static void Main()
	{
		Console.WriteLine("Please enter the url:");
		string url = Console.ReadLine();
		try
		{
			Match result = Regex.Match(url, @"(?<protocol>http|ftp|https|file)://(?<domain>[\w\.]+)(?<path>/.*)?");
			Console.WriteLine("protocol: {0}", result.Groups[1].Captures[0].ToString());
			Console.WriteLine("server: {0}", result.Groups[2].Captures[0].ToString());
			Console.WriteLine("resource: {0}", result.Groups[3].Captures[0].ToString());
		}
		catch (Exception)
		{
			Console.WriteLine("Invalid url address.");
		}
		
	}
}