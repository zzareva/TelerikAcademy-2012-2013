using System;

class IsFemale
{
	static void Main()
	{
		Console.WriteLine("Please enter your gender");
		string gender = Console.ReadLine().ToLower();
		bool isFemale = (gender == "female");
		Console.WriteLine("isFemale is {0}", isFemale);
	}
}
