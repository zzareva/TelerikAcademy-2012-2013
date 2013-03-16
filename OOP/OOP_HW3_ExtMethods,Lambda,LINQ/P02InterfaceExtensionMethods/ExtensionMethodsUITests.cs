//Implement a set of extension methods for IEnumerable<T> that
//implement the following group functions: sum, product, min, max, average.

using System;
using System.Collections.Generic;
using P01Substring;

namespace P02InterfaceExtensionMethods
{
	class ExtensionMethodsUITests
	{
		static void Main()
		{
			IEnumerable<decimal> exampleEnumerationList = new decimal[] { 1m, 2m, 3m, 4m, 5m, 6m, 7m, 8m, 9m, -22m, 0.2m };
			Console.WriteLine("The input is: {0}",string.Join(", ",exampleEnumerationList));
			Console.WriteLine("The sum is {0}", exampleEnumerationList.Sum<decimal>());
			Console.WriteLine("The product is {0}", exampleEnumerationList.Product<decimal>());
			Console.WriteLine("The min element is {0}", exampleEnumerationList.Min<decimal>());
			Console.WriteLine("The max element is {0}", exampleEnumerationList.Max<decimal>());
			Console.WriteLine("The averige is {0}", exampleEnumerationList.Average<decimal>());
		}
	}
}
