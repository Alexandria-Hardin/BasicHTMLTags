using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_classes_and_objects
{
    class Program
    {
        static void Main(string[] args)
        {
			Donut alexDonut = new Donut();
			alexDonut.Type = "glazed";
			alexDonut.Special = true;
			alexDonut.Filling = "strawberry";
			alexDonut.Count = 2;
			Console.WriteLine($"I ordered {alexDonut.Count} donut(s) and it was {alexDonut.Type} with {alexDonut.Filling} and it was too good to be {alexDonut.Special}");
			Console.ReadLine();
        }
    }
}
