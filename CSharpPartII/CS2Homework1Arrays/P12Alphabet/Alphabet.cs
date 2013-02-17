using System;

class Alphabet
{
	static void Main()
	{
		char[] alphabetArray = new char[26];
		Console.WriteLine("Please enter a word:");
		string wordInput = (Console.ReadLine().ToLower());

		for (int i = 0; i < 26; i++)
		{
			alphabetArray[i] = (char)('a' + i);
		}

		Console.WriteLine("The indices of the letters are:");
		for (int k = 0; k < wordInput.Length; k++)
		{
			Console.WriteLine("{0} - {1}", wordInput[k], wordInput[k] - 'a');
		}
	}
}