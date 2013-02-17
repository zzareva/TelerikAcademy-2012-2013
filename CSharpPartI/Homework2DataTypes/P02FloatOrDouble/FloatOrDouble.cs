using System;

class FloatOrDouble
{
	static void Main()
	{
		double variable1 = 34.567839023;
		float variable2 = 12.345f;
		float variable3 = 8923.1234857f;
		float variable4 = 3456.091f;
		Console.WriteLine("{0} has type {1}", variable1, variable1.GetType());
		Console.WriteLine("{0} has type {1}", variable2, variable2.GetType());
		Console.WriteLine("{0} has type {1}", variable3, variable3.GetType());
		Console.WriteLine("{0} has type {1}", variable4, variable4.GetType());

	}
}
