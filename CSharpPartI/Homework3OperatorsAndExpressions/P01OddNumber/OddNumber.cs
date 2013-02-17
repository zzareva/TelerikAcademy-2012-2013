using System;

class OddNumber
{
	static void Main()
	{
		Console.WriteLine("Please enter an integer number.");
		int integerVariable = 0;
		while(!int.TryParse(Console.ReadLine(),out integerVariable))
		{
			Console.WriteLine("Please enter integer value.");
		}
		Console.WriteLine(integerVariable % 2 == 0? "It's even" : "It's odd" );
	}
}
