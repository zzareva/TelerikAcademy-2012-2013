using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace P09ForbiddenWords
{
	class ForbiddenWords
	{
		static void Main()
		{
			Console.WriteLine("Please enter the forbidden words separated by a single comma, e.g PHP,CLR,Microsoft.");
			string[] forbiddenWords = Console.ReadLine().Split(',');
			Console.WriteLine("Please enter the text:");
			string text = Console.ReadLine();
			for (int i = 0; i < forbiddenWords.Length; i++)
			{
				Regex regex = new Regex(@"\b" + forbiddenWords[i] + @"\b");
				text = regex.Replace(text, ReplaceWithAsterics);
			}
			Console.WriteLine(text);
		}
		public static string ReplaceWithAsterics(Match match)
		{
			return new string('*',match.Value.Length);
		}
	}
}
