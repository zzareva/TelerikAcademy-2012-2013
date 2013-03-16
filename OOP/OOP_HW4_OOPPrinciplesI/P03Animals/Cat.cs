using System;
using System.Linq;

namespace P03Animals
{
	public class Cat : Animal
	{
		public override void ProduceSound()
		{
			Console.WriteLine("miau");
		}

		public Cat(byte age, string name, Gender sex)
			: base(age, name, sex)
		{
		}
	}
}