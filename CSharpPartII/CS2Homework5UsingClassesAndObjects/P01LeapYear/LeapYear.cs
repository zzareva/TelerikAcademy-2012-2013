using System;

class LeapYear
{
	static int GetYear()
	{
		Console.WriteLine("Please enter the year (0-10000)");
		int year = 0;
		while(!int.TryParse(Console.ReadLine(), out year) || year < 0 || year > 10000)
		{
			Console.WriteLine("Please enter a valid year.");
		}
		return year;
	}

	static void Main()
	{
		int year = GetYear();
		Console.WriteLine("Year {0} is {1}a leap year", year, DateTime.IsLeapYear(year) ? string.Empty : "not ");
	}
}
