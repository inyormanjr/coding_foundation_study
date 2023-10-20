using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using static CFS.OOP.concepts.Polymorphism.PolymorphismSample;

namespace CFS.OOP.Test
{
    public class ConceptPolymorphismTest
    {
        [Fact]
        public void TestCircleShape()
        {
            //Arrange
            Circle circle;

            //Act
            circle = new Circle(5);

            //Assert
            Assert.Equal(78.53981633974483, circle.CalculateArea());
        }

        [Fact]
        public void TestTriangleShape()
        {
            //Arrange
            Triangle triangle;

            //Act
            triangle = new Triangle(5, 5);

            //Assert
            Assert.Equal(12.5, triangle.CalculateArea());
        }

        [Fact]
        public void TestRectangleShape()
        {
            //Arrange
            Rectangle rectangle;

            //Act
            rectangle = new Rectangle(5, 5);

            //Assert
            Assert.Equal(25, rectangle.CalculateArea());
        }
    }
}