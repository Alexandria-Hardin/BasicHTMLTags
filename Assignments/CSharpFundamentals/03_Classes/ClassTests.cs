using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Classes
{
    [TestClass]
    public class VehicleTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            VehicleType typeOfVehicle = VehicleType.Boat;
            Vehicle myCar = new Vehicle();
            myCar.NumberOfTires = 4;
            Console.WriteLine(myCar.NumberOfTires);
            Vehicle moonLander = new Vehicle();
            //when you  do not initialize something it is null
            moonLander.Tires = false;

            int number = moonLander.BackSeats;

            Vehicle newCar = new Vehicle("Accord", 4, VehicleType.Car);

        }
        [global::Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void CalculatorTests()
        {
            Calculator calc = new Calculator();

            int seven = 7;
            int five = 5;

            int result = calc.Addition(seven, five);
        }

        [TestMethod]
        public void PersonTest()
        {
            Person simon = new Person("Frank", "Underwood");
            Person robert = new Person();

            simon.FirstName = "Simon";
            simon.LastName = "Pawlak";
            simon.DateOfBirth = new DateTime(1920, 07, 22);
            simon.DateOfBirth = new DateTime(1920, 05, 22);
            //simon.FullName = simon.FirstName + " " + simon.LastName;

            Person desmond = new Person();
            desmond.FirstName = "Desmond";

            //To use the constructor from person.cs you have to input the actual info here, not string firstName etc.
            Person amanda = new Person("Amanda", "Knight");
            //amanda.FullName = "Amanda Knight";
            //amanda.FullName = "Banana"
            //code runs to to bottom
            //so at the end here amanda would be equal to banana because we would be overiding the data

            Person happy = new Person("Happy", "Gilmore");
            //made happy the person
            happy.SayGoodMorning();
            //told happy what to do
            happy.SayGoodMorning("Jordan");
            //said who to direct the code to
            happy.SayGoodMorning(amanda);
            amanda.SayGoodMorning(desmond);
        }
    }
}