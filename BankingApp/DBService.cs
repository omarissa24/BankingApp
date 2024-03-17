using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    internal class DBService
    {
        private MySqlConnection connection;
        private string? server;
        private string? database;
        private string? uid;
        private string? password;

        public DBService()
        {
            // Reading from environment variables
            server = Environment.GetEnvironmentVariable("DB_SERVER");
            database = Environment.GetEnvironmentVariable("DB_DATABASE");
            uid = Environment.GetEnvironmentVariable("DB_UID");
            password = Environment.GetEnvironmentVariable("DB_PASSWORD");

            string connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";
            connection = new MySqlConnection(connectionString);
        }

        public int Login(string username, string pin)
        {
            pin = EncodePassword(pin);
            string query = $"SELECT UserId FROM User WHERE Username = '{username}' AND Pin = '{pin}'";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            int userId = 0;
            while (reader.Read())
            {
                userId = reader.GetInt32(0);
            }
            connection.Close();
            return userId;
        }

        public int GetAccountId(int userId)
        {
            string query = $"SELECT idAccount FROM Account WHERE accountUser = {userId}";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            int accountId = 0;
            while (reader.Read())
            {
                accountId = reader.GetInt32(0);
            }
            connection.Close();
            return accountId;
        }

        public float GetBalance(int userId)
        {
            string query = $"SELECT Balance FROM Account WHERE accountUser = {userId}";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            float balance = 0;
            while (reader.Read())
            {
                balance = reader.GetFloat(0);
            }
            connection.Close();
            return balance;
        }

        public void UpdateBalance(int userId, float newBalance)
        {
            string query = $"UPDATE Account SET Balance = {newBalance} WHERE accountUser = {userId}";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }


        public void AddTransaction(int accountId, float amount,string type, string status = "Success")
        {
            //string query = $"INSERT INTO Transaction (idAccount, transactionTime, transactionType, transactionAmount, transactionStatus) VALUES ({accountId}, {DateTime.Now}, {type}, {amount}, {status})";
            string query = "INSERT INTO Transaction (idAccount, transactionTime, transactionType, transactionAmount, transactionStatus) " +
                "VALUES (@accountId, @transactionTime, @transactionType, @transactionAmount, @transactionStatus)";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@accountId", accountId);
            cmd.Parameters.AddWithValue("@transactionTime", DateTime.Now);
            cmd.Parameters.AddWithValue("@transactionType", type);
            cmd.Parameters.AddWithValue("@transactionAmount", amount);
            cmd.Parameters.AddWithValue("@transactionStatus", status);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public DataTable GetTransactionsAsDataTable(int accountId)
        {
            connection.Open();
            string query = "SELECT transactionType AS \"Transaction Type\", " +
                "transactionAmount AS \"Transaction Amount\", transactionTime AS \"Transaction Time\", " +
                "transactionStatus AS \"Transaction Status\" FROM Transaction " +
                "WHERE idAccount=@accountId " +
                "ORDER BY transactionTime DESC";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@accountId", accountId);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.Close();
            return table;
        }

        public DataTable GetSearchedTransactionsAsDataTable(int accountId, string searchTerm)
        {
            connection.Open();
            string query = "SELECT transactionType AS \"Transaction Type\", " +
                "transactionAmount AS \"Transaction Amount\", transactionTime AS \"Transaction Time\", " +
                "transactionStatus AS \"Transaction Status\" FROM Transaction " +
                "WHERE idAccount=@accountId " +
                "AND transactionType LIKE @search " +
                "ORDER BY transactionTime DESC";

            string searchWildCard = "%" + searchTerm + "%";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@accountId", accountId);
            cmd.Parameters.AddWithValue("@search", searchWildCard);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.Close();
            return table;
        }
   
        public DataTable GetDateFilteredTransactionsAsDataTable(int accountId, string transactionDate)
        {
            connection.Open();
            string query = "SELECT transactionType AS \"Transaction Type\", " +
                "transactionAmount AS \"Transaction Amount\", transactionTime AS \"Transaction Time\", " +
                "transactionStatus AS \"Transaction Status\" FROM Transaction " +
                "WHERE idAccount=@accountId " +
                "AND DATE(transactionTime) = @transactionDate " +
                "ORDER BY transactionTime DESC";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@accountId", accountId);
            cmd.Parameters.AddWithValue("@transactionDate", transactionDate);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.Close();
            return table;
        }

        private static string EncodePassword(string password)
        {
            byte[] data = System.Text.Encoding.Unicode.GetBytes(password);
            byte[] result = System.Security.Cryptography.SHA256.HashData(data);
            return Convert.ToBase64String(result);
        }

        public int CreateUser(string username, string pin)
        {
            string query = "INSERT INTO User (Username, Pin) VALUES (@username, @pin)";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@pin", EncodePassword(pin));
            cmd.ExecuteNonQuery();
            connection.Close();
            int userId = 0;
            userId = GetUserId(username);
            return userId;
        }

        public void CreateAccount(int userId)
        {
            string query = "INSERT INTO Account (accountUser, Balance) VALUES (@userId, 0)";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@userId", userId);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public int GetUserId(string username)
        {
            string query = $"SELECT UserId FROM User WHERE Username = '{username}'";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            int userId = 0;
            while (reader.Read())
            {
                userId = reader.GetInt32(0);
            }
            connection.Close();
            return userId;
        }
    }
}
