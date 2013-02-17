using System;
using System.Linq;
using System.Text;

class ConsecutiveLetters
{
	static void Main()
	{
		Console.WriteLine("Please enter the input string:");
		string input = Console.ReadLine();
		StringBuilder sb = new StringBuilder();
		char previousChar = '\r';
		foreach (char el in input)
		{
			if (el != previousChar)
			{
				sb.Append(el);
				previousChar = el;
			}
		}
		Console.WriteLine("Result: {0}", sb.ToString());
	}
}
