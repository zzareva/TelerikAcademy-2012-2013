using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Exam6FebP03Tubes
{
	class Tubes
	{
		static void Main()
		{
			//Console.SetIn(new StreamReader(@"C:\Users\xx\Desktop\input.txt"));
			int numberOfTubes = int.Parse(Console.ReadLine());
			int[] tubes = new int[numberOfTubes];
			int tubesNeeded = int.Parse(Console.ReadLine());
			for (int i = 0; i < numberOfTubes; i++)
			{
				tubes[i] = int.Parse(Console.ReadLine());
			}
			int max = 2000000000;
			int min = 1;
			int tryThisSize = (min + max) / 2;
			
			int tubesCount = 0;
			while(max >= min)
			{
				tubesCount = 0;
				for (int t = 0; t < numberOfTubes; t++)
				{
					tubesCount += (tubes[t] / tryThisSize);
				}
				if (tubesCount < tubesNeeded)
					max = tryThisSize - 1;
				else
					min = tryThisSize + 1;
				tryThisSize = (min + max) / 2;
			}
			Console.WriteLine(max);
		}
	}
}
