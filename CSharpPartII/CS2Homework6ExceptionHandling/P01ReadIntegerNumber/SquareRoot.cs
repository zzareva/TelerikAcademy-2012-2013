using System;

class SquareRoot
{
	private static double Square(int number)
	{
		if (number < 0)
			throw new ArgumentOutOfRangeException("The method sqrt can handle only positive numbers.");
		else
			return Math.Sqrt(number);
	}
	static void Main()
	{
		Console.WriteLine("Please enter an integer number");
		try
		{
			int intNumber = int.Parse(Console.ReadLine());
			Console.WriteLine("The square root is: {0}",Square(intNumber));
		}
		catch (FormatException)
		{
			Console.Error.WriteLine("Invalid number");
		}
		catch (OverflowException)
		{
			Console.Error.WriteLine("Invalid number");
		}
		catch (Exception)
		{
			Console.Error.WriteLine("Invalid number");
		}
		finally
		{
			Console.WriteLine("Good bye");
		}
	}
}
