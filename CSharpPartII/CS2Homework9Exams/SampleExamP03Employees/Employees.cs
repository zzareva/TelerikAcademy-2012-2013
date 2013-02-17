using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SampleExamP03Employees
{
	class EmployeeData
	{
		public string firstName;
		public string lastName;
		public string position;
		public int value;
	}

	class Employees
	{
		static void Main()
		{

			//Console.SetIn(new StreamReader(@"C:\Users\xx\Desktop\input.txt",true));

			Dictionary<string, int> codeList = new Dictionary<string, int>();
			int totalPostions = int.Parse(Console.ReadLine());
			for (int i = 0; i < totalPostions; i++)
			{
				string[] inputCodes = Console.ReadLine().Split('-');
				string currentPosition = inputCodes[0].Trim();
				int currentRating = int.Parse(inputCodes[1].Trim());
				codeList.Add(currentPosition, currentRating);
			}
			int totalEmployees = int.Parse(Console.ReadLine());
			List<EmployeeData> employees = new List<EmployeeData>();
			for (int i = 0; i < totalEmployees; i++)
			{
				EmployeeData currentEmployee = new EmployeeData();
				string[] inputEmployees = Console.ReadLine().Split('-');
				string[] name = inputEmployees[0].Trim().Split();
				string pos = inputEmployees[1].Trim();
				currentEmployee.firstName = name[0];
				currentEmployee.lastName = name[1];
				currentEmployee.position = pos;
				currentEmployee.value = codeList[pos];
				employees.Add(currentEmployee);
			}
			employees = employees.OrderByDescending(x => x.value).ThenBy(x => x.lastName).ThenBy(x => x.firstName).ToList();
			foreach (var item in employees)
			{
				Console.WriteLine("{0} {1}",item.firstName, item.lastName);
			}
		}
	}
}
