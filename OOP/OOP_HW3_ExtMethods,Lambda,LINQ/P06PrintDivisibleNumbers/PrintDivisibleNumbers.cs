//P06 Write a program that prints from given array of integers
//all numbers that are divisible by 7 and 3. Use the built-in 
//extension methods and lambda expressions. Rewrite the same with LINQ.

using System;
using System.Linq;

namespace P06PrintDivisibleNumbers
{
	class PrintDivisibleNumbers
	{
		static void Main()
		{
			int[] array = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,63};

			//Lambda expressions:
			var resultFromLambdaExpression = array.Where(x => x % 3 == 0 && x % 7 == 0).Select(x => x); 
			Console.WriteLine("Numbers that are divisible by 7 and 3 using lambda expressions:");
			Console.WriteLine(string.Join(", ", resultFromLambdaExpression));

			//LINQ:
			var resultFromLINQ = from n in array
								where n % 3 == 0 && n % 7 == 0
								select n;
			Console.WriteLine("Numbers that are divisible by 7 and 3 using LINQ:");
			Console.WriteLine(string.Join(", ", resultFromLINQ));
		}
	}
}
