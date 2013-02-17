using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace P08ExtractSentences
{
	class ExtractSentences
	{
		static void Main()
		{
			StringBuilder sb = new StringBuilder();
			Console.WriteLine("Please enter the key word");
			string key = Console.ReadLine();
			Console.WriteLine("Please enter the text");
			string text = Console.ReadLine();
			string[] sentences = text.Split('.');
			StringBuilder pattern = new StringBuilder();
			pattern.Append("\\b");
			pattern.Append(key.ToLower());
			pattern.Append("\\b");
			for (int i = 0; i < sentences.Length; i++)
			{
				if (Regex.IsMatch(sentences[i].ToLower(), pattern.ToString()))
				{
					sb.Append(sentences[i]);
					sb.Append('.');
				}
			}
			Console.WriteLine(sb.ToString());
		}
	}
}
