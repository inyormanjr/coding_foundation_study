using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using static CFS.OOP.concepts.Inheritance.InheritnaceSample;

namespace CFS.OOP.Test
{
    public class ConceptInheritanceTest
    {
        [Fact]
        public void InheritanceTestBaseClass()
        {
            //Arrange
            Vehicle vehicle;
            //Act
            vehicle = new Vehicle("Default", "Default", 0000);
            //Assert
            Assert.Equal("Default", vehicle.Make);
            Assert.Equal("Default", vehicle.Model);
            Assert.Equal(0000, vehicle.Year);
        }


        [Fact]
        public void InheritanceTestCarDerivedClass()
        {
            //Arrange
            Car car;
            //Act
            car = new Car("Default", "Default", 0000);
            //Assert
            Assert.Equal("Default", car.Make);
            Assert.Equal("Default", car.Model);
            Assert.Equal(0000, car.Year);
        }

        [Fact]
        public void InheritanceTestMotorcyleDerivedClass() {
            //Arrange
            Motorycle motorycle;

            //Act
            motorycle = new Motorycle("Motorcycle", "Motorcycle", 1990);
            motorycle.Start();

            //Assert
            Assert.Equal("Motorcycle", motorycle.Make);
            Assert.Equal("Motorcycle", motorycle.Model);
            Assert.Equal(1990, motorycle.Year);
            Assert.True(motorycle.CheckIfStarted());
            Assert.True(motorycle.Wheelie());

        }



        [Fact] 

        public void CheckCarCanAccelerate() {
            //Arrange
            Car car;
            //Act
            car = new Car("Default", "Default", 0000);
            car.Start();
            //Assert
            Assert.True(car.Accelerate());
        }

        [Fact]
        public void CheckCarMustNotAccelerateWhenStop() {
            //Arrange
            Car car;

            //Act
            car = new Car("Default", "Default", 0000);
            car.Start();
            car.Stop();

            //Assert
            Assert.False(car.Accelerate());
        }
    }
}