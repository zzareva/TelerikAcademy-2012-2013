using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class CaseInsensitiveSearch
{
	static void Main()
	{
		Console.WriteLine("Please enter the substring: ");
		string substring = Console.ReadLine().ToLower();
		Console.WriteLine("Please enter the text: ");
		string text = Console.ReadLine().ToLower();
		string pattern = "(" + substring + ")";
		Regex regex = new Regex(pattern);
		Console.WriteLine("The result: {0}", regex.Matches(text).Count);
	}
}
