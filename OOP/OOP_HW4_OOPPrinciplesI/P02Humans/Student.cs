using System;
using System.Linq;

namespace P02Humans
{
	class Student : Human
	{
		public byte Grade { get; set; }

		public Student(string firstName, string lastName, byte grade) : base(firstName, lastName)
		{
			this.Grade = grade;
		}

		public override string ToString()
		{
			return string.Format("{0} {1}, grade: {2}",FirstName, LastName, Grade);
		}
	}
}
