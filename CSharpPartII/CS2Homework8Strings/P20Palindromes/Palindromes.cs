using System;
using System.Collections.Generic;

class Palindromes
{
	private static List<string> GetPalindromes(string text)
	{
		string[] words = text.Split(' ', ',', '.', '?', '!', ':', ';');
		List<string> palindromes = new List<string>();

		foreach (string word in words)
		{
			if (word.Equals(string.Empty))
				continue;

			bool isPalindrome = true;
			for (int i = 0; i < word.Length / 2; i++)
			{
				if (!word[i].Equals(word[word.Length - i - 1]))
				{
					isPalindrome = false;
					break;
				}
			}
			if (isPalindrome)
			{
				palindromes.Add(word);
			}
		}

		return palindromes;
	}

	static void Main(string[] args)
	{
		Console.WriteLine("Please enter the input strings:");
		string text = Console.ReadLine();
		List<string> palindromes = GetPalindromes(text);
		if (palindromes.Count == 0)
		{
			Console.WriteLine("There are no palindrones in the string");
		}
		else
		{
			Console.WriteLine("The palindrones are:");
			Console.WriteLine(string.Join(", ", palindromes));
		}
	}
}