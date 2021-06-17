using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_ReferenceTypes
{
    [TestClass]
    public class ReferenceTypesExamples
    {
        private const string V = "Pie";

        [TestMethod]
        public void Strings()
        {
            string thisIsAStringDeclaration;

            thisIsAStringDeclaration = "Hello World";
            //null vs 0
            //null is where there is none, like a toilet paper holder with nothing on it
            //0 is where you have a toilet paper holder with an empty roll on it

            string declaredAndInitialized = "Hello Peoples";

            //Manipulation of string
            string firstName = "Alex";
            string lastName = "Hardin";

            //Concatenation is +
            string concatinatedName = firstName + lastName;
            //composite formatting {0} {1}
            string compositeName = string.Format("{0} {1}", firstName, lastName);
            //interpolation
            string interpolatedName = $"{firstName} {lastName}";

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(concatinatedName);
            Console.WriteLine(interpolatedName);
        }

        [TestMethod]
        public void Collection()
        {
            //Array
            string stringExample = "Hi";
            string[] stringArray = { "Hello", "World", "Pickles", stringExample };

            string secondItem = stringArray[1];
            //second item is 1 because we start at 0

            int[] intArray = new int[4];
            int firstItem = intArray[0];
            //for integers the default is 0

            //List
            List<string> listOfStrings = new List<string>();

            listOfStrings.Add("First string in list");

            Console.WriteLine(listOfStrings[0]);

            //Queue
            //First in First out
            //in general we have to add new whenever we add another type of class
            Queue<string> queueOfStrings = new Queue<string>();
            queueOfStrings.Enqueue("first");
            queueOfStrings.Enqueue("second");

            string firstQueue = queueOfStrings.Dequeue();
            string secondQueue = queueOfStrings.Peek();

            //Stack
            //First in Last out, like a pringle can

            Stack<int> intStack = new Stack<int>();
            //stacks have push and pop tools
            intStack.Push(1);
            intStack.Push(2);

            int firstStack = intStack.Pop();
            //pop is like the opposite of dequeue, it takes it off the top and gives it to us 
            int secondStack = intStack.Peek();

            //Dictionaries
            //Key Value Pair
            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();

            keyAndValue.Add(7, "ApplePie");
            keyAndValue.Add(7, "Tacos");
            //Do not add two elements to the same tie, it will break

            string pieExample = keyAndValue["Pie"];
        }

        [TestMethod]
        public void Classes()
        {
            Random randomNumberGenerator = new Random();

            int randomNumber = randomNumberGenerator.Next();
        }
    }
}
