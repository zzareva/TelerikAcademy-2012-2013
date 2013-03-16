using System;
using System.Collections.Generic;
using System.Linq;

namespace P03FilterStudens
{
	class StudentUITests
	{
		static void Main()
		{
			List<Student> testStudents = new List<Student>()
			{
				new Student("Ivan", "Ivanov", 23),
				new Student("Pencho", "Georgiev", 18),
				new Student("Todor", "Krastev", 30),
				new Student("Iva", "Vesselinova", 28),
				new Student("John", "Steward", 59),
				new Student("Sven", "Greenfield", 23)
			};

			//P03 Write a method that from a given array of students finds all students
			//whose first name is before its last name alphabetically. Use LINQ query operators.
			var studentsByFirstName = StudentMethods.GetStudentsWithFirstBeforeLastName(testStudents);
			Console.WriteLine("\nP03 The students with first name before the last name are:");
			StudentMethods.PrintStudentsCollection(studentsByFirstName);

			//P04 Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
			var students18To24 = StudentMethods.GetStudents18To24(testStudents);
			Console.WriteLine("\nP04 The names of the students between 18 and 24 are:");
			foreach (var st in students18To24)
			{
				Console.WriteLine(st);
			}

			//P05 Using the extension methods OrderBy() and ThenBy() with lambda expressions
			//sort the students by first name and last name in descending order. Rewrite the same with LINQ.

			Console.WriteLine("\nP05.1 Sorted list with Lambda expression:");
			var sortedListLambda = StudentMethods.OrderStudentsLambda(testStudents);
			StudentMethods.PrintStudentsCollection(sortedListLambda);
			Console.WriteLine("\nP05.2 Sorted list with Linq query:");
			var sortedListLinq = StudentMethods.OrderStudentsLinq(testStudents);
			StudentMethods.PrintStudentsCollection(sortedListLinq);

		}
	}
}
