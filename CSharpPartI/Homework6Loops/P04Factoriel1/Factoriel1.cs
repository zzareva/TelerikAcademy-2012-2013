using System;

class Factoriel1
{
	static void Main()
	{
		int numberN = GetNumber(1);
		int numberK = GetNumber(numberN);
		decimal multiplier = 1;
		decimal devider = 1;
		for(int i = 2; i <= numberN; i++)
		{
			multiplier *= i;
		}
		for(int j = 2; j <= numberK; j++)
		{
			devider *= j;
		}
		decimal theResult = multiplier / devider;
		Console.WriteLine("The result is {0}",theResult);
	}

	static int GetNumber(int min)
	{
		int number;
		do
		{
			Console.WriteLine("Please enter a valid integer number greater than {0}.",min);
		}
		while (!int.TryParse(Console.ReadLine(), out number) || number <= min);
		return number;
	}
}

