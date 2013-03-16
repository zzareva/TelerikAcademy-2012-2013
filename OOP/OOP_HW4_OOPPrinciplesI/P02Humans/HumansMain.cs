using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02Humans
{
	class HumansMain
	{
		static void Main()
		{
			List<Student> students = new List<Student>();
			students.Add(new Student("Pencho", "Ivanov", 2));
			students.Add(new Student("Miroslav", "Vazov", 3));
			students.Add(new Student("Vladimir", "K", 4));
			students.Add(new Student("Silvia", "Ignatova", 2));
			students.Add(new Student("John", "Doe", 5));
			students.Add(new Student("Teodora", "Iordanova", 5));
			students.Add(new Student("Assya", "Ivanova", 12));
			students.Add(new Student("Krasimir", "Kosev", 10));
			students.Add(new Student("Ivaylo", "Teodorov", 3));
			students.Add(new Student("Georgi", "Kaloyanov", 7));

			var sortedStudents = students.OrderBy(x => x.Grade);

			Console.WriteLine("Students sorted list:");
			Console.WriteLine(string.Join("\n", sortedStudents));

			List<Worker> workers = new List<Worker>();
			workers.Add(new Worker("Boris", "Ionov", 200,8));
			workers.Add(new Worker("Bilyana", "Simeonova", 300,9));
			workers.Add(new Worker("Silvia", "Panova", 150,7));
			workers.Add(new Worker("Stella", "Stancheva", 200,6));
			workers.Add(new Worker("Nedyalko", "Iordanov", 100,5));
			workers.Add(new Worker("Gergana", "Gancheva", 100,7));
			workers.Add(new Worker("Kiril", "Kiosev", 400, 12));
			workers.Add(new Worker("Russell", "Hubert", 250, 10));
			workers.Add(new Worker("Richard", "Sean", 176, 7));
			workers.Add(new Worker("Paul", "Stendal", 215, 8 ));

			var sortedWorkers = workers.OrderBy(x => x.MoneyPerHour()).Select(x => x);

			Console.WriteLine("\nWorkers sorted list:");
			Console.WriteLine(string.Join("\n", sortedWorkers));

			List<Human> humans = new List<Human>();
			foreach (var student in students)
			{
				humans.Add((Human)student);
			}
			foreach (var worker in workers)
			{
				humans.Add((Human)worker);
			}

			var sortedHumans = humans.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).Select(x => x);

			Console.WriteLine("\nHumans sorted list:");
			Console.WriteLine(string.Join("\n", sortedHumans));


		}
	}
}
