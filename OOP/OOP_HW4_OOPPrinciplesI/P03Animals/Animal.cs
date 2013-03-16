using System;
using System.Linq;

namespace P03Animals
{
	public abstract class Animal : ISound
	{
		public byte Age { get; set; }
		public string Name { get; set; }
		public Gender Sex { get; set; }

		private Animal()
		{
		}

		public Animal(byte age, string name, Gender sex)
		{
			this.Age = age;
			this.Name = name;
			this.Sex = sex;
		}

		public abstract void ProduceSound();

		public static byte GetAverage(Animal[] array)
		{
			return (byte)array.Average( x => x.Age);
		}
	}
}
