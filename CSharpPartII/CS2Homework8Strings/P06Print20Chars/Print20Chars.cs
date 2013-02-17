using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P06Print20Chars
{
	class Print20Chars
	{
		static void Main()
		{
			Console.WriteLine("Please enter a string with length up to 20 characters.");
			string input = Console.ReadLine();
			Console.WriteLine("Result: {0}", input.PadRight(20,'*'));
		}
	}
}
