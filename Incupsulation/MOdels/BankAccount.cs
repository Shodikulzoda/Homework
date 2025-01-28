using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incupsulation.MOdels
{
    internal class BankAccount(string accnum,decimal bal)
    {

        private decimal balance = bal;
        public string AccountNumber { get; private set; } = accnum;
        //public BankAccount(string accnum,decimal baln)
        //{
        //    AccountNumber= accnum; 
        //    balance= baln;
        //}
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("summa doljen bit bolshe 0"); 
            }
            balance += amount;
        }

        public decimal GetBalance() { return balance; }
        public void WithDraw(decimal amount)
        {
            if (amount > balance)
            {
                throw new InvalidOperationException("nedostachono sredsva na scheta");

            }
        }

    }

}
