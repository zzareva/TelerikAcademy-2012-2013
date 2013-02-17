using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P13ReverseWordsInSentence
{
	class ReverseWordsInSentence
	{
		private static string ReverseWords(string sentence)
		{
			List<string> list = new List<string>();
			foreach(Match match in Regex.Matches(sentence, @"\b\S+"))
			{
				list.Add(match.Value);
			}
			Dictionary<int,char> dotsAndOthers = new Dictionary<int,char>();
			for (int i = 0; i < list.Count; i++)
			{
				char ch = list[i][list[i].Length - 1];
				if (ch == '.' || ch == ',' || ch == '!')
				{
					dotsAndOthers.Add(i,ch);
					list[i] = list[i].Substring(0, list[i].Length - 1);
				}
			}
			list.Reverse();
			foreach (var item in dotsAndOthers)
			{
				list[item.Key] += item.Value;
			} 
			return string.Join(" ", list);
		}

		static void Main()
		{
			string sentence = "C# is not C++, not PHP and not Delphi!";
			Console.WriteLine(ReverseWords(sentence));
		}
	}
}
