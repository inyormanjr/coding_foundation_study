using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CFS.OOP.concepts.Encapsulation;
using Xunit;
using static CFS.OOP.concepts.Encapsulation.EncapsulationSample;

namespace CFS.OOP.Test
{
    public class ConceptEncapsulationTest
    {
        [Fact]
        public void BankAccountDepositAndCheckBalance_Correct_Amount()
        {
            //Arrange
            BankAccount bankAccount = new BankAccount();

            //Act
            bankAccount.Deposit(100);
            double balance = bankAccount.GetBalance();

            //Assert
            Assert.Equal(100, balance);
        }

        [Fact]
        public void BankAccountDepositAndCheckBalance_Incorrect_Amount()
        {
            //Arrange
            BankAccount bankAccount = new BankAccount();

            //Act
            bankAccount.Deposit(100);
            double balance = bankAccount.GetBalance();

            //Assert
            Assert.NotEqual(200, balance);
        }

        [Fact]
        public void BankAccountWithdrawAndCheckBalance_Correct_Amount()
        {
            //Arrange
            BankAccount bankAccount = new BankAccount();

            //Act
            bankAccount.Deposit(100);
            bankAccount.Withraw(50);
            double balance = bankAccount.GetBalance();

            //Assert
            Assert.Equal(50, balance);
        }
    }
}