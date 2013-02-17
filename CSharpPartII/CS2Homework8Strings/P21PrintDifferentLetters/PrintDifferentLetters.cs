using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class PrintDifferentLetters
{
	static void Main()
	{
		Console.WriteLine("Please enter the string");
		string input = Console.ReadLine();
		Dictionary<string, int> letters = new Dictionary<string, int>();
		Regex regex = new Regex(@"\w");
		string[] chars = regex.Matches(input).OfType<Match>().Select(m => m.Groups[0].Value).ToArray();
		for (int i = 0; i < chars.Length; i++)
		{
			if (letters.ContainsKey(chars[i]))
				letters[chars[i]]++;
			else
				letters.Add(chars[i], 1);
		}
		letters.OrderByDescending(key => key.Value);
		foreach (var letter in letters)
		{
			Console.WriteLine("{0}: {1} times",letter.Key,letter.Value);
		}
	}
}
