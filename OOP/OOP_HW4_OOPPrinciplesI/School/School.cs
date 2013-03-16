using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
	class School
	{
		static void Main()
		{
			Student testStudent1 = Student.CreateUniqueStudent();
			testStudent1.FirstName = "Ivan";
			testStudent1.LastName = "Ivanov";
			testStudent1.Age = 34;

			Discipline english= new Discipline("English", 4, 4);
			Discipline spanish = new Discipline("Spanish", 4, 4);

			Teacher testTeacher = new Teacher("Emiliya","Kostova");
			testTeacher.AddDiscipline(english);
			testTeacher.AddDiscipline(spanish);

			Class secondGrade = new Class();
			secondGrade.ClassName = "Class A";
			Class thirdGrade = new Class();
			thirdGrade.ClassName = "Class B";
			Console.WriteLine(Class.GetAllClassesNames());



		}
	}
}
