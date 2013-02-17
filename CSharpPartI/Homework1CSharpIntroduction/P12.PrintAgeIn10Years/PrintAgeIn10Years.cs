using System;
class PrintAgeIn10Years
{
	static void Main()
	{
		Console.WriteLine("Please enter your current age.");
		byte currentAge;
		while (!byte.TryParse(Console.ReadLine(), out currentAge) || currentAge < 1 || currentAge > 100)
		{
			Console.WriteLine("Please enter correct value for age");
		}
		Console.WriteLine("Thank you! In 10 years you will be {0} years old.", (currentAge + 10));
	}
}