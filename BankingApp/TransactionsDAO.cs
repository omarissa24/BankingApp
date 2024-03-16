using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BankingApp
{
    internal class TransactionsDAO
    {
        // Version 1 only contains fake data, no database connection
        public List<Transaction> transactions = new List<Transaction> ();
    }
}
