using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inheritance_Classes
{
    public class Dog : Animal
    {
        //constructor

        public Dog()
        { 
            Console.WriteLine("This is my dog constructor");
            NumberOfLegs = 4;
            DietType = DietType.Omnivore;
        }
        //property
        public double ToothLength { get; set; }

        //method
        //adding virtual allows children classes to overide parents code
        public virtual void MakeSound()
        {
            Console.WriteLine("Woof");
        }
    }

    public class Chihuahua : Dog
    {
        public Chihuahua()
        {
            Console.WriteLine("This makes a Chihuahua");
        }

        public override void MakeSound()
            {
            Console.WriteLine("yip yip");
        }
    }

    public class Wolf : Dog
    {
        public Wolf()
        {
            Console.WriteLine("This makes a wolf");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Howl");
        }
    }
}
