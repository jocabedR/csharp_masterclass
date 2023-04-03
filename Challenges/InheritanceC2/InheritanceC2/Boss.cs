using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceC2
{
    internal class Boss : Employee
    {
        private string CompanyCar { get; set; }

        public Boss() { }

        public Boss(string name, string lastName, float salary ,string companyCar) : base(name, lastName, salary)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Salary = salary;
            this.CompanyCar = companyCar;
        }

        public void Lead() {
            Console.WriteLine("I'm the Boss...");
        }
    }
}
