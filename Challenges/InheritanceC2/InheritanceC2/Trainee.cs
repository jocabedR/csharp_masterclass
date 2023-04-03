using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceC2
{
    internal class Trainee : Employee
    {
        private int WorkingHours { get; set; }
        private int SchoolHours { get; set; }

        public Trainee() { }    

        public Trainee(string name, string lastName, float salary, int workingHours, int schoolHours) : base(name, lastName, salary)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Salary = salary;
            WorkingHours = workingHours;
            SchoolHours = schoolHours;
        }

        public void Learn() {
            Console.WriteLine("I'm Learning for {0} hours.", this.SchoolHours);
        }

        public override void Work()
        {
            Console.WriteLine("I'm working for {0} hours.", this.WorkingHours);
        }

    }
}
