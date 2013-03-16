using System;
using System.Linq;

namespace P03Animals
{
	public class Frog : Animal
	{
		public override void ProduceSound()
		{
			Console.WriteLine("kwak");
		}

		public Frog(byte age, string name, Gender sex)
			: base(age, name, sex)
		{
		}
	}
}
