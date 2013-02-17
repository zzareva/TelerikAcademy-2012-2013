using System;

class ObjectStringTypeCasting
{
	static void Main()
	{
		string stringVar1 = "Hello";
		string stringVar2 = "World";
		object helloWorldObject = stringVar1 + " " + stringVar2;
		string helloWorldString = (string)helloWorldObject;
		Console.WriteLine("And here is the result {0}",helloWorldString);
	}
}
