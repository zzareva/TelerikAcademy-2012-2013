using System;
using System.Collections.Generic;
using System.IO;
using System.Security;
using System.Text;

class TextFilesConcatenation
{
	private static void CopyFileContent(string inputFileName, StreamWriter outputWriter)
	{
		using (StreamReader firstReader = new StreamReader(inputFileName, true))
		{
			string file1Content = firstReader.ReadToEnd();
			outputWriter.WriteLine(file1Content);
		}
	}
	private static void ConcatenateFiles(IEnumerable<string> inputFiles, string outputFile)
	{
		using (StreamWriter outputWriter = new StreamWriter(outputFile, true, Encoding.ASCII))
		{
			outputWriter.AutoFlush = true;
			foreach (var item in inputFiles)
			{
				CopyFileContent(item, outputWriter);
			}
		}
	}
	static void Main()
	{
		try
		{
			ConcatenateFiles(new List<string> { @"C:\Users\user\Desktop\notes.cs", @"C:\Users\user\Desktop\notes.cs" }, @"C:\Users\user\Desktop\output.cs");
			Console.WriteLine("The new file is created!");
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}
}
