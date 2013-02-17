using System;
using System.Linq;
using System.Text.RegularExpressions;

class ExtractEmails
{
	static void Main()
	{
		Console.WriteLine("Please enter the text");
		string text = Console.ReadLine();
		//string text = "jashjhsajh jhjhjhj jkjkj@jhjhj.bg hjhjh@jhjh.bg kaskljdkjak asdjkaj.jhjh.nh";
		Regex regex = new Regex(@"[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})");
		string[] mails = regex.Matches(text).OfType<Match>().Select(m => m.Groups[0].Value).ToArray();
		Console.WriteLine(string.Join(", ",mails));
	}
}
