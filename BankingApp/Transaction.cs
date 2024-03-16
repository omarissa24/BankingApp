using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    internal class Transaction
    {
        public int transactionId { get; set; }
        public int accountId { get; set; }
        public DateTime transactionTime { get; set; }
        public string transactionType { get; set; }
        public float transactionAmount { get; set; }
        public string transactionStatus { get; set; }

        // Add a list of transactions List<Tranaction> transactions

    }
}
