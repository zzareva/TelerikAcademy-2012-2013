using System;

class NullIntegerAndNullDouble
{
	static void Main()
	{
		int? nullableInteger = null;
		double? nullableDouble = null;
		Console.WriteLine("The nullable variable of type integer is printed here: {0}",nullableInteger);
		Console.WriteLine("The nullable variable of type double is printed here: {0}", nullableDouble);
		nullableInteger = 0;
		nullableDouble = 0;
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine("Both variables' values are changed to 0!");
		Console.ForegroundColor = ConsoleColor.Gray;
		Console.WriteLine("The nullable variable of type integer is printed here: {0}", nullableInteger);
		Console.WriteLine("The nullable variable of type double is printed here: {0}", nullableDouble);
		
	}
}
