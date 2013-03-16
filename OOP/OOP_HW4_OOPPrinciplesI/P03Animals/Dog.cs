using System;
using System.Linq;

namespace P03Animals
{
	public class Dog : Animal
	{
		public override void ProduceSound()
		{
			Console.WriteLine("bau");
		}

		public Dog(byte age, string name, Gender sex)
			: base(age, name, sex)
		{
		}
	}
}
