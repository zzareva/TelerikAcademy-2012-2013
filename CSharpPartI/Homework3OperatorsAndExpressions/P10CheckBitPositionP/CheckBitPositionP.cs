using System;

class CheckBitPositionP
{
	static void Main()
	{
		bool hasValueOne = false;
		Console.WriteLine("Please enter number.");
		int givenNumber = getNumber();
		Console.WriteLine("Please enter position P.");
		int p = getNumber();
		int positionPValue = (givenNumber >> p) & 1;
		hasValueOne = positionPValue == 1;
		Console.WriteLine("{0} (binary - {1}) has value 1 at bit position {2}: {3}", givenNumber, Convert.ToString(givenNumber, 2), p, hasValueOne);
	}
	static int getNumber()
	{
		int number;
		while(!int.TryParse(Console.ReadLine(), out number))
		{
			Console.WriteLine("Please enter correct integer value.");
		}
		return number;
	}
}
