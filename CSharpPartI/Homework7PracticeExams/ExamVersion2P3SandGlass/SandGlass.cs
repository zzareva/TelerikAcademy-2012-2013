using System;

class SandGlass
{
	static void Main()
	{
		sbyte n = sbyte.Parse(Console.ReadLine());
		sbyte astericsNum = n;
		for (sbyte i = 0; i < n; i++)
		{
			string asterics = new string('*', astericsNum);
			string dots = new string('.', (n - astericsNum) / 2);
			Console.WriteLine("{0}{1}{0}",dots,asterics);
			if (i < n/2)
				astericsNum -= 2;
			else
				astericsNum += 2;
		}
	}
}
