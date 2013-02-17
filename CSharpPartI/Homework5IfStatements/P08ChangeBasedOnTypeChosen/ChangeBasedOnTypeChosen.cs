using System;

class ChangeBasedOnTypeChosen
{
	static void Main()
	{
		Console.WriteLine("Please enter a value (int, double, string) and value separated with space, e.g. \"int 5\"");
		string wholeEntry;
		string[] entries = new string[2];
		int intValue;
		double doubleValue;
		string stringValue;
		bool typeError;
		do
		{
			typeError = false;
			wholeEntry = Console.ReadLine();
			if (wholeEntry.IndexOf(' ') != -1)
			{
				entries = wholeEntry.Split(' ');
			}
			else
			{
				entries[0] = wholeEntry;
			}
			switch (entries[0])
			{
				case "int":
					if (int.TryParse(entries[1], out intValue))
					{
						Console.WriteLine("Result: {0}", intValue + 1);
					}
					else
					{
						typeError = true;
						Console.WriteLine("Incorrect integer value.");
					}
					break;
				case "double":
					if (double.TryParse(entries[1], out doubleValue))
					{
						Console.WriteLine("Result: {0}", doubleValue + 1);
					}
					else
					{
						typeError = true;
						Console.WriteLine("Incorrect double value.");
					}
					break;
				case "string":
					stringValue = entries[1];
					Console.WriteLine("Result: {0}", stringValue + '*');
					break;
				default:
					Console.WriteLine("The type of the variable is incorrect. Please choose between int, double, and string.");
					break;
			}
		}
		while ((entries[0] != "int" && entries[0] != "double" && entries[0] != "string") || typeError == true);
	}
}
