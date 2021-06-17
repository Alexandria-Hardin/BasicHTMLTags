using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes
{
    public class Person
    {

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Person() { }


        //FirstName; LastName, FullName, Haircolor, ShoeSize, Age, DateofBirth, ID
        //Getter and Setter: Get and Set Methods

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //read only property (you can not store data here, only recieve)
        public string FullName
        {
            get
            {
                //string concatination
                string fullName = FirstName + " " + LastName;
                return fullName; 
            }
        }
        public string HairColor { get; set; }
        public int ShoeSize { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age
        {
            get
            {
                TimeSpan ageSpan = DateTime.Today - DateOfBirth;
                double totalAgeInYears = ageSpan.Days / 365.25;
                int years = Convert.ToInt32(Math.Floor(totalAgeInYears));
                return years;
            }
        }

        //Methods
        //Say Good Morning
        public void SayGoodMorning()
        {
            Console.WriteLine("Good Morning");
        }

        public void SayGoodMorning(string name)
        {
            Console.WriteLine($"Good Morning {name}");
        }

        public void SayGoodMorning(Person person)
        {
            Console.WriteLine($"Good Morning {person.FirstName}, my name is {FirstName}");
        }
    }
}
