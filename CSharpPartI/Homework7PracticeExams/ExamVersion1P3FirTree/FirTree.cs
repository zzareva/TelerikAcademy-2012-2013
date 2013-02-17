using System;

class FirTree
{
	static void Main()
	{
		byte n = byte.Parse(Console.ReadLine());
		byte dots = n;dots-=2;
		byte asterics = 1;
		for (byte i = 1; i < n; i++)
		{
			Console.WriteLine("{0}{1}{0}", new string('.', dots), new string('*', asterics));
			asterics+=2;
			dots--;
		}
		Console.WriteLine("{0}{1}{0}", new string('.', n - 2), new string('*', 1));
	}
}
