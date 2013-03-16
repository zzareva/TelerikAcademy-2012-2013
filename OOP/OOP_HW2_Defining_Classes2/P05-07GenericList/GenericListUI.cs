using System;
using System.Linq;

namespace P05_07GenericList
{
	class GenericListUI
	{
		static void Main()
		{
			try
			{
				//Create new list of Chars
				GenericList<char> integerListExample = new GenericList<char>(1);
				Console.WriteLine("Empty list: {0}", integerListExample);
				integerListExample.AddElement('a');
				integerListExample.AddElement('b');
				integerListExample.AddElement('c');//+testing the autogrow method
				integerListExample.InsertAtIndex(1, 'r');

				Console.WriteLine("After adding a few elements: {0}", integerListExample);
				integerListExample.RemoveAtIndex(1);
				Console.WriteLine("After removing: {0}", integerListExample);

				//Min
				Console.WriteLine("Min: {0}", integerListExample.GetMin());
				//Max
				Console.WriteLine("Max: {0}", integerListExample.GetMax());
				//Clear
				integerListExample.Clear();
				Console.WriteLine("Clear: {0}", integerListExample);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			try
			{
				//Create new int list
				GenericList<int> integerListExample2 = new GenericList<int>(4);
				Console.WriteLine("Empty list: {0}", integerListExample2);
				integerListExample2.AddElement(3);
				integerListExample2.AddElement(15);
				integerListExample2.InsertAtIndex(3, 32); //+testing the autogrow method
				Console.WriteLine("After adding a few elements: {0}", integerListExample2);
				integerListExample2.RemoveAtIndex(1);
				Console.WriteLine("After removing: {0}", integerListExample2);

				//Min
				Console.WriteLine("Min: {0}", integerListExample2.GetMin());
				//Max
				Console.WriteLine("Max: {0}", integerListExample2.GetMax());
				//Clear
				integerListExample2.Clear();
				Console.WriteLine("Clear: {0}", integerListExample2);
			}
			catch (Exception ex2)
			{
				Console.WriteLine(ex2.Message);
			}


		}
	}
}
