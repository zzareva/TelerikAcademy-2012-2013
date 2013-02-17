using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

class P05
{
	private static bool IsPalindrom(string word)
	{
		bool isPalindrome = true;
		for (int i = 0; i < word.Length / 2; i++)
		{
			if (!word[i].Equals(word[word.Length - i - 1]))
			{
				isPalindrome = false;
				return isPalindrome;
			}
		}
		return (isPalindrome);
	}
	private static string ConvertToNewBase(long number)
	{
		StringBuilder convertedNumber = new StringBuilder();
		while (number > 0)
		{
			byte remainder = (byte)(number % 2);
			number /= 2;
			convertedNumber.Insert(0, remainder);
		}
		return convertedNumber.ToString();
	}

	static void Main()
	{
		//Console.SetIn(new StreamReader(@"C:\Users\zzareva\Desktop\input2.txt"));
		string[] input1 = Console.ReadLine().Split(' ');
		long number1 = long.Parse(input1[0]);
		long number2 = long.Parse(input1[1]);
		string remainder;
		string remainder1;
		int counter = 0;
		for (long i = number1; i <= number2; i+=2)
		{
			string binary = ConvertToNewBase(i);
			if (IsPalindrom(binary))
			{
				remainder = binary.Replace("101", "");
				remainder = remainder.Replace("11", "");
				remainder1 = binary.Replace("11", "");
				remainder1 = remainder1.Replace("101", "");
				if (remainder.Length == 0 && remainder1.Length == 0)
				{
					counter++;
					//Console.WriteLine("{0} {1}", i, binary);
				}
			}


		}
		Console.WriteLine(counter);
		string[] input2 = Console.ReadLine().Split(',');
		int[] numbers = new int[input2.Length];
		for (int k = 0; k < numbers.Length; k++)
		{
			numbers[k] = int.Parse(input2[k]);
		}
		double percent = double.Parse(Console.ReadLine()) / 100;
		int required = (int)Math.Round((numbers.Length * percent));
		Array.Sort(numbers);
		int theNumber = numbers[required - 1];
		Console.WriteLine(theNumber);
	}
}