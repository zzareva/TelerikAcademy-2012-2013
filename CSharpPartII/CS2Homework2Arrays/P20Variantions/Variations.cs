using System;

class Variations
{
	static int numberN;
	static int numberK;
	static int[] variations;
	
	static void Main()
	{
		numberN = GetNumber();
		numberK = GetNumber(numberN);
		variations = new int[numberK];
		GetVariations();
	}

	static int GetNumber(int maximum = int.MaxValue)
	{
		int number;
		do
		{
			Console.WriteLine("Please enter an integer number <= {0}", maximum);
		}
		while (!int.TryParse(Console.ReadLine(), out number) || number > maximum);
		return number;
	}
	static void PrintLoops()
	{
		Console.WriteLine("{0}",String.Join(",",variations));
	}
	static void SetToOne(int[] variations, int index)
	{
		for (int i = 0; i <= index; i++)
		{
			variations[i] = 1;
		}
	}
	static void GetVariations()
	{
		SetToOne(variations, numberK - 1);
		int count = 1;
		while (variations[numberK - 1] <= numberN)
		{
			for (int i = 1; i <= numberN; i++)
			{
				variations[0] = i;
				PrintLoops();
			}
			variations[1]++;
			for (int i = 0; i < numberK - 1; i++)
			{
				if (variations[i] == numberN + 1)
				{
					variations[i + 1]++;
					SetToOne(variations, i);
				}
			}
			count++;
		}
	}
}
