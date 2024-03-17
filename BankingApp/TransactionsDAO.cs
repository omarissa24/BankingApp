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

        public List<Transaction> getAllTransactions(int userId) {
            // Starts with an empty list 
            List<Transaction> transactions = new List<Transaction>();

            // Connecting to Mysql server
            MySqlConnection connection = new MySqlConnection (connectionString);
            connection.Open();

            // SQL Query for feting the data needed
            string query = "SELECT transactionTime,transactionType,transactionAmount ,transactionStatus " +
                "FROM transaction WHERE idAccount = @id";

            MySqlCommand command = new MySqlCommand(query, connection);

            command.Parameters.AddWithValue("@id", userId);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Transaction transaction = new Transaction
                    {
                        //transactionId = reader.GetInt32(0),
                        //accountId = reader.GetInt32(1),
                        transactionTime = reader.GetDateTime(0),
                        transactionType = reader.GetString(1),
                        transactionAmount = reader.GetFloat(2),
                        transactionStatus = reader.GetString(3)
                    };

                    transactions.Add(transaction);
                }
            }
            connection.Close();

            return transactions;

        }
        public List<Transaction> getSearchedTransactions(int userId,string searchTerm)
        {
            // Starts with an empty list 
            List<Transaction> transactions = new List<Transaction>();

            // Connecting to Mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // SQL Query for feting the data needed
            string query = "SELECT transactionTime, transactionType," +
                " transactionAmount, transactionStatus FROM transaction " +
                "WHERE idAccount = @id AND transactionType LIKE @search";

            string searchWildCard = "%" + searchTerm + "%";

            MySqlCommand command = new MySqlCommand(query, connection);

            command.Parameters.AddWithValue("@id", userId);
            command.Parameters.AddWithValue("@search", searchWildCard);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Transaction transaction = new Transaction
                    {
                        transactionTime = reader.GetDateTime(0),
                        transactionType = reader.GetString(1),
                        transactionAmount = reader.GetFloat(2),
                        transactionStatus = reader.GetString(3)
                    };

                    transactions.Add(transaction);
                }
            }
            connection.Close();

            return transactions;

        }
        public List<Transaction> getDateFilteredTransactions(int userId, string transactionDate)
        {
            // Starts with an empty list 
            List<Transaction> transactions = new List<Transaction>();

            // Connecting to Mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // SQL Query for feting the data needed
            string query = "SELECT transactionTime, transactionType," +
                " transactionAmount, transactionStatus FROM transaction " +
                "WHERE idAccount = @id AND DATE(transactionTime) = @transactionDate";
       
            MySqlCommand command = new MySqlCommand(query, connection);

            command.Parameters.AddWithValue("@id", userId);
            command.Parameters.AddWithValue("@transactionDate", transactionDate);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Transaction transaction = new Transaction
                    {
                        transactionTime = reader.GetDateTime(0),
                        transactionType = reader.GetString(1),
                        transactionAmount = reader.GetFloat(2),
                        transactionStatus = reader.GetString(3)
                    };

                    transactions.Add(transaction);
                }
            }
            connection.Close();

            return transactions;
        }
    }
}
