using System;
using System.Collections.Generic;
using System.Linq;

namespace P03FilterStudens
{
	public static class StudentMethods
	{

		public static IEnumerable<Student> GetStudentsWithFirstBeforeLastName(IEnumerable<Student> students)
		{
			IEnumerable<Student> filterResult = from s in students
								where s.FirstName.CompareTo(s.LastName) < 0
								select s;
			return filterResult;
		}

		public static List<string> GetStudents18To24(IEnumerable<Student> students)
		{
			var tempResult = from s in students
								where s.Age >= 18 && s.Age <= 24 
								select  new { firstN = s.FirstName, lastN = s.LastName };
			List<string> filterResult = new List<string>();
			foreach (var item in tempResult)
			{
				filterResult.Add(item.firstN + " " + item.lastN);
			}
			return filterResult;
		}

		public static IEnumerable<Student> OrderStudentsLambda(IEnumerable<Student> students)
		{
			IEnumerable<Student> filterResult = students.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);
			return filterResult;
		}
		public static IEnumerable<Student> OrderStudentsLinq(IEnumerable<Student> students)
		{
			IEnumerable<Student> filterResult = from s in students
												orderby s.FirstName descending, s.LastName descending
												select s;
			return filterResult;
		}

		public static void PrintStudentsCollection(IEnumerable<Student> students)
		{
			foreach (var item in students)
			{
				Console.WriteLine(item);
			}
		}

	}
}
