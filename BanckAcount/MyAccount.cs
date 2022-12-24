using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanckAcount
{
    public class MyAccount
    {
        public string Number { get; }
        public string Name { get; set; }
        public decimal Balance { get
            {
                decimal balance = 0;
                foreach(var item in Transactions)
                {
                    balance = balance + item.amount;
                }
                return balance;
                }
                }

        private List<Transaction> Transactions = new List<Transaction>();

        private static int initNumber = 1234567890;

        public MyAccount( string name)
        {
            Name = name;
            Number = initNumber.ToString();
            initNumber++;
        }

        public void MakeDip(decimal amount, DateTime date, string notes)
        {
            if(amount<= 0)
            {
                throw new ArgumentException(nameof(amount), "the amount is not acceptable!!");
            }

            var trans = new Transaction(amount, date, notes);
            Transactions.Add(trans);

        }

        public void MakeWithdrawl(decimal amount, DateTime date, string notes)
        {
            if(Balance - amount < 0)
            {
                throw new InvalidOperationException("you can not withdrawl this amount");

            }
            var trans = new Transaction(-amount, date, notes);
            Transactions.Add(trans);
        }
        
    }
}
