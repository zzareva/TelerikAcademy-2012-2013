using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

class CalculateDateDistance
{
	private static DateTime GetDate()
	{
		Console.WriteLine("Please enter a date in the format dd.mm.yyyy.");
		string format = "d";
		CultureInfo provider = new CultureInfo("de-DE");
		DateTime dateTime = DateTime.ParseExact(Console.ReadLine(), format, provider);
		return dateTime;
	}
	static void Main()
	{
		DateTime date1 = GetDate();
		DateTime date2 = GetDate();
		Console.WriteLine("Distance: {0} days",date2.Subtract(date1).ToString("dd"));
	}
}