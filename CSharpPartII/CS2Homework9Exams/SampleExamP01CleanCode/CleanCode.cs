using System;
using System.Text;
using System.IO;

class CleanCode
{
	static void Main()
	{
		//Console.SetIn(new StreamReader(@"C:\Users\xx\Desktop\input.txt"));
		StringBuilder output = new StringBuilder();
		StringBuilder finalOutput = new StringBuilder();
		bool isString = false;
		char isComment = '0';
		int lineNumbers = int.Parse(Console.ReadLine());

		for (int i = 0; i < lineNumbers; i++)
		{
			char previous = '\t';
			char previous2 = '\t';
			char[] input = Console.ReadLine().ToCharArray();
			for (int j = 0; j < input.Length; j++)
			{
				bool write = true;
				if (input[j] == '"' && previous != '\\' && isComment == '0')
					isString = !isString;
				else if (previous2 != '/' && previous2 != '\t' && previous == '/' && input[j] == '/' && isString == false && isComment != 'S' && isComment != 'M')
				{
					isComment = 'S';
					output.Remove(output.Length - 1, 1);
					break;
				}
				else if (previous2 == '/' && previous == '/' && input[j] == '/' && isString == false && isComment != 'S' && isComment != 'M')
				{
					isComment = 'D';
				}
				else if (previous == '/' && input[j] == '*' && isString == false && isComment != 'S' && isComment != 'M')
				{
					isComment = 'M';
					output.Remove(output.Length - 1, 1);
				}
				if (previous == '*' && input[j] == '/' && isComment == 'M' && isString == false)
				{
					isComment = '0';
					write = false;

				}

				if ( isComment != 'S' && isComment != 'M' && write != false)
				{
					output.Append(input[j]);
				}
				previous2 = previous;
				previous = input[j];

			}
			if (output.Length > 0 && !OnlyWhiteSpace(output.ToString()))
			{
				if (isComment == 'M')
					finalOutput.Append(output.ToString());
				else
				{
					finalOutput.AppendLine(output.ToString());
				}
			}
			output.Clear();
			if (isComment == 'S' || isComment == 'D') isComment = '0';
			previous = '\t';
			previous2 = '\t';
		}
		Console.WriteLine(finalOutput.ToString());
	}
	private static bool OnlyWhiteSpace(string text)
	{
		bool isWhiteSpace = true;
		char[] whiteSpCharacters = { ' ', '\t', '\n', '\r' };
		foreach (char ch in text)
		{
			if (Array.IndexOf(whiteSpCharacters, ch) < 0)
				isWhiteSpace = false;
		}
		return isWhiteSpace;
	}
}

