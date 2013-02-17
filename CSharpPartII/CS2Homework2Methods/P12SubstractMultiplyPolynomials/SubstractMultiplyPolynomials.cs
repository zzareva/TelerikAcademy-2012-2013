using System;

class SubstractMultiplyPolynomials
{
	private static int[] GetCoefficent(int input)
	{
		Console.WriteLine("Please enter the coefficients for the polynomial {0} separated by commas. All invalid input will be treated as 0.", input);
		string[] theInput = Console.ReadLine().Split(',');
		int[] theIntInput = new int[theInput.Length];
		for (int i = 0; i < theInput.Length; i++)
		{
			int tempNumber = 0;
			if (!int.TryParse(theInput[i], out tempNumber))
				tempNumber = 0;
			theIntInput[i] = tempNumber;
		}
		return theIntInput;
	}
	private static int[] AddPolynomial(int[] poly1, int[] poly2)
	{
		int maxLength = (poly1.Length > poly2.Length) ? poly1.Length : poly2.Length;
		int[] result = new int[maxLength];
		Array.Reverse(poly1);
		Array.Reverse(poly2);
		for (int i = 0; i < maxLength; i++)
		{
			if (i < poly1.Length)
				result[i] += poly1[i];
			if (i < poly2.Length)
				result[i] += poly2[i];
		}
		Array.Reverse(poly1);
		Array.Reverse(poly2);
		Array.Reverse(result);
		return result;
	}
	private static int[] SubstractPolynomial(int[] poly1, int[] poly2)
	{
		int maxLength = (poly1.Length > poly2.Length) ? poly1.Length : poly2.Length;
		int[] result = new int[maxLength];
		Array.Reverse(poly1);
		Array.Reverse(poly2);
		for (int i = 0; i < maxLength; i++)
		{
			if (i < poly1.Length)
				result[i] += poly1[i];
			if (i < poly2.Length)
				result[i] -= poly2[i];
		}
		Array.Reverse(poly1);
		Array.Reverse(poly2);
		Array.Reverse(result);
		return result;
	}
	private static int[] MultiplyPolynomial(int[] poly1, int[] poly2)
	{
		int maxLength = poly1.Length * poly2.Length;
		int[] result = new int[maxLength];
		Array.Reverse(poly1);
		Array.Reverse(poly2);
		for (int i = 0; i < poly1.Length; i++)
		{
			for (int j = 0; j < poly2.Length; j++)
			{
				result[i+j] += poly1[i]*poly2[j];
			}
		}
		Array.Reverse(poly1);
		Array.Reverse(poly2);
		Array.Reverse(result);
		return result;
	}
	private static void Print(string output, int[] array)
	{
		Console.Write("{0} :", output);
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] != 0)
			{
				Console.Write("{0}", array[i]);
				if (i != array.Length - 1)
					Console.Write("x^{0} + ", array.Length - i - 1);
			}
		}
		Console.WriteLine();
	}
	static void Main()
	{
		int[] firstPolynomial = GetCoefficent(1);
		int[] secondPolynomial = GetCoefficent(2);
		int[] sum = AddPolynomial(firstPolynomial, secondPolynomial);
		Print("Sum: ",sum);
		int[] sustract = SubstractPolynomial(firstPolynomial, secondPolynomial);
		Print("Substract result: ",sustract);
		int[] multiply = MultiplyPolynomial(firstPolynomial, secondPolynomial);
		Print("Multiplication result: ", multiply);
	}
}
