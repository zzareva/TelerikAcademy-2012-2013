using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

class ExtractDate
{
	static void Main()
	{
		Console.WriteLine("Please enter the text");
		//string text = Console.ReadLine();
		string text = "jashjhsajh jhjhjhj 12.12.2010 jkjkj@jhjhj.bg hjhjh@jhjh.bg 20.05.1999 kaskljdkjak asdjkaj.jhjh.nh";
		Regex regex = new Regex(@"([1-9]|0[1-9]|1[0-9]|2[0-9]|3[0-1])[.]([1-9]|0[1-9]|1[0-9]|2[0-9]|3[0-1])[.](1[0-9][0-9][0-9]|2[0-9][0-9][0-9])");
		string[] mails = regex.Matches(text).OfType<Match>().Select(m => m.Groups[0].Value).ToArray();
		CultureInfo ca = new CultureInfo("en-CA");
		foreach (string date in mails)
		{
			Console.WriteLine(DateTime.ParseExact(date, "dd.MM.yyyy", ca));
		}
	}
}
