using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes
{
    enum VehicleType { Car, Truck, Boat, Plane, Spaceship, Motorcycle };
    class Vehicle
    {
        //Fields

        //Constructors
        //type of method
        //access modifier
        //what is it for (return type)
        //parameters
        //body

        public Vehicle() { }

        public Vehicle(string model, int numberOfTires, VehicleType vehicleType) 
        {
            Model = model;
            NumberOfTires = numberOfTires;
            TypeOfVehicle = vehicleType;
        }

        //Properties

        //Property Signature

        // 1 Access modifier => by default internal. other options are public and private
        // 2 Type => the type that the property holds
        // 3 Name => the name of the property. these should be pasalcase.
        // pasalcase is when only the first char is uppercase
        // 4 => get and ser methods (getter and setter)
        //1     //2     //3     //4
        public int BackSeats { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public int NumberOfTires { get; set; }

        public bool Tires { get; set; }

        public VehicleType TypeOfVehicle { get; set; }

        //Methods
    }
}
