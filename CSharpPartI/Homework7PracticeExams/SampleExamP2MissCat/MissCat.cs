using System;

class MissCat
{
	static void Main()
	{
		int[] cats = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
		int numberN = int.Parse(Console.ReadLine());
		byte theWinner = 0;
		int winnerCount = 0;
		for (int i = 0; i < numberN; i++)
			cats[int.Parse(Console.ReadLine())]++;

		for (byte i = 1; i < 11; i++)
		{
			int catVote = cats[i];
			if (catVote > winnerCount || (catVote == winnerCount && theWinner > i))
			{
				theWinner = i;
				winnerCount = catVote;
			}
		}

		Console.WriteLine(theWinner);
	}
}
