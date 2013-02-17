using System;
using System.Globalization;
using System.Threading;

class MathExpression
{
	static void Main()
	{
		Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
		decimal numN = decimal.Parse(Console.ReadLine());
		decimal numM = decimal.Parse(Console.ReadLine());
		decimal numP = decimal.Parse(Console.ReadLine());
		decimal theResult;
		decimal part1 = (numN*numN) + (1/(numM*numP)) + 1337;
		decimal part2 = numN - (128.523123123m*numP);
		decimal part3 = (decimal)Math.Sin((double)((int)numM % 180));
		theResult = (part1/part2) + part3;
		Console.WriteLine("{0:F6}",theResult);
	}
}
