using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFS.OOP.concepts.Inheritance
{
    public class InheritnaceSample
    {

        //Inheritance is a mechanism in which one object acquires all the properties and behaviors of a parent object.
        //It is an important part of OOPs(Object Oriented programming system).
        // The idea behind inheritance in C# is that you can create new classes that are built upon existing classes.
        // When you inherit from an existing class, you can reuse methods and fields of the parent class.
        // Moreover, you can add new methods and fields in your current class also.
        // Resuability is a very important feature of OOPs.

        public class Vehicle {

            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            private bool IsStarted { get; set; }

            public Vehicle(string make, string model, int year)
            {
                Make = make;
                Model = model;
                Year = year;
                IsStarted = false;
            }

            public bool CheckIfStarted()
            {
                return IsStarted;
            }

            public bool Start()
            {
                Console.WriteLine("Vehicle has started");
                return IsStarted ? false : IsStarted = true;
            }


            public bool Accelerate()
            {
                Console.WriteLine("Vehicle is accelerating");
                return IsStarted ? true : false;
            }

            public bool Stop()
            {
                Console.WriteLine("Vehicle has stopped");
                return IsStarted ? IsStarted = false : false;
            }

        }

        public class Car : Vehicle
        {
            public Car(string make, string model, int year) : base(make, model, year)
            {
            }

            public bool Reverse()
            {
                Console.WriteLine("Car is reversing");
                return CheckIfStarted() ? true : false;
            }

        }

        public class Motorycle : Vehicle
        {
            public Motorycle(string make, string model, int year) : base(make, model, year)
            {
            }

            public bool Wheelie()
            {
                Console.WriteLine("Motorcycle is doing a wheelie");
                return true;
            }
        }
    }
}