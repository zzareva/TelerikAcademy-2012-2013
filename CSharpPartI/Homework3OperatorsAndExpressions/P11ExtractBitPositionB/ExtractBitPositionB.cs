using System;

class ExtractBitPositionB
{
	static void Main()
	{
		Console.WriteLine("Please enter number I.");
		int givenNumber = getNumber();
		Console.WriteLine("Please enter position B.");
		int p = getNumber();
		byte positionPValue = (byte)((givenNumber >> p) & 1);
		Console.WriteLine("Position B is:{0}", positionPValue);
	}
	static int getNumber()
	{
		int number;
		while (!int.TryParse(Console.ReadLine(), out number))
		{
			Console.WriteLine("Please enter correct integer value.");
		}
		return number;
	}
}