using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Security;

class FileDownload
{
	static void Main(string[] args)
	{
		try
		{
			var request = FileWebRequest.Create("http://www.devbg.org/img/Logo-BASD.jpg");
			using (var response = request.GetResponse())
			{
				using (var fileStream = response.GetResponseStream())
				{
					using (var file = File.OpenWrite("logo.jpg"))
					{
						int byteData;
						while ((byteData = fileStream.ReadByte()) != -1)
							file.WriteByte((byte)byteData);
					}
				}
			}
		}
		catch (NotSupportedException noSupport)
		{
			Console.WriteLine(noSupport.Message);
		}
		catch (UriFormatException uriFormat)
		{
			Console.WriteLine(uriFormat.Message);
		}
		catch (SecurityException securityEx)
		{
			Console.WriteLine(securityEx.Message);
		}
		catch (ArgumentNullException argNull)
		{
			Console.WriteLine(argNull.Message);
		}
		catch (UnauthorizedAccessException unauthEx)
		{
			Console.WriteLine(unauthEx.Message);
		}
		catch (PathTooLongException pathEx)
		{
			Console.WriteLine(pathEx.Message);
		}
		catch (DirectoryNotFoundException dirEx)
		{
			Console.WriteLine(dirEx.Message);
		}
		catch (FileNotFoundException fileEx)
		{
			Console.WriteLine(fileEx.Message);
		}
		catch (IOException ioEx)
		{
			Console.WriteLine(ioEx.Message);
		}
		catch (ArgumentException argEx)
		{
			Console.WriteLine(argEx.Message);
		}
		catch (Exception)
		{
			Console.WriteLine("Downloading the file was unsuccessful. Please contact your system administator.");
		}
	}
}