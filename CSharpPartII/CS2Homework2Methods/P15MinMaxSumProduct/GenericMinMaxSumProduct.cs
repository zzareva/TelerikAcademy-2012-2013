using System;
using System.Collections.Generic;

class MinMaxSumProduct
{
	public static T GetMin<T>(params T[] collection) where T : IComparable<T>
	{
		T min = collection.Length > 0 ? collection[0] : default(T);
		foreach (T elem in collection)
		{
			if (elem.CompareTo(min) < 0)
			{
				min = elem;
			}
		}
		return min;
	}

	public static T GetMax<T>(params T[] collection) where T : IComparable<T>
	{
		T max = collection.Length > 0 ? collection[0] : default(T);
		foreach (T elem in collection)
		{
			if (elem.CompareTo(max) > 0)
			{
				max = elem;
			}
		}
		return max;
	}

	public static T GetSum<T>(params T[] collection)
	{
		dynamic sum = default(T);
		foreach (T elem in collection)
		{
			sum += elem;
		}
		return sum;
	}

	public static double GetAverage<T>(params T[] collection)
	{
		dynamic sum = GetSum(collection);
		double length = (double)collection.Length;
		double average = sum / length;
		return average;
	}

	public static T GetProduct<T>(params T[] collection)
	{
		dynamic multiply = 1;

		foreach (T elem in collection)
		{
			multiply *= elem;
		}
		return multiply;
	}

	static void Main()
	{
		int[] numbers = { -1,-2,-3 };

		Console.WriteLine("Integer values:");
		Console.WriteLine("Minumum: {0}", GetMin(numbers));
		Console.WriteLine("Maximum: {0}", GetMax(numbers));
		Console.WriteLine("Average: {0}",GetAverage(numbers));
		Console.WriteLine("Sum: {0}",GetSum(numbers));
		Console.WriteLine("Product: {0}",GetProduct(numbers));
		
		double[] doubleNumbers = { 2, -9, -8, 4 };

		Console.WriteLine("Integer values:");
		Console.WriteLine("Minumum: {0}", GetMin(doubleNumbers));
		Console.WriteLine("Maximum: {0}", GetMax(doubleNumbers));
		Console.WriteLine("Average: {0}", GetAverage(doubleNumbers));
		Console.WriteLine("Sum: {0}", GetSum(doubleNumbers));
		Console.WriteLine("Product: {0}", GetProduct(doubleNumbers));
	}
}