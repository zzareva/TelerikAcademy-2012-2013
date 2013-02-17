using System;

class AskName
{
	static string GetName()
	{
		Console.Write("Please enter your name: ");
		return Console.ReadLine();
	}
	static void PrintName(string name)
	{
		Console.WriteLine("Hello, {0}", name);
	}
	static void Main()
	{
		string name = GetName();
		PrintName(name);
	}
}
