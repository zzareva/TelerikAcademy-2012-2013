using System;
using System.Linq;

namespace P05_07GenericList
{
	public class GenericList<T> where T : IComparable
	{
		#region Fields
		private object[] theList;
		private int lastNonEmpty;
		#endregion

		public GenericList(int size)
		{
			theList = new object[size];
		}

		public T this[int index]
		{
			get
			{
				return (T)theList[index];
			}

			set
			{
				theList[index] = value;
			}
		}
		#region Methods

		public void AddElement(T element)
		{
			if (lastNonEmpty >= theList.Length)
			{
				AutoGrow();
			}
			theList[lastNonEmpty] = element;
			lastNonEmpty++; //increasing the the last non-empty index too. It keeps track of the records so we will know where to insert new elements if the index isn't predefined
		}

		public void RemoveAtIndex(int index)
		{
			if (index < 0 || index > theList.Length - 1) //check if the index is out of the range
			{
				throw new IndexOutOfRangeException("You have tried to remove an element at invalid position");
			}
			var newList = new object[theList.Length - 1];
			for (int i = 0; i < index; i++)
			{
				newList[i] = theList[i];
			}
			for (int j = index; j < theList.Length - 1; j++)
			{
				newList[j] = theList[j + 1];
			}
			theList = newList;
			if(lastNonEmpty >= index)
				lastNonEmpty--; //taking it out from the the last non-empty index too
		}

		public void InsertAtIndex(int index, T element)
		{
			object[] newList;
			if (index < 0 || index > theList.Length - 1) //check if the index is out of the range
			{
				throw new IndexOutOfRangeException("You have tried to insert an element at invalid position");
			}
			else
			{
				newList = new object[theList.Length + 1];
			}
			for (int i = 0; i < index; i++)
			{
				newList[i] = theList[i];
			}
			newList[index] = element;
			for (int j = index; j < theList.Length; j++)
			{
				newList[j + 1] = theList[j];
			}
			theList = newList;
		}

		public void Clear()
		{
			theList = new object[theList.Length];
			lastNonEmpty = 0;//clearing the last non-empty index too
		}

		public T GetMin()
		{
			var minValue = (IComparable)theList[0];
			for (int i = 1; i < theList.Length; i++)
			{
				var item = theList[i];
				if (minValue != null && item != null && minValue.CompareTo(item) > 0)
					minValue = (IComparable)item;
			}
			return (T)minValue;
		}

		public T GetMax()
		{
			var maxValue = (IComparable)theList[0];
			for (int i = 1; i < theList.Length; i++)
			{
				var item = theList[i];
				if (maxValue != null && item != null && maxValue.CompareTo(item) < 0)
					maxValue = (IComparable)item;
			}
			return (T)maxValue;
		}

		public override string ToString()
		{
			return String.Join(", ", theList);
		}

		private void AutoGrow()
		{
			var newList = new object[theList.Length * 2];
			for (int i = 0; i < theList.Length; i++)
			{
				newList[i] = theList[i];
			}
			theList = newList;
		}

		#endregion
	}
}
