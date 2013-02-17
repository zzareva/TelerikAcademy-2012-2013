using System;

class MostFrequestMember
{
	static void Main()
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
		int[] numberOfAppearances = new int[theIntInput.Length];
		for (int j = 0; j < theIntInput.Length; j++)
		{
			for (int k = 0; k < theIntInput.Length; k++)
			{
				if (theIntInput[k] == theIntInput[j])
					numberOfAppearances[k]++;
			}
		}
		int maxAppearances = 0;
		for (var m = 0; m < numberOfAppearances.Length; m++)
		{
			if (numberOfAppearances[m] > maxAppearances)
			{
				maxAppearances = m;
			}
		}
		Console.WriteLine("{0} ({1} times)",theIntInput[maxAppearances],numberOfAppearances[maxAppearances]);
	}
}
