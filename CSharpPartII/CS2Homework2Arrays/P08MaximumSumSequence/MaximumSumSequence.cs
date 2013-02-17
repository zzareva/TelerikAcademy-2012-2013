using System;

class MaximumSumSequence
{
	static void Main()
	{
		Console.WriteLine("Please enter all elements separated with commas. Example: 0,1,2,3,4");
		Console.ForegroundColor = System.ConsoleColor.Red;
		Console.WriteLine("All invalid input will have value 0.");
		Console.ForegroundColor = System.ConsoleColor.Gray;
		string[] input = Console.ReadLine().Split(',');
		int[] numericInput = new int[input.Length];
		int tempNum;
		for (int i = 0; i < numericInput.Length; i++)
		{
			tempNum = 0;
			int.TryParse(input[i], out tempNum);
			numericInput[i] = tempNum;
		}
		int max = numericInput[0];
		int maxEnd = numericInput[0];
		int sequenceLength = 1;
		int currentSequenceLength = 1;
		int start = 0;
		int tempStart = 0;
		for (int i = 1; i < numericInput.Length; ++i)
		{
			if (numericInput[i] + maxEnd > numericInput[i])
			{
				maxEnd = numericInput[i] + maxEnd;
				currentSequenceLength++;
			}
			else
			{
				maxEnd = numericInput[i];
				tempStart = i;
				currentSequenceLength = 1;
			}
			if (maxEnd > max)
			{
				max = maxEnd;
				sequenceLength = currentSequenceLength;
				start = tempStart;
			}
		}
		Console.WriteLine("The sequence with the maximum sum is: ");
		for (int i = start; i < start + sequenceLength; ++i)
		{
			Console.Write("{0} ", numericInput[i]);
		}
		Console.WriteLine();
	}
}