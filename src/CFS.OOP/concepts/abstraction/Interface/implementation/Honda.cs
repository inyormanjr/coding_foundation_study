using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFS.OOP.concepts.abstraction.Interface.implementation
{
    public class Honda : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Honda is driving");
        }

        public void Reverse()
        {
            Console.WriteLine("Honda is reversing");
        }

        public void Stop()
        {
            Console.WriteLine("Honda is stopping");
        }


        //This method is not included in the interface
        public void HondaSpecificMethod()
        {
            Console.WriteLine("Honda specific method");
        }
    }
}