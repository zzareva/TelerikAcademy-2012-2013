using System;

class PrintDigitsName
{
	static void Main()
	{
		Console.WriteLine("Please enter a digit");
		char digitNumber = GetDigit();
		Console.Write("And the digit you\'ve entered is: ");
		switch (digitNumber)
		{
			case '0':
				Console.WriteLine("one");
				break;
			case '1':
				Console.WriteLine("one");
				break;
			case '2':
				Console.WriteLine("two");
				break;
			case '3':
				Console.WriteLine("three");
				break;
			case '4':
				Console.WriteLine("four");
				break;
			case '5':
				Console.WriteLine("five");
				break;
			case '6':
				Console.WriteLine("six");
				break;
			case '7':
				Console.WriteLine("seven");
				break;
			case '8':
				Console.WriteLine("eight");
				break;
			case '9':
				Console.WriteLine("nine");
				break;
			default:
				Console.WriteLine("Error!");
				break;
		}
	}
	static char GetDigit()
	{
		char digit;
		while (!char.TryParse(Console.ReadLine(), out digit) || !Char.IsNumber(digit))
		{
			Console.WriteLine("Please enter a digit.");
		}
		return digit;
	}
}
