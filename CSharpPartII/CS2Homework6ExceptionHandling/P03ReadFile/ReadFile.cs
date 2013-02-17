using System;
using System.IO;
using System.Security;

class ReadFile
{
	private static string GetFileContent(string path)
	{
		string fileContent = null;
		try
		{
			fileContent = File.ReadAllText(path);
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
		return fileContent;
	}

	static void Main()
	{
		Console.WriteLine("Please enter the file address:");
		string path = Console.ReadLine();
		string fileContent = GetFileContent(path);
		Console.WriteLine(fileContent);
	}
}