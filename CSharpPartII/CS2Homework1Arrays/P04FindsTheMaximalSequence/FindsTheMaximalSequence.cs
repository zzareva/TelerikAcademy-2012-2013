using System;

class FindsTheMaximalSequence
{
	static void Main()
	{
		int arraySize = 0;
		do
		{
			Console.Write("Please enter an array size greater than 0:");
		}
		while (!int.TryParse(Console.ReadLine(), out arraySize));
		int[] theArray = new int[arraySize];
		string maxSequence = "";
		int maxSequenceCount = 0;
		string currentSequence = "";
		int currentSequenceCount = 0;
		int previousElement = 0;
		for (int i = 0; i < theArray.Length; i++)
		{
			Console.Write("Please enter element number {0}: ",i + 1);
			 theArray[i] = GetNumber();
			 if (i == 0)
			 {
				 currentSequence = Convert.ToString(theArray[i]);
				 currentSequenceCount = 1;
				 previousElement = theArray[i];
			 }
			 else
			 {
				 if (theArray[i] == previousElement)
				 {
					 currentSequenceCount++;
					 currentSequence += ("," + theArray[i]);
				 }
				 else
				 {
					if (currentSequenceCount > maxSequenceCount)
					{
						maxSequenceCount = currentSequenceCount;
						maxSequence = currentSequence;
					}
					 currentSequence = Convert.ToString(theArray[i]);
					 currentSequenceCount = 1;
					 previousElement = theArray[i];
				 }
			 }
		}
		Console.WriteLine(maxSequence);
	}
	static int GetNumber()
	{
		int number = 0;
		while (!int.TryParse(Console.ReadLine(), out number))
		{
			Console.WriteLine("Please enter a valid integer number.");
		}
		return number;
	}
}
