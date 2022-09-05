using BankEncapsulationExercise;
using System;
using System.Collections.Generic;

namespace BankEncapsulaption
{

    class program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();

            account.Deposit(400);

            account.GetBalance(50);
        }
    }
}