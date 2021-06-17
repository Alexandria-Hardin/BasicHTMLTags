using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Conditionals
{
    [TestClass]
    public class Ternary
    {
        [TestMethod]
        public void Ternaries()
        {
            //Ternary Structure
            //(Condition/Boolean) ? trueResult : falseResult;
            int Age = 42;

            bool isAdult = (age >= 18) ? true : false;
            string isAdultResult = (age is >= 18) ? "Is an Adult" : "is Not Adult";

            int numOne = 10;
            int numTwo = (numOne != 10) ? 30 :20;
        }
    }
}
