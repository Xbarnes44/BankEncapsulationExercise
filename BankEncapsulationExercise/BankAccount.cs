using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulationExercise
{
    public class BankAccount
    {
        private double Balance = 0;

        public void Deposit(double makeDeposit)
        {
            Balance += makeDeposit;  
        }

        public void GetBalance(double amount)
        {
            Balance = amount;
        }

    }
}
