using System;

class CardDeck
{
	static void Main()
	{
		Console.OutputEncoding = System.Text.Encoding.UTF8;
			string[] rank = { "Ace","Two","Three","Four","Five","Six","Seven","Eight","Nine","Ten","Jack","Queen","King" };

		for(byte k = 0; k < 4; k++)
			for (byte i = 0; i < 13; i++)
			{
				switch (k)
				{
					case 0:
						Console.ForegroundColor = ConsoleColor.Red;
						Console.Write('\u2666');
						break;
					case 1:
						Console.BackgroundColor = ConsoleColor.White;
						Console.ForegroundColor = ConsoleColor.Black;
						Console.Write('\u2663');
						break;
					case 2:
						Console.ForegroundColor = ConsoleColor.Red;
						Console.Write('\u2665');
						break;
					default:
						Console.BackgroundColor = ConsoleColor.White;
						Console.ForegroundColor = ConsoleColor.Black;
						Console.Write('\u2660');
						break;
				}
				Console.Write(" ");
				Console.BackgroundColor = ConsoleColor.Black;
				Console.ForegroundColor = ConsoleColor.Gray;
				Console.Write(" {0} \n", rank[i]);
			}
	}
}
