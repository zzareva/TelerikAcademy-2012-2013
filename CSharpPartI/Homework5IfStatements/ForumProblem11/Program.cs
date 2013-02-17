using System;



class Program
{

	static string[] arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety", "hundred" };

	static void Main(string[] args)
	{

		ushort number;

		bool isNum = ushort.TryParse(Console.ReadLine(), out number);

		if (isNum)
		{

			if (number > 99 && number < 1000)
			{

				Console.WriteLine((double)number / (number % 1000 / 100) == 100 ? arr[number % 1000 / 100] + " " + arr[arr.Length - 1] : arr[number % 1000 / 100] + " " + arr[arr.Length - 1] + " " + (number % 100 / 10 == 0 ? "and" + " " + arr[number % 10] : (number % 100 < 21 ? "and " + arr[(number % 100)] : "and " + arr[18 + (number % 100 / 10)] + " " + (number % 10 != 0 ? arr[number % 10] : " "))));

			}

			else if (number < 100) { Console.WriteLine(number % 100 / 10 == 0 ? arr[number % 10] : (number < 21 ? arr[number] : arr[18 + (number % 100 / 10)] + " " + (number % 10 != 0 ? arr[number % 10] : " "))); }

		}

	}

}