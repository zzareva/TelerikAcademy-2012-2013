using System;
using System.Globalization;
using System.Threading;
using System.Text;

class ReadModifyPrintDate
{
	private static DateTime GetDate()
	{
		Console.WriteLine("Please enter a date in the format d.M.yyyy H:m:s");
		DateTime dateTime;

		string pattern = "d.M.yyyy H:m:s";
		if (!DateTime.TryParseExact(Console.ReadLine(), pattern, null, DateTimeStyles.None, out dateTime))
			Console.WriteLine("Unable to convert to a date and time.");
		return dateTime;
	}
	static void Main()
	{
		Console.OutputEncoding = Encoding.UTF8;
		Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfoByIetfLanguageTag("bg-BG");
		DateTime date = GetDate();
		date = date.AddHours(6).AddMinutes(30);
		Console.WriteLine("The new date is:");
		Console.WriteLine(date.ToString("d.M.yyyy H:m:s dddd", CultureInfo.CreateSpecificCulture("bg-BG")));
	}
}
