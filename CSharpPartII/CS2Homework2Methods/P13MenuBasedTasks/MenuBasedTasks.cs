using System;

class MenuBasedTasks
{
	private static int GetNumber(int min = int.MinValue, int max = int.MaxValue)
	{
		int number = 0;
		while (!int.TryParse(Console.ReadLine(), out number) || number < min || number > max)
		{
			Console.WriteLine("Invalid number! Please enter an integer number between {0} and {1}.",min,max);
		}
		return number;
	}
	static int[] GetInputArray()
	{
		Console.WriteLine("Please enter the array valued separated by commas. All invalid input will be treated as 0.");
		string[] theInput = Console.ReadLine().Split(',');
		int[] theIntInput = new int[theInput.Length];
		for (int i = 0; i < theInput.Length; i++)
		{
			int tempNumber = 0;
			if (!int.TryParse(theInput[i], out tempNumber))
				tempNumber = 0;
			theIntInput[i] = tempNumber;
		}
		return theIntInput;
	}
	private static double GetEquationCoefficients(char coeffName)
	{
		Console.Write("{0} = ",coeffName);
		double number = 0;
		while (!double.TryParse(Console.ReadLine(), out number) || (coeffName == 'a' && number == 0))
		{
			Console.WriteLine("Invalid number! Please enter the value for {0} again.",coeffName);
			if(coeffName == 'a' && number == 0)
				Console.WriteLine("0 is not a valid value for a.");
		}
		return number;
	}
	private static int ReverseNumber()
	{
		Console.Write("Please enter the number which should be reversed:");
		int input = GetNumber();
		char[] digits = input.ToString().ToCharArray();
		Array.Reverse(digits);
		return int.Parse(String.Join("", digits));
	}
	private static decimal CalculateAverage()
	{
		int[] input = GetInputArray();
		int sum = 0;
		foreach (var el in input)
		{
			sum += el;
		}
		decimal average = sum / input.Length;
		return average;
	}
	private static double SolveTaskEquation()
	{
		double a = GetEquationCoefficients('a');
		double b = GetEquationCoefficients('b');
		return (-b / a);
	}
	private static void Print(int number)
	{
		Console.WriteLine("Result: {0}",number);
	}
	private static void Print(decimal number)
	{
		Console.WriteLine("Result: {0}", number);
	}
	private static void Print(double number)
	{
		Console.WriteLine("Result: {0}", number);
	}
	private static void PrintMenu()
	{
		Console.WriteLine("Please choose a task from the menu below by entering the task number and pressing Enter");
		Console.WriteLine("1 - Reverse the digits of a number");
		Console.WriteLine("2 - Calculate the average of a sequence of integers");
		Console.WriteLine("3 - Solves a linear equation a * x + b = 0");
		Console.WriteLine();
		Console.Write("Your choice: ");
	}
	static void Main()
	{
		PrintMenu();
		int chosenTask = GetNumber(1,3);
		if (chosenTask == 1)
		{
			int result = ReverseNumber();
			Print(result);
		}
		else if (chosenTask == 2)
		{
			decimal result = CalculateAverage();
			Print(result);
		}
		else
		{
			double result = SolveTaskEquation();
			Print(result);
		}
	}
}
