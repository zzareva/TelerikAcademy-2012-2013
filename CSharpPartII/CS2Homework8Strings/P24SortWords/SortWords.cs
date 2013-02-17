using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SortWords
{
	static void Main()
	{
		Console.WriteLine("Please enter the list of words, separated by spaces");
		List<string> words = Console.ReadLine().Split(' ').ToList<string>();
		words.Sort();
		Console.WriteLine("Sorted list:");
		Console.WriteLine(string.Join("\n",words));
	}
}

