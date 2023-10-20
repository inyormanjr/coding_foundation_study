using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFS.OOP.concepts.Encapsulation
{
    public class EncapsulationSample
    {
        //Encapsulation is the process of hiding the internal details of an object from the outside world.

        
        public class BankAccount {

            private double balance = 0;

            public void Deposit(double amount) {
                balance += amount;
            }

            public void Withraw(double amount) {
                balance -= amount;
            }

            public double GetBalance() {
                return balance;
            }
        }
       
    }
}