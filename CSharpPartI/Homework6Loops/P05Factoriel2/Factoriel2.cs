using System;

class Factoriel2
{
	static void Main()
	{
		int numberN = GetNumber(1);
		int numberK = GetNumber(numberN);
		decimal multiplier1 = 1;
		decimal multiplier2 = 1;
		decimal devider = 1;
		for (int i = 2; i <= numberN; i++)
		{
			multiplier1 *= i;
		}
		for (int j = 2; j <= numberK; j++)
		{
			multiplier2 *= j;
		}
		for (int k = 2; k <= (numberK - numberN); k++)
		{
			devider *= k;
		}
		decimal theResult = multiplier1 * multiplier2 / devider;
		Console.WriteLine("The result is {0}", theResult);
	}

	static int GetNumber(int min)
	{
		int number;
		do
		{
			Console.WriteLine("Please enter a valid integer number greater than {0}.", min);
		}
		while (!int.TryParse(Console.ReadLine(), out number) || number <= min);
		return number;
	}
}
