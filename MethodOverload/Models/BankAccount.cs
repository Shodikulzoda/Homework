using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload.Models
{
    internal class BankAccount
    {
        public int AccountNumber;
        public string? AccountHolder;
        private int balance;
        public int Balance
        {
            get
            {
                return balance;
            }
            set
            { 
                if (value < 0)
                {
                    Console.WriteLine("null");
                    value = 0;
                }
                balance = value;
            } }

        public BankAccount(int accnum,string acchold,int bal)
        {
            //Console.WriteLine($"Accountnumber {AccountNumber} AccountHolder {AccountHolder} Balance {Balance}");
            AccountNumber= accnum;
            AccountHolder = acchold;
            balance = bal;
        }
        public void Deposit(decimal amount)
        {
            Balance += Convert.ToInt32(amount);
        }
        public void Withdraw(decimal amount)
        {
            if(amount>=Balance)
            {

            Balance -= Convert.ToInt32(amount);
            }
        }
        public void GetAccountInfo()
        {
            Console.WriteLine($"Accountnumber {AccountNumber} AccountHolder {AccountHolder} Balance {Balance}");
        }
    }

}
