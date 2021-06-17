using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _00_TypesandVariables
{
    [TestClass]
    public class ValueTypeExamples
    {
        //variables hold types of values
        //Bool
        [TestMethod]
        public void Booleans()
        {
            //Declaration 
            bool isDeclared;

            //Assigning a value
            isDeclared = true;

            bool declaredAndAssigned = false;
        }
        //Characters
        [TestMethod]
        public void Characters()
        {
            //single quotes for characters
            //test method=test tab tab
            char character = 'a';
            char symbol = '!';
            char number = '7';
            char space = ' ';
            char specialCharacter = '/';

        }
        //WholeNumbers
        [TestMethod]
        public void WholeNumbers()
        {
            //a byte is essentially like 8 on and off switches
            //longest byte value is 255 and smallest is 0
            byte byteExample = 255;
            //assigned bytes can go into the negatives up to 128 but only positive 127
            sbyte signedByteExample = -128;
            //shorts are by default assigned
            //integer is equal to whole number and short is an integer
            short shortExample = 3278;
            Int16 anotherShortExample = -32768;
            int intMax = 2147483647;
            Int32 intMin = 2147483647;
            long longExample = 9223372036854775807;
        }
        //Decimals
        [TestMethod]
        public void Decimals()
        {
            //will most of the time use decimals over shorts and longs
            //decimal has most precision
            float floatExample = 1.0287f;
            double doubleExample = 2.123123123123d;
            decimal decimalExample = 3.125345345m;

            Console.WriteLine(1.0287f);
            Console.WriteLine(1.0287d);
            Console.WriteLine(1.0287m);
        }
        //Enums

        enum PastryType {  Eclaire, Croissant, Danish }
        //declare outside of test method
        //alt up or down will move your code up or dowm
        [TestMethod]
        public void enums()
        {
            //declaring that pastry type allows the types to drop down to tab them after typing .
            PastryType myPastry = PastryType.Eclaire;
            PastryType anotherOne = PastryType.Croissant;
        }
        //Structs
        [TestMethod]
        public void Structs()
        {
            //anything that has a default value is a struct
            //date times is one of the biggest ones
            DateTime today = DateTime.Today;

            //can not add integers, have to use the systems controls
            //slashees indicate division so you have to use commas
            //int year,int month, int day
            DateTime tomorrow = new DateTime(2021,6,16);


        }
        //**
        //int
        //string*
        //dec
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
