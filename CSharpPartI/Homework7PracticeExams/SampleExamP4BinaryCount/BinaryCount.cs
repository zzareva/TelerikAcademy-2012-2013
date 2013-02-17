using System;

class BinaryCount
{
	static void Main()
	{
		byte bit = byte.Parse(Console.ReadLine());
		int numberN = int.Parse(Console.ReadLine());
		uint[] numbers = new uint[numberN];
		for (int i = 0; i < numberN; i++)
		{
			numbers[i] = uint.Parse(Console.ReadLine());
		}
		foreach (uint k in numbers)
		{
			uint ones = GetNumberOfOnes(k);
			uint result = ones;
			if (bit == 0)
			{
				uint binaryNumberLength = (uint)Convert.ToString(k,2).Length;
				result = binaryNumberLength - ones;
			}
			//Console.WriteLine("{0} is shown {1} times in {2}",B,result,Convert.ToString(k,2));
			Console.WriteLine(result);
		}
	}
	static uint GetNumberOfOnes(uint number)
	{
		uint count = 0;
		while(number > 0)
		{
			count++;
			number &= number - 1;
		}
		return count;
	}
}
