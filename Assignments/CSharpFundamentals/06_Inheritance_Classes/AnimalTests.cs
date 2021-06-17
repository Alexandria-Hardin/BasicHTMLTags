using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_Inheritance_Classes
{
    [TestClass]
    public class AnimalTests
    {
        [TestMethod]
        public void DogTests()
        {
            Animal genericAnimal = new Animal();
            genericAnimal.Breathe();

            Console.WriteLine();
            Dog fido = new Dog();
            fido.Breathe();
            fido.MakeSound();

            Console.WriteLine();
            Chihuahua betsy = new Chihuahua();
            betsy.Breathe();
            betsy.MakeSound();

            Console.WriteLine();
            Wolf balto = new Wolf();
            balto.MakeSound();
        }
    }

}
