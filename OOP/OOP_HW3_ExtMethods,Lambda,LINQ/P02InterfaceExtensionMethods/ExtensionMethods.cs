using System;
using System.Collections.Generic;
using System.Linq;

namespace P01Substring
{
	public static class ExtensionMethod
	{
		public static T Sum<T>(this IEnumerable<T> collection)
		{
			dynamic sum = 0;
			foreach (var item in collection)
			{
				sum += (dynamic)item;
			}
			return sum;
		}

		public static T Product<T>(this IEnumerable<T> collection)
		{
			dynamic product = 1;
			foreach (var item in collection)
			{
				product *= (dynamic)item;
			}
			return product;
		}

		public static T Min<T>(this IEnumerable<T> collection)
		{
			var collectionArray = collection.ToArray();
			dynamic minValue = (IComparable)collectionArray[0];
			foreach (var item in collectionArray)
			{
				if (minValue != null && item != null && minValue.CompareTo(item) > 0)
					minValue = (IComparable)item;
			}
			return (T)minValue;
		}

		public static T Max<T>(this IEnumerable<T> collection)
		{
			var collectionArray = collection.ToArray();
			var maxValue = (IComparable)collectionArray[0];
			for (int i = 1; i < collectionArray.Count(); i++)
			{
				var item = collectionArray[i];
				if (maxValue != null && item != null && maxValue.CompareTo(item) < 0)
					maxValue = (IComparable)item;
			}
			return (T)maxValue;
		}

		public static T Average<T>(this IEnumerable<T> collection)
		{
			dynamic sum = 0;
			foreach (var item in collection)
			{
				sum += (dynamic)item;
			}
			return sum/collection.Count();
		}
	}

}
