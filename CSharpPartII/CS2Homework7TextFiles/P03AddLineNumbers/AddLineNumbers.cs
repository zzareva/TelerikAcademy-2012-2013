using System;
using System.IO;
using System.Security;
using System.Text;

class AddLineNumbers
{
	private static void CreateNewFileWithLineNumbers(string input, string output)
	{
		using (StreamWriter outputWriter = new StreamWriter(output, true, Encoding.UTF8))
		{
			outputWriter.AutoFlush = true;
			using (StreamReader reader = new StreamReader(input, true))
			{
				int lineCounter = 1;
				string lineContent = reader.ReadLine();
				while (lineContent != null)
				{
					outputWriter.WriteLine("{0,-4} {1}", lineCounter, lineContent);
					lineContent = reader.ReadLine();
					lineCounter++;
				}
			}
		}
	}
	static void Main()
	{
		try
		{
			CreateNewFileWithLineNumbers("input.txt", "output.txt");
			Console.WriteLine("The new file is created!");
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}
}
