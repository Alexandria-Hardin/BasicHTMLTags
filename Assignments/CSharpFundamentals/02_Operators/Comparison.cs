using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Operators
{
    [TestClass]
    public class Comparison
    {
        [TestMethod]
        public void ComparisonOperators()
        {
            int year = 2021;
            string name = "Simon";
            //Equal
            bool equals = year == 2021;
            bool isSimon = "Simon" == name;
            //NotEqual
            bool isNot1990 = year != 1990;

            List<string> firstList = new List<string>();
            List<string> secondList = new List<string>();

            firstList.Add(name);
            secondList.Add(name);

            secondList[0] = "bob";
            //Reference types are tricky
            bool areEqual = firstList == secondList;

            //GreaterThan
            bool greater = year > 2;

            //Greater Than or Equal
            bool greaterOrEqual = year >= 2020;


            //Less Than
            bool less = 2 < 5;

            //Less or Equal
            bool lessOrEqual = 5 <= 5;

            //Or ||

            bool trueValue = true;
            bool falseValue = false;

            bool tOrT = trueValue || trueValue; //true
            bool tOrF = trueValue || falseValue; //true
            bool fOrT = trueValue || trueValue; //true
            bool fOrF = falseValue || falseValue; //can only get a false with or if it is false

            //And &&
            bool tAndT = trueValue && trueValue; //true
            bool tAndF = trueValue && trueValue; //false
            bool fAndT = trueValue && trueValue; //false
            bool fAndF = trueValue && trueValue; //false
            //&& and || are opposites when it comes to the values they give you
        }
    }
}
