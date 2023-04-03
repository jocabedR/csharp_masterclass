using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceC2
{
    internal class Employee
    {
        protected string Name { get; set; }
        protected string LastName { get; set; }
        protected float Salary { get; set; }

        public Employee() { }
        public Employee(string name, string lastName, float salary)
        {
            Name = name;
            LastName = lastName;
            Salary = salary;
        }

        public virtual void Work() {
            Console.WriteLine("I'm working...");
        }
        public void Pause() {
            Console.WriteLine("I'm taking a break...");
        }
    }
}
