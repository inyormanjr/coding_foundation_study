using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFS.OOP.concepts.abstraction.AbstractClass
{
    public class AbstractionClass
    {

    
        public abstract class Car
        {
         
            public abstract void Drive();
            public abstract void Stop();
            public abstract void Reverse();
        }

        public class BMW: Car {
            public override void Drive()
            {
                Console.WriteLine("BMW is driving");
            }

            public override void Reverse()
            {
                Console.WriteLine("BMW is reversing");
            }

            public override void Stop()
            {
                Console.WriteLine("BMW is stopping");
            }

            public void BMWSpecificMethod()
            {
                Console.WriteLine("BMW specific method");
            }
        }
    }
}