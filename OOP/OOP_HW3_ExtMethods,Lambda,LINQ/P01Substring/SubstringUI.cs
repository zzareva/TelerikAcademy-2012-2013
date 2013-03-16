//Implement an extension method Substring(int index, int length) 
//for the class StringBuilder that returns new StringBuilder 
//and has the same functionality as Substring in the class String.

using System;
using System.Linq;
using System.Text;

namespace P01Substring
{
	class SubstringUI
	{
		static void Main()
		{
			var testStringBilder = new StringBuilder();
			testStringBilder.Append("0123");
			testStringBilder.Append("456");
			testStringBilder.Append("789");
			testStringBilder.AppendLine("10");
			Console.WriteLine("The input is: {0}",testStringBilder);
			var result = new StringBuilder();
			result = testStringBilder.Substring(2, 4);
			Console.WriteLine("Result is: {0}",result.ToString());
		}
	}
}
