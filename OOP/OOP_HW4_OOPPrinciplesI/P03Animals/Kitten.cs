using System;
using System.Linq;

namespace P03Animals
{
	class Kitten : Cat
	{
		new public Gender Sex 
		{
			get
			{
				return this.Sex;
			}
			set
			{
				if (value != Gender.Female)
					throw new ArgumentException("Kittens can be only female.");
				this.Sex = value;
			}
		}
		
		public Kitten(byte age, string name, Gender sex) : base(age, name, sex)
		{
		}

		public override void ProduceSound()
		{
			Console.WriteLine("meaow");
		}
	}
}
