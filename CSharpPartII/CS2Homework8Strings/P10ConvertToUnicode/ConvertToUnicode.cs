using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ConvertToUnicode
{
	static void Main()
	{
		Console.WriteLine("Please enter the text, which should be converted:");
		string text = Console.ReadLine();
		Console.WriteLine("The converted text is:");
		foreach (byte ch in text)
		{
			Console.Write("\\u{0}", ch.ToString("X").PadLeft(4, '0'));
		}
		Console.WriteLine();
	}
}
