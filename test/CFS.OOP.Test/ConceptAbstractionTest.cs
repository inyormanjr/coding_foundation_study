using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CFS.OOP.concepts.abstraction.AbstractClass;
using CFS.OOP.concepts.abstraction.Interface;
using CFS.OOP.concepts.abstraction.Interface.implementation;
using Xunit;
using static CFS.OOP.concepts.abstraction.AbstractClass.AbstractionClass;

namespace CFS.OOP.Test
{
    public class ConceptAbstractionTest
    {
        [Fact]
        public void TestAbstractionClass()
        {
            //Arrange
            AbstractionClass ac = new AbstractionClass();
            BMW bmw = new BMW();


            //Act
            bmw.Drive();
            bmw.Reverse();
            bmw.Stop();

            //This method is not included in the abstract class
            bmw.BMWSpecificMethod();


            //Assert
            Assert.True(true);
        }

        [Fact]
        public void TestInterface()
        {
            //Arrange
            ICar honda = new Honda();

            //Act
            honda.Drive();
            honda.Reverse();
            honda.Stop();

            //This method is not included in the interface
            //honda.HondaSpecificMethod();
            //we cant access the method HondaSpecificMethod() because the interface ICar does not have it
            //we can only access the methods Drive(), Reverse() and Stop() because the interface ICar has it    

            //Assert
            Assert.True(true);
        }
    }
    
}