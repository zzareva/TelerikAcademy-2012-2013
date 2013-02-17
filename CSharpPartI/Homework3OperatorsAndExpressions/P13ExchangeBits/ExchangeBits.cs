using System;
using System.IO;

class ExchangeBits
{
	static void Main()
	{
		
		Console.WriteLine("Please enter unsigned 32-bit integer number.");
		uint number = getValue();
		Console.WriteLine("The number is: {0}", Convert.ToString(number, 2));
		number = exchangeBits(number, 3, 24);
		number = exchangeBits(number, 4, 25);
		number = exchangeBits(number, 5, 26);
		Console.WriteLine("The number after exchanging bits is: {0}", Convert.ToString(number, 2));

	}

	static uint getValue()
	{
		uint givenNumber;
		while (!uint.TryParse(Console.ReadLine(), out givenNumber))
		{
			Console.WriteLine("Please enter correct unsigned 32-bit integer number.");
		}
		return givenNumber;
	}

	static uint exchangeBits(uint number, byte position1, byte position2)
	{
		byte bitValue1 = (byte)((number >> position1) & 1);
		byte bitValue2 = (byte)((number >> position2) & 1);
		if (bitValue1 != bitValue2)
		{
			switch (bitValue1)
			{
				case 0:
					number = (uint)(~(1 << position2) & number);
					break;
				case 1:
					number = ((uint)(1 << position2) | number);
					break;
			}
			switch (bitValue2)
			{
				case 0:
					number = (uint)(~(1 << position1) & number);
					break;
				case 1:
					number = ((uint)(1 << position1) | number);
					break;
			}
		}
		return number;
	}
}
