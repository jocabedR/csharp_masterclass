using System;

namespace Coding.Exercise
{
    public class Phone
    {
        public string Company;
        public string Model;
        public string ReleaseDay;
        
        // Place for your constructors
        public Phone() {
            this.Company = "unknown";
            this.Model = "unknown";
            this.ReleaseDay = "unknown";
        }
        
        public Phone(string Company, string Model) {
            this.Company = Company;
            this.Model = Model;
            this.ReleaseDay = "unknown";
        }
        
        public Phone(string Company, string Model, string ReleaseDay) {
            this.Company = Company;
            this.Model = Model;
            this.ReleaseDay = ReleaseDay;
        }

        
        public void Introduce()
        {
            Console.WriteLine("It is {0} created by {1}. It was released {2}.", Model, Company, ReleaseDay);
        }
        
    }
    
}