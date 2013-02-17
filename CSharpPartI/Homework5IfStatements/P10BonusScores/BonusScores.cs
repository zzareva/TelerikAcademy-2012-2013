using System;

class BonusScores
{
	static void Main()
	{
		Console.WriteLine("Please enter score between 1 and 9.");
		int score;
		if (!int.TryParse(Console.ReadLine(), out score) || score < 1 || score > 9)
		{
			Console.WriteLine("Error, score is either not a digit or isn't between 1 and 9.");
		}
		int scoreMiltiplicator = (score >= 1 && score <= 3) ? 10 :
			(score >= 4 && score <= 6) ? 100 : 1000;
		if (score >= 1 && score <= 9)
		{
			Console.WriteLine("The final score is {0}", score*scoreMiltiplicator);
		}
	}
}
