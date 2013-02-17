using System;

class NumberDevidedBy5Between2Numbers
{
	static void Main()
	{
		Console.WriteLine("Please enter number 1.");
		uint positiveNumber1 = getNumber();
		Console.WriteLine("Please enter number 2.");
		uint positiveNumber2 = getNumber();
		uint currentValue = positiveNumber1;
		uint endValue = positiveNumber2;
		uint result = 0;

		if (positiveNumber1 > positiveNumber2)
		{
			currentValue = positiveNumber2;
			endValue = positiveNumber1;
		}
		while(currentValue<=endValue)
		{
			if (currentValue % 5 == 0)
			{
				result++;
				currentValue+=5;
			}
			else
			{
				currentValue++;
			}
		}
		Console.WriteLine("The count of the numbers devided by 5 is: {0}",result);
	}
	static uint getNumber()
	{
		uint number;
		while(!uint.TryParse(Console.ReadLine(),out number))
		{
			Console.WriteLine("Please enter a positive number.");
		}
		return number;
	}
}
