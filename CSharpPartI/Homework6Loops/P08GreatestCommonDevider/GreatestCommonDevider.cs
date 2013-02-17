using System;

class GreatestCommonDevider
{
	static void Main()
	{
		int number1 = GetNumber();
		int number2 = GetNumber();
		Console.WriteLine("The GCD is {0}", GetGreatestCommonDevider(number1, number2));
	}

	static int GetNumber()
	{
		int number;
		do
		{
			Console.WriteLine("Please enter an integer number");
		}
		while(!int.TryParse(Console.ReadLine(),out number));
		return number;
	}
	static int GetGreatestCommonDevider(int a, int b)
	{
		while (a != 0 && b != 0)
		{
			if (a > b)
			{
				a %= b;
			}
			else
			{
				b %= a;
			}
		}
		if (a == 0)
		{
			return b;
		}
		else
		{
			return a;
		}
	}
}
