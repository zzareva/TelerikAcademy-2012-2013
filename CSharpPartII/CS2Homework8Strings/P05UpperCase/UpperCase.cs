using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class UpperCase
{
	static void Main()
	{
		Console.WriteLine("Please enter the text: ");
		string text = " " + Console.ReadLine();
		Regex regex = new Regex(@"<upcase>(.*?)<\/upcase>");
		var result = regex.Replace(text, ReplaceToUpperCase);

		Console.WriteLine(result);
	}

	public static string ReplaceToUpperCase(Match match)
	{
		return match.Groups[1].Captures[0].Value.ToUpper();
	}
}
