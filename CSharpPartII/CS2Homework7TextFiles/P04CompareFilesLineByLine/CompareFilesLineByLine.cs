using System;
using System.Collections.Generic;
using System.IO;

class CompareFilesLineByLine
{
	private static int[] CompareFiles(string file1, string file2)
	{
		using (StreamReader reader1 = new StreamReader(file1, true))
		{
			using (StreamReader reader2 = new StreamReader(file2, true))
			{
				int[] lines = { 0, 0 };
				string lineContent1 = reader1.ReadLine();
				string lineContent2 = reader2.ReadLine();
				while(lineContent1!= null && lineContent2!=null)
				{
					if(lineContent1.Equals(lineContent2))
						lines[0]++;
					else
						lines[1]++;
					lineContent1 = reader1.ReadLine();
					lineContent2 = reader2.ReadLine();
				}
				return lines;
			}
		}
	}
	static void Main()
	{
		try
		{
			int[] correctWrongLines = CompareFiles(@"C:\Users\user\Desktop\notes.cs" , @"C:\Users\user\Desktop\output.txt" );
			Console.WriteLine("The new matching lines are {0} and the diffent lines are {1}",correctWrongLines[0], correctWrongLines[1]);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}
}
