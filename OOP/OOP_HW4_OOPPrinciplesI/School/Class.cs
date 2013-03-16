using System;
using System.Collections.Generic;
using System.Linq;

namespace School
{
	public class Class : ICommentable
	{
		private static List<string> classesNames = new List<string>();
		
		private string className;
		public List<Teacher> TeachersList { get; set; }
		public List<string> Comments { get; private set; }

		public string ClassName
		{
			get
			{
				return this.className;
			}
			set
			{
				if (classesNames.Contains(value))
					throw new ArgumentException("Class names should be unique");
				else
				{
					classesNames.Add(value);
					this.className = value;
				}
			}
		}

		public void AddTeacher(Teacher teacher)
		{
			TeachersList.Add(teacher);
		}

		public void DeleteTeacher(Teacher teacher)
		{
			TeachersList.Remove(teacher);
		}

		public void AddComment(string comment)
		{
			Comments.Add(comment);
		}

		public static string GetAllClassesNames()
		{
			return string.Join(", ", classesNames);
		}

	}
}
