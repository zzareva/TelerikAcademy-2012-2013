using System;
using System.Collections.Generic;

class ReadNumbers
{
	private static byte ReadNumber(int start = 1, int end = 100)
	{
		Console.WriteLine("Please enter a number between {0} and {1}",start,end);
		byte number = byte.Parse(Console.ReadLine());
		if (number <= start || number >= end)
			throw new ArgumentException("Value isn't in the required range.");
		else
			return number;
	}
	private static void Print(List<byte> numbers)
	{
		Console.WriteLine("The final list is:\n {0}",string.Join(" < ",numbers));
	}
	static void Main()
	{
		List<byte> numbers = new List<byte>();
		byte max = 100;
		byte min = 0;
		while(numbers.Count < 10)
		{
			try
			{
				byte lastNumber = ReadNumber(min, max);
				numbers.Add(lastNumber);
				min = lastNumber;
			}
			catch (ArgumentException)
			{
				Console.Error.WriteLine("Please make sure the number provided is within the required range.");
			}
			catch (Exception)
			{
				Console.Error.WriteLine("Invalid number. Please enter a valid number.");
			}
		}
		Print(numbers);
	}
}
