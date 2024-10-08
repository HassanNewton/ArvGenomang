using System;
namespace Arv
{
	public class Developer : Employee
	{

		//Egenskaper
		public int overtimePay { get; set; }
		public int overtimeHours { get; set; }




		//Konstruktor
		public Developer(string Name, int BaseSalary, int overtimePay, int overtimeHours) : base(Name,BaseSalary)
		{
			this.overtimeHours = overtimeHours;
			this.overtimePay = overtimePay;
		}


        //Metod

        public override int CalculateSalary()
        {
            return base.CalculateSalary() + (overtimePay * overtimeHours);
        }
    }
}

