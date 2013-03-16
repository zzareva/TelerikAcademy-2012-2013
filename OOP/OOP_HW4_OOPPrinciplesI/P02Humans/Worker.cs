using System;
using System.Linq;

namespace P02Humans
{
	class Worker : Human
	{
		private const byte WORK_DAYS_PER_WEEK = 5; // I assume the work week is five days as we don't have any data for this...

		public int WeekSalary { get; set; }

		public byte WorkHoursPerDay { get; set; }

		public Worker(string firstName, string lastName, int salary, byte workingHours)
			: base(firstName, lastName)
		{
			this.WeekSalary = salary;
			this.WorkHoursPerDay = workingHours;
		}
		
		public int MoneyPerHour()
		{
			return WeekSalary / (WORK_DAYS_PER_WEEK * WorkHoursPerDay); 
		}

		public override string ToString()
		{
			return string.Format("{0} {1}, salary: {2}, working hours per day: {3}", FirstName, LastName, WeekSalary, WorkHoursPerDay);
		}

	}
}
