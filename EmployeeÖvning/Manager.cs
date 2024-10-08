using System;
namespace Arv
{
	public class Manager : Employee
	{
		//Egenskaper
		public int Bonus { get; set; }


		//Konstruktor
		public Manager(string Name, int BaseSalary, int bonus) : base(Name, BaseSalary)
		{
			Bonus = bonus;
		}

        //Metod
        public override int CalculateSalary()
        {
			return base.CalculateSalary() + Bonus;
			//return salary + Bonus
        }
    }
}

