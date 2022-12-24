using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanckAcount
{
     public class Transaction
    {
        public decimal amount { get; set; }
        public DateTime date {  get; set; }
        public string notes { get; set; }


        public Transaction(decimal amount, DateTime date, string notes)
        {
            this.amount = amount;
            this.date = date;
            this.notes = notes;
        }
    }
}
