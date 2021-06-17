using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Conditionals
{
    [TestClass]
    public class SwitchCases
    {
        [TestMethod]
        public void SwitchCase()
        {
            //Structure of SwitchCases
            //1: switch keyboard
            //2: value evaluating
            //3: cases
            //4: breaking out

            int input = 1;

            //1     //2
            switch (input)
            {
                //3
                case 1:
                    Console.WriteLine("Hello");
                    break;
                case 2:
                    Console.WriteLine("That is number two");
                    break;
                default:
                    Console.WriteLine("This is the default option");
                    break;
            }

            DayOfWeek today = DayOfWeek.Wednesday;
            //1      //2
            switch (today)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayofWeeek.Thursday:
                    Console.WriteLine("open 10AM - 9PM");
                    //4
                    break;
                case DayOfWeek.Friday:
                case DayOfWeek.Saturday:
                    Console.WriteLine(""open 10AM - 2AM"");
                    break;
                case DayOfWeek.Sunday:
                    Console.WriteLine(""2PM - 3PM"");
            }

            if (today == DayOfWeek.Monday || today == DayOfWeek.Tuesday || today == DayOfWeek.Wednesday || today == DayOfWeek.Thursday)
                Console.WriteLine("open 10AM - 9AM");

        }
    }
}
