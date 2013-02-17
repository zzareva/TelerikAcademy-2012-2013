using System;

class Fibonacci
{
	private static int GetNumber()
	{
		int number;
		do
		{
			Console.WriteLine("Please enter an integer number");
		}
		while(!int.TryParse(Console.ReadLine(),out number));
		return number;
	}
	static void Main()
	{
		int numberN = GetNumber();
		int previousMember1 = 0;
		int previousMember2 = 1;
		int newMember;
		long sum = 1L;
		for (int i = 3; i <= numberN; i++)
		{
			newMember = previousMember1 + previousMember2;
			sum += newMember;
			previousMember1 = previousMember2;
			previousMember2 = newMember;
		}
		Console.WriteLine("Sum: {0}", sum);
	}
}
