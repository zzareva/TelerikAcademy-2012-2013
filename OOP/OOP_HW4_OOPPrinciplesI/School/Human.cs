using System;
using System.Collections.Generic;
using System.Linq;

namespace School
{
	public class Human : ICommentable
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
		public List<string> Comments { get; private set; }

		public Human()
		{
		}

		public Human(string firstName, string lastName, int age)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Age = age;
		}

		public void AddComment(string comment)
		{
			Comments.Add(comment);
		}
	}
}
