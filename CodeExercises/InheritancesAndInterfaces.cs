using System;

namespace Coding.Exercise
{
    
    // place for your classes and an interfac
    interface IShootable {
        
        string Message { get; set;}
        
        void Shoot();
    }
    
    class Weapon {
        protected string Name { get; set; }
        
        public void Label() {
            Console.WriteLine("This is {0}!", Name);
        }
    }
    
    class Gun : Weapon, IShootable {
        
        public string Message { get; set;}
        
        public Gun() {
            Name = "Gun";
            Message = "Bang!";
        }
        
        public void Shoot() {
            Console.WriteLine(Message);
        }
    }
    
    public static class Program{
        static public void Main(string[] args){
            // new instance 
            Gun pist = new Gun();

            // test for methods
            pist.Label();
            pist.Shoot();

            // verifying the interface and the parent class
            if (pist is IShootable && pist is Weapon)
                System.Console.WriteLine("Yes, it is my parents.");
        } 
    }
}
