using System;
using System.Linq;

namespace School
{
	public class Student : Human
	{
		private static int idsStart = 10000;
		public int StudentID { get; set; }

		public Student()
		{
		}

		public Student(string firstName, string lastName)
		{
			this.StudentID = GetUniqueID();
			this.FirstName = firstName;
			this.LastName = lastName;
		}

		public Student(string firstName, string lastName, int age)
		{
			this.StudentID = GetUniqueID();
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Age = age;
		}

		public static Student CreateUniqueStudent()
		{
			return new Student() { StudentID = GetUniqueID() };
		}
		private static int GetUniqueID()
		{
			return idsStart++;
		}
	}
}
