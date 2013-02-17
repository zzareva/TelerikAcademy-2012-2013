using System;

class ReadPrintCompanyInformation
{
	static void Main()
	{
		/*A company has name, address, phone number, fax number, web site and manager. 
		 * The manager has first name, last name, age and a phone number. 
		 * Write a program that reads the information about a company and
		 * its manager and prints them on the console.*/
		Console.WriteLine("Please enter company name.");
		string companyName = Console.ReadLine();
		Console.WriteLine("Please enter company address.");
		string companyAddress = Console.ReadLine();
		Console.WriteLine("Please enter company phone number.");
		string companyPhone = Console.ReadLine();
		Console.WriteLine("Please enter company fax number.");
		string companyFax = Console.ReadLine();
		Console.WriteLine("Please enter company web site.");
		string companySite = Console.ReadLine();
		Console.WriteLine("Please enter company manager's first name.");
		string managerFirstName = Console.ReadLine();
		Console.WriteLine("Please enter company manager's last name.");
		string managerLastName = Console.ReadLine();
		Console.WriteLine("Please enter company manager's age.");
		byte managerAge = getAge();
		Console.WriteLine("Please enter manager's phone number.");
		string managerPhone = Console.ReadLine();

		Console.WriteLine("Company name: {0,5}", companyName);
		Console.WriteLine("Company address: {0,5}", companyAddress);
		Console.WriteLine("Company fax: {0,5}", companyFax);
		Console.WriteLine("Company site: {0,5}", companySite);
		Console.WriteLine("Company manager: {0,5} {1}", managerFirstName, managerLastName);
		Console.WriteLine("Manager's age: {0,5}", managerAge);
		Console.WriteLine("Manager's phone: {0,5}", managerPhone);



	}
	static byte getAge()
	{
		byte age;
		while (!byte.TryParse(Console.ReadLine(), out age) || age > 110)
		{
			Console.WriteLine("Please enter correct age.");
		}
		return age;
	}
}
