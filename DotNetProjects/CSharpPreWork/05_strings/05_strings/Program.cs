using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_strings
{
    class Program
    {
        static void Main(string[] args)
        {
			string firstName = "Alex";
			string lastName = "Hardin";
			Console.WriteLine(firstName + " " + lastName);
			Console.WriteLine("My name is {0} {1}", firstName, lastName);
			Console.WriteLine($"My name is with interpolation {firstName + " " + lastName}");
			Console.ReadLine();

		}
    }
}
