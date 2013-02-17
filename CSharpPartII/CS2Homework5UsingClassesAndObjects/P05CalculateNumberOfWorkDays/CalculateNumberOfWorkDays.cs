using System;
using System.Collections.Generic;

class CalculateNumberOfWorkDays
{
	private static int CountWorkDays(DateTime date, List<DateTime> publicHolidays, List<DateTime> workSaturdays)
	{
		DateTime today = DateTime.Today.Date;
		int workDays = 0;

		if (date.Date > today.Date)
		{
			while (today.Date <= date.Date)
			{
				if ( workSaturdays.Contains(today.Date) || (today.DayOfWeek != DayOfWeek.Saturday && today.DayOfWeek != DayOfWeek.Sunday))
					workDays++;
				today = today.AddDays(1);
			}
		}
		else if (date.Date < today.Date)
		{
			DateTime dateVariable = new DateTime(date.Year, date.Month, date.Day);
			while (today.Date >= dateVariable.Date)
			{
				if (workSaturdays.Contains(dateVariable.Date) || (dateVariable.DayOfWeek != DayOfWeek.Saturday && dateVariable.DayOfWeek != DayOfWeek.Sunday))
					workDays++;
				dateVariable = dateVariable.AddDays(1);
			}
		}

		foreach (var holiday in publicHolidays)
		{
			if ((holiday.Date >= DateTime.Now.Date && holiday.Date <= date.Date) ||
				(holiday.Date <= DateTime.Now.Date && holiday.Date >= date.Date) &&
				holiday.DayOfWeek != DayOfWeek.Saturday && holiday.DayOfWeek != DayOfWeek.Sunday)
			{
				workDays--;
			}
		}

		return workDays;
	}

	private static void GetOfficialBgHolidays2013(List<DateTime> publicHolidays)
	{
		publicHolidays.Add(new DateTime(2013, 3, 1));
		publicHolidays.Add(new DateTime(2013, 5, 1));
		publicHolidays.Add(new DateTime(2013, 5, 2));
		publicHolidays.Add(new DateTime(2013, 5, 3));
		publicHolidays.Add(new DateTime(2013, 5, 4));
		publicHolidays.Add(new DateTime(2013, 5, 5));
		publicHolidays.Add(new DateTime(2013, 5, 6));
		publicHolidays.Add(new DateTime(2013, 5, 24));
		publicHolidays.Add(new DateTime(2013, 9, 6));
		publicHolidays.Add(new DateTime(2013, 9, 22));
		publicHolidays.Add(new DateTime(2013, 12, 24));
		publicHolidays.Add(new DateTime(2013, 12, 25));
		publicHolidays.Add(new DateTime(2013, 12, 26));
		publicHolidays.Add(new DateTime(2013, 12, 31));
	}
	private static void GetWorkSaturdays(List<DateTime> workSaturdays)
	{
		workSaturdays.Add(new DateTime(2013, 12, 14));
	}

	static void Main()
	{
		DateTime date = new DateTime(2010, 12, 28);

		List<DateTime> publicHolidays = new List<DateTime>();
		GetOfficialBgHolidays2013(publicHolidays);
		List<DateTime> workSaturdays = new List<DateTime>();
		GetWorkSaturdays(workSaturdays);

		int workDays = CountWorkDays(date, publicHolidays, workSaturdays);
		Console.WriteLine("There are {0} work days from now to {1:MM/dd/yy}", workDays, date.Date);
	}
}