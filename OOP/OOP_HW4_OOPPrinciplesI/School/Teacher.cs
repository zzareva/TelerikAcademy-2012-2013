using System;
using System.Collections.Generic;
using System.Linq;

namespace School
{
	public class Teacher : Human
	{
		public List<Discipline> DisciplinesSet { get; set; }

		public Teacher(string firstName, string lastName)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			DisciplinesSet = new List<Discipline>();
		}

		public void AddDiscipline(Discipline discipline)
		{
			DisciplinesSet.Add(discipline);
		}

		public void RemoveDiscipline(Discipline discipline)
		{
			DisciplinesSet.Remove(discipline);
		}

	}
}
