using System;
using System.Linq;

namespace P03FilterStudens
{
	public class Student
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public byte Age { get; set; }

		public Student(string firstName, string lastName, byte age)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Age = age;
		}

		public override string ToString()
		{
			return string.Format("{0} {1} {2}",this.FirstName, this.LastName, this.Age);
		}
	}
}
