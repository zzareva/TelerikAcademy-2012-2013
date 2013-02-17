using System;

class ReverseString
{
	private static string Reverse(string str)
	{
		char[] splitStr = str.ToCharArray();
		Array.Reverse(splitStr);
		return string.Join("", splitStr);
	}
	static void Main()
	{
		Console.WriteLine("Please enter the input string");
		string input = Console.ReadLine();
		Console.WriteLine("Result: {0}", Reverse(input));
	}
}
