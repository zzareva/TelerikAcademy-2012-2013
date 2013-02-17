using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class CheckBrackets
{
	static void Main()
	{
		Console.Write("Expression: ");
		string input = Console.ReadLine();
		int openBrackets = 0;
		bool wrongBrackets = false;
		foreach (char el in input)
		{
			if (el == '(')
				openBrackets++;
			else if (el == ')')
				openBrackets--;
			if (openBrackets < 0)
			{
				wrongBrackets = true;
				break;
			}
		}
		if (openBrackets != 0)
			wrongBrackets = true;
		Console.WriteLine("The brackets are {0}", wrongBrackets ? "wrong" : "correct");
	}
}
