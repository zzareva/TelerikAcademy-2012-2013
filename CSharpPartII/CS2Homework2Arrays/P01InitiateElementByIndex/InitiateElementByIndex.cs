using System;

class InitiateElementByIndex
{
	static void Main()
	{
		int[] theArray = new int[20];
		for (int i = 0; i < theArray.Length; i++)
		{
			theArray[i] = i * 5;
			Console.WriteLine(theArray[i]);
		}
	}
}