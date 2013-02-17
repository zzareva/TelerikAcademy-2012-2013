using System;

class CheckThirsBitValue
{
	const int bitPosition = 3;
	static void Main()
	{
		Console.WriteLine("Please enter an integer number.");
		int value = getValue();
		int valueToRight = value >> bitPosition;
		int result = valueToRight & 1;
		bool isThirdDigitOne = result == 1;
		Console.WriteLine("Bit 3 of the given integer ({0} = {1}) has digit {2}",value,Convert.ToString(value,2),result);
		Console.WriteLine("Boolean expression isThirdDigitOne has value: {0}", isThirdDigitOne);
	}
	static int getValue()
	{
		int value;
		while(!int.TryParse(Console.ReadLine(),out value))
		{
			Console.WriteLine("Please enter correct integer value.");
		}
		return value;
	}
}
