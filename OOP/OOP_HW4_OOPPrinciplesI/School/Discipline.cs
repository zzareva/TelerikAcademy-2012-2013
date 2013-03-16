using System;
using System.Collections.Generic;
using System.Linq;

namespace School
{
	public class Discipline : ICommentable
	{
		public string Name { get; set; }
		public int LectureNumber { get; set; }
		public int ExercisesNumber { get; set; }
		public List<string> Comments { get; private set; }

		public Discipline(string name, int numberOfLectures, int numberOfExcercises)
		{
			this.Name = name;
			this.LectureNumber = numberOfLectures;
			this.ExercisesNumber = numberOfExcercises;
		}

		public void AddComment(string comment)
		{
			Comments.Add(comment);
		}
	}
}
