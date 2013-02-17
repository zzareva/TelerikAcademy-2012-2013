using System;

class AstrologicalDigits
{
	static void Main()
	{
		string n = Console.ReadLine();
		int sum = 0;
		for (int i = 0; i < n.Length; i++)
		{
			sum += char.IsDigit(n[i]) ? (n[i] - '0') : 0;
		}
		while (sum > 9)
		{
			sum = sum / 10 + sum % 10;
		}
		Console.WriteLine(sum);
	}
}
