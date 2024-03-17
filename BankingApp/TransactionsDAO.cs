using MySql.Data.MySqlClient;
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

        string connectionString = "datasource=localhost;port=3306;username=root;password=;database=banking_app";

        public List<Transaction> getAllTransactions() {
            // Starts with an empty list 
            List<Transaction> transactions = new List<Transaction>();

            // Connecting to Mysql server
            MySqlConnection connection = new MySqlConnection (connectionString);
            connection.Open();

            // SQL Query for feting the data needed
            string query = "SELECT * FROM transaction";
            MySqlCommand command = new MySqlCommand(query, connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Transaction transaction = new Transaction
                    {
                        transactionId = reader.GetInt32(0),
                        accountId = reader.GetInt32(1),
                        transactionTime = reader.GetDateTime(2),
                        transactionType = reader.GetString(3),
                        transactionAmount = reader.GetFloat(4),
                        transactionStatus = reader.GetString(5)
                    };

                    transactions.Add(transaction);
                }
            }
            connection.Close();

            return transactions;

        }
    }
}
