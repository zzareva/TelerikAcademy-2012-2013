using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class PrintNumber
{
	static void Main()
	{
		Console.WriteLine("Please enter the number:");
		int number = 0;
		try
		{
			number = int.Parse(Console.ReadLine());
		}
		catch (Exception)
		{
			Console.WriteLine("Invalid number.");
		}
		Console.WriteLine("Output:");
		Console.WriteLine("{0,15}", number);
		Console.WriteLine("{0,15:X}", number);
		Console.WriteLine("{0,15:p}", number);
		Console.WriteLine("{0,15:E}", number);

	}
}