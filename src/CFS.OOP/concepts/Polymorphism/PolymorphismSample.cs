using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFS.OOP.concepts.Polymorphism
{
    public class PolymorphismSample
    {

        //Polymorphism is the ability of an object to take on many forms.
        //The most common use of polymorphism in OOP occurs when a parent class reference is used to refer to a child class object.
        
        public abstract class Shape {
            public abstract double CalculateArea();
        }

        public class Circle: Shape {
            public double Radius;

            public Circle(double raidus) {
                Radius = raidus;
            }
            public override double CalculateArea()
            {
                return Math.PI * Radius * Radius;
            }
        }

        public class Triangle: Shape {
            public double Base;
            public double Height;

            public Triangle(double @base, double height) {
                Base = @base;
                Height = height;
            }
            public override double CalculateArea()
            {
                return 0.5 * Base * Height;
            }
        }

        public class Rectangle: Shape {
            public double Width;
            public double Height;

            public Rectangle(double width, double height) {
                Width = width;
                Height = height;
            }
            public override double CalculateArea()
            {
                return Width * Height;
            }
        }
    }
}