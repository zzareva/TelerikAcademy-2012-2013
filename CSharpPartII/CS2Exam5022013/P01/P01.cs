using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

class P01
{
	static void Main()
	{
		//Console.SetIn(new StreamReader(@"C:\Users\zzareva\Desktop\input1.txt"));
		string number = Console.ReadLine();
		char currentLetter = '0';
		byte digit = 0;
		int value = 0;
		long sum = 0;

		for (int i = number.Length - 1; i >= 0; i--)
		{
			currentLetter = number[i];
			if (i - 1 >= 0 && number[i - 1] >= 97 && number[i - 1] <= 122)
			{
				value = (number[i - 1] - 'a' + 1) * 26 + currentLetter - 'A';
				i--;
			}
			else
			{
				value = currentLetter - 'A';
			}
			sum += (long)Math.Pow(168, digit) * value;
			digit++;
		}
		Console.WriteLine(sum);
	}
}
