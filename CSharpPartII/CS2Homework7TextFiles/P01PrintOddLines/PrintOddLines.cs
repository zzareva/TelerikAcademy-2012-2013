using System;
using System.IO;
using System.Security;
using System.Text;

class PrintOddLines
{
	static void Main()
	{
		try
		{
			using (StreamReader sr = new StreamReader(@"C:\Users\nameHere\Desktop\notes.cs", true))
			{
				string oddLine = sr.ReadLine();
				int lineIndex = 0;
				while (oddLine != null)
				{
					if(lineIndex % 2 != 0)
					{
					Console.WriteLine(oddLine);
					}
					oddLine = sr.ReadLine();
					lineIndex++;
				}
			}
		}
		catch (ArgumentNullException argNullEx)
		{
			Console.WriteLine(argNullEx.Message);
		}
		catch (ArgumentException argumentEx)
		{
			Console.WriteLine(argumentEx.Message);
		}
		catch (PathTooLongException pathTooLongEx)
		{
			Console.WriteLine(pathTooLongEx.Message);
		}
		catch (DirectoryNotFoundException dirNotFoundEx)
		{
			Console.WriteLine(dirNotFoundEx.Message);
		}
		catch (FileNotFoundException fileNotFoundEx)
		{
			Console.WriteLine(fileNotFoundEx.Message);
		}
		catch (IOException ioEx)
		{
			Console.WriteLine(ioEx.Message);
		}
		catch (UnauthorizedAccessException unauthorizedAccessEx)
		{
			Console.WriteLine(unauthorizedAccessEx.Message);
		}
		catch (NotSupportedException notSupportedEx)
		{
			Console.WriteLine(notSupportedEx.Message);
		}
		catch (SecurityException securityEx)
		{
			Console.WriteLine(securityEx.Message);
		}
		catch (Exception)
		{
			Console.WriteLine("Sorry, something went wrong! Please try again later.");
		}
	}
}
