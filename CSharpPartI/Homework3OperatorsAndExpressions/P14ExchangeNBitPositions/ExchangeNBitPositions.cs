using System;

class ExchangeBits
{
	static void Main()
	{
		Console.WriteLine("Please enter unsigned 32-bit integer number.");
		uint number = getValue();
		Console.WriteLine("Please enter position p.");
		byte positionP = getPosition();
		Console.WriteLine("Please enter position q.");
		byte positionQ = getPosition();
		Console.WriteLine("Please enter length k.");
		byte lengthK = getK(positionP, positionQ);
		Console.WriteLine("The number is: {0}", Convert.ToString(number, 2));
		for (byte k = 0; k <= lengthK; k++, positionP++, positionQ++)
		{
			number = exchangeBits(number, positionP, positionQ);
		}
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
	static byte getPosition()
	{
		byte position;
		while (!byte.TryParse(Console.ReadLine(), out position) || position > 32)
		{
			Console.WriteLine("Please enter position (0-32).");
		}
		return position;
	}
	static byte getK(byte position1, byte position2)
	{
		byte lengthK;
		while (!byte.TryParse(Console.ReadLine(), out lengthK) || ((position1 + lengthK - 1) > 32) || ((position2 + lengthK - 1) > 32) || (Math.Abs(position1 - position2) <= lengthK))
		{
			Console.WriteLine("Please enter length K (0-32), make sure the sum of any of the given positions and k does not exceed 32, and the two series are not overstepping (|p -q| > k).");
		}
		return lengthK;
	}

	static uint exchangeBits(uint number, byte position1, byte position2)
	{
		byte bitValue1 = (byte)((number >> position1) & 1);
		Console.WriteLine(bitValue1);
		byte bitValue2 = (byte)((number >> position2) & 1);
		Console.WriteLine(bitValue2);
		if (bitValue1 != bitValue2)
		{
			number = negatePosition(number, position1);
			number = negatePosition(number, position2);
		}
		return number;
	}

	static uint negatePosition( uint number, byte position)
	{
		uint n1 = number >> position;
		uint rest = number ^ (n1 << position);
		return (n1 ^ 1) << position | rest;
	}
}
