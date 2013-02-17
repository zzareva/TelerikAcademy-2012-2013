using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class PHPVariables
{
	static void Main()
	{
		//Console.SetIn(new StreamReader(@"C:\Users\xx\Desktop\input.txt"));
		StringBuilder name = new StringBuilder();
		bool isString = false;
		char isComment = '0';
		List<string> uniqueVariables = new List<string>();
		string consoleInput = "";
		while ((consoleInput = Console.ReadLine()) != null)
		{
			char previous = '0';
			bool variable = false;
			char[] input = consoleInput.ToCharArray();
			for (int j = 0; j < input.Length; j++)
			{
				char theChar = input[j];
				if (theChar == '"' && isComment == '0' && previous!= '(' && input[j+1] != ')')
					isString = !isString;
				else if(previous == '/' && theChar == '/' && isString == false && isComment == '0')
				{
					isComment = 'S';
					break;
				}
				else if (previous == '/' && theChar == '*' && isString == false && isComment == '0')
				{
					isComment = 'M';
				}
				if (previous == '*' && theChar == '/' && isComment == 'M' && isString == false)
				{
					isComment = '0';
					
				}
				if ((!char.IsLetterOrDigit(theChar) && theChar != '_' && variable == true))
					{
						variable = false;
						if (!uniqueVariables.Contains(name.ToString()))
							uniqueVariables.Add(name.ToString());
						name.Clear();
					}
				if (variable == true)
				{
					name.Append(theChar);
				}

				if (isComment == '0' && isString == false)
				{
					if (theChar == '$')
						variable = true;
					
				}
				previous = theChar;
			}
			if (isComment == 'S')
				isComment = '0';
			if (name.ToString() != "" && !uniqueVariables.Contains(name.ToString()))
				uniqueVariables.Add(name.ToString());
			name.Clear();
		}
		Console.WriteLine(uniqueVariables.Count);
		uniqueVariables.Sort();

		foreach (var el in uniqueVariables)
		{
			Console.WriteLine(el);
		}
	}
}
