using System;
using System.Linq;

namespace P02Humans
{
	public class Human
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public Human(string firstName, string lastName)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
		}

	}
}
