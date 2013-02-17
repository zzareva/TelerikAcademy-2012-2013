using System;


class SumSequence
{
	static void Main()
	{
		float sum = 0f;
		sbyte k = 1;
		int i = 1;

		do
		{
			sum += (k * (1 / (float)i));
			k *= -1;
			i++;
		}
		while ((1 / (float)i) > 0.00001);

		int tempForRoundingTheDecimalPoints = (int)(sum * 1000);
		sum = (float)tempForRoundingTheDecimalPoints / 1000;
		Console.WriteLine("The sum is {0}", sum);
	}
}
