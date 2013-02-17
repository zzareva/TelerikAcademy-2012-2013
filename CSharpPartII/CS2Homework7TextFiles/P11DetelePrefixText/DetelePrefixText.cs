using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class DetelePrefixText
{
	static void Main()
	{
		string input = "input.txt";
		string output = "output.txt";

		using (StreamWriter writer = new StreamWriter(input))// generate test file
		{
			writer.AutoFlush = true;
			for (int i = 0; i < 1600; i++)
			{
				writer.Write("start sometest testwordtobedeleted ");
			}
		}

		using (StreamWriter writer = new StreamWriter(output, true))
		{
			using (StreamReader reader = new StreamReader(input))
			{
				string line = null;
				line = " " + reader.ReadLine();
				string newLine = "";
				while (line != null)
				{
					string pattern = "\\s?(test){1}[0-9,a-z,A-Z,_]+";
					Regex regex = new Regex(pattern);
					foreach (var match in regex.Matches(line))
					{
						line = line.Replace(match.ToString(), string.Empty);
					}
					writer.Write(line);
					line = reader.ReadLine();
				}
			}
		}
		File.Replace(output, input,"tempBackup.txt"); //replacing the input file with the result
		File.Delete(output);
		File.Delete("tempBackup.txt"); //and cleaning both unneeded files
	}
}