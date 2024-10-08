using System;
namespace Arv
{
	public class Dog:Animal
	{
		//Public kan nås inom hela projektet
		//Private kan nås endast i klassen
		//protected kan nås av alla subklasser/härledda klasser

		public Dog(string namn) : base(namn)
		{
			Console.WriteLine($"Dog created {namn}");
		}

		public void MakeSound()
		{
			Console.WriteLine("Bark Bark");
		}
	}
}

