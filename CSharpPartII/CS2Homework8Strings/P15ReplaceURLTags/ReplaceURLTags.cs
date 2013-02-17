using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class ReplaceURLTags
{
	static string ReplaceATags(string text)
	{
		string result = Regex.Replace(text,@"(<a href=""?(.*?)""?>)(.*?)(<\/a>)", @"[URL=$2]$3[/URL]");
		return result;
	}
	static void Main()
	{
		Console.WriteLine("Please enter the html text:");
		string html = Console.ReadLine();
		Console.WriteLine("Result:\n{0}",ReplaceATags(html));
	}
}
