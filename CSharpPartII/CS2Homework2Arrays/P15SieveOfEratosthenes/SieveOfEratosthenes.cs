using System;

class SieveOfEratosthenes
{
	static void Main()
	{
		long limit = 10000000;
		//limit = 100; - > just for testing
		bool[] isPrimeNumber = new bool[limit];
		for (int i = 2; i < limit; i++)
		{
			isPrimeNumber[i] = true;
		}
		for (int j = 2; j < limit; j++)
		{
			if (isPrimeNumber[j])
			{
				for (long p = 2; (p * j) < limit; p++)
				{
					isPrimeNumber[p * j] = false; //set to false all multiplications
				}
			}
		}
		//for (int i = 0; i < limit; i++)
		//{
		//    if (isPrimeNumber[i] == true)
		//    {
		//        Console.Write(i + ",");
		//    }
		//}
		//Console.WriteLine();
	}
}
