using System;
namespace Arv
{
	public class Employee
	{

		//Egenskaper
		public string Name { get; set; }
		private int BaseSalary { get; set; }

		//Konstruktor
		public Employee(string name, int baseSalary)
		{
			Name = name;
			BaseSalary = baseSalary;
		}

		//Metod som är virtuell
		public virtual int CalculateSalary()
		{
			return BaseSalary;
		}
	}
}

