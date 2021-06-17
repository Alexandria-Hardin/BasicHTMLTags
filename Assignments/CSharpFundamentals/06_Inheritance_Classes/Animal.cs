using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inheritance_Classes
{
    public enum DietType { Herbivore, Omnivore, Carnivore }
    public class Animal
    {
        //Constructor
        public Animal()
        {
            Console.WriteLine("This is the animal constructor");
        }
        //Properties
        public bool HasFur { get; set; }
        public int NumberOfLegs { get; set; }
        public DietType DietType { get; set; }

        //Method
        public void Breathe()
        {
            Console.WriteLine($"this {GetType().Name} takes a breathe");
        }
    }
}
