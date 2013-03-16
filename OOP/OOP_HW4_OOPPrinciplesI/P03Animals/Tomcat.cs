using System;
using System.Linq;

namespace P03Animals
{
	class Tomcat : Cat
	{
		new public Gender Sex
		{
			get
			{
				return this.Sex;
			}
			set
			{
				if (value != Gender.Male)
					throw new ArgumentException("Tomcats can be only male.");
				this.Sex = value;
			}
		}

		public Tomcat(byte age, string name, Gender sex) : base(age, name, sex)
		{
		}

		public override void ProduceSound()
		{
			Console.WriteLine("purrr");
		}
	}
}
