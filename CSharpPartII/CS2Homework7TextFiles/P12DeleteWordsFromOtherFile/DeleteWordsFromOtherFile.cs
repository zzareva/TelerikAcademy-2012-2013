using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;

class DeleteWordsFromOtherFile
{
		
	private static List<string> GetForbiddenList(string fileToTakeWordsFrom)
	{
		List<string> words = new List<string>();
		try
		{
			using(StreamReader sr = new StreamReader(fileToTakeWordsFrom))
 			{
				
				string line = null;
				line = sr.ReadLine();
				while (line != null)
				{
					string pattern = "[0-9a-zA-Z_]+";
					Regex regex = new Regex(pattern);
					foreach (var match in regex.Matches(line))
					{
						words.Add(match.ToString().ToLower());
					}
					line = sr.ReadLine();
				}
			}
		}
		catch (ArgumentNullException argNullEx)
		{
			Console.WriteLine(argNullEx.Message); //Specific message can be set here
		}
		catch (ArgumentException argumentEx)
		{
			Console.WriteLine(argumentEx.Message);//Specific message can be set here
		}
		catch (PathTooLongException pathTooLongEx)
		{
			Console.WriteLine(pathTooLongEx.Message);//Specific message can be set here
		}
		catch (DirectoryNotFoundException dirNotFoundEx)
		{
			Console.WriteLine(dirNotFoundEx.Message);//Specific message can be set here
		}
		catch (FileNotFoundException fileNotFoundEx)
		{
			Console.WriteLine(fileNotFoundEx.Message);//Specific message can be set here
		}
		catch (IOException ioEx)
		{
			Console.WriteLine(ioEx.Message);//Specific message can be set here
		}
		catch (UnauthorizedAccessException unauthorizedAccessEx)
		{
			Console.WriteLine(unauthorizedAccessEx.Message);//Specific message can be set here
		}
		catch (NotSupportedException notSupportedEx)
		{
			Console.WriteLine(notSupportedEx.Message);//Specific message can be set here
		}
		catch (SecurityException securityEx)
		{
			Console.WriteLine(securityEx.Message);//Specific message can be set here
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);//Specific message can be set here
		}
			return words;
	}
	private static void DeleteWordsFromFile(List<string> words, string file)
	{
		string fileContent = "";
		try
		{
			using (StreamReader reader = new StreamReader(file))
			{
				fileContent = reader.ReadToEnd();
				string pattern = "[0-9a-zA-Z_]+";
				Regex regex = new Regex(pattern);
				foreach (var match in regex.Matches(fileContent))
				{
					string currentWord = match.ToString().ToLower();
					if (words.Contains(currentWord))
					{
						int startIndex = fileContent.IndexOf(currentWord);
						if (startIndex > 0)
							fileContent = fileContent.Substring(0, startIndex - 1) + fileContent.Substring(startIndex + currentWord.Length);
					}
				}
			}
		}
		catch (ArgumentNullException argNullEx)
		{
			Console.WriteLine(argNullEx.Message); //Specific message can be set here
		}
		catch (ArgumentException argumentEx)
		{
			Console.WriteLine(argumentEx.Message);//Specific message can be set here
		}
		catch (PathTooLongException pathTooLongEx)
		{
			Console.WriteLine(pathTooLongEx.Message);//Specific message can be set here
		}
		catch (DirectoryNotFoundException dirNotFoundEx)
		{
			Console.WriteLine(dirNotFoundEx.Message);//Specific message can be set here
		}
		catch (FileNotFoundException fileNotFoundEx)
		{
			Console.WriteLine(fileNotFoundEx.Message);//Specific message can be set here
		}
		catch (IOException ioEx)
		{
			Console.WriteLine(ioEx.Message);//Specific message can be set here
		}
		catch (UnauthorizedAccessException unauthorizedAccessEx)
		{
			Console.WriteLine(unauthorizedAccessEx.Message);//Specific message can be set here
		}
		catch (NotSupportedException notSupportedEx)
		{
			Console.WriteLine(notSupportedEx.Message);//Specific message can be set here
		}
		catch (SecurityException securityEx)
		{
			Console.WriteLine(securityEx.Message);//Specific message can be set here
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);//Specific message can be set here
		}
		try
		{
			using (StreamWriter writer = new StreamWriter(file, false))
			{
				writer.WriteLine(fileContent);
			}
		}
		catch (ArgumentNullException argNullEx)
		{
			Console.WriteLine(argNullEx.Message);//Specific message can be set here
		}
		catch (ArgumentException argumentEx)
		{
			Console.WriteLine(argumentEx.Message);//Specific message can be set here
		}
		catch (PathTooLongException pathTooLongEx)
		{
			Console.WriteLine(pathTooLongEx.Message);//...
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
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}
	static void Main()
	{
		string fileToTakeWordsFrom = "wordsList.txt";
		string fileToDeleteTheWordsIn = "input.txt";
		List<string> wordsToDelete = new List<string>();
		wordsToDelete = GetForbiddenList(fileToTakeWordsFrom);
		DeleteWordsFromFile(wordsToDelete, fileToDeleteTheWordsIn);
	}
}