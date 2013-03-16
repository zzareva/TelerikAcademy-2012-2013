using System;
using System.Linq;

namespace P03Animals
{
	class AnimalsMain
	{
		static void Main()
		{
			Animal[] allAnimals = new Animal[5];
			allAnimals[0] = new Dog(5, "Damage", Gender.Male);
			allAnimals[1] = new Cat(5, "Sahara", Gender.Female);
			allAnimals[2] = new Kitten(7, "Kroki", Gender.Female);
			allAnimals[3] = new Frog(5, "Suzi", Gender.Male);
			allAnimals[4] = new Tomcat(1, "Suzi", Gender.Male);

			Console.WriteLine("Sounds:");
			allAnimals[0].ProduceSound();
			allAnimals[1].ProduceSound();
			allAnimals[2].ProduceSound();
			allAnimals[3].ProduceSound();
			allAnimals[4].ProduceSound();

			Console.WriteLine("Animals average age: {0}", Animal.GetAverage(allAnimals));

			Dog[] someDogs = new Dog[4];
			someDogs[0] = new Dog(5, "Damage", Gender.Male);
			someDogs[1] = new Dog(5, "Sahara", Gender.Female);
			someDogs[2] = new Dog(7, "Kroki", Gender.Female);
			someDogs[3] = new Dog(5, "Suzi", Gender.Male);

			Console.WriteLine("Dogs average age: {0}", Animal.GetAverage(someDogs));

			Frog[] frogs = new Frog[2];
			frogs[0] = new Frog(2, "Kermit", Gender.Male);
			frogs[1] = new Frog(1, "Kwaki", Gender.Female);

			Console.WriteLine("Frogs average age: {0}", Animal.GetAverage(frogs));




		}
	}
}
