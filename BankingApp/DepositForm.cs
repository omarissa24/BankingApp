using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BankingApp
{
    public partial class DepositForm : Form
    {

        private MySqlConnection connection;
        private string? server;
        private string? database;
        private string? uid;
        private string? password;
        private int userId;
        private int accountId;


        public DepositForm()
        {
            InitializeComponent();
            // Reading from environment variables
            server = Environment.GetEnvironmentVariable("DB_SERVER");
            database = Environment.GetEnvironmentVariable("DB_DATABASE");
            uid = Environment.GetEnvironmentVariable("DB_UID");
            password = Environment.GetEnvironmentVariable("DB_PASSWORD");

            string connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";
            connection = new MySqlConnection(connectionString);
        }

        public DepositForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            // Reading from environment variables
            server = Environment.GetEnvironmentVariable("DB_SERVER");
            database = Environment.GetEnvironmentVariable("DB_DATABASE");
            uid = Environment.GetEnvironmentVariable("DB_UID");
            password = Environment.GetEnvironmentVariable("DB_PASSWORD");

            string connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";
            connection = new MySqlConnection(connectionString);
            this.accountId = GetAccountId();

        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            // Get deposit amount
            float depositAmount = GetDepositAmount();
            if (depositAmount == 0)
            {
                return;
            }

            // Get current balance
            float balance = GetBalance();

            // Update balance
            float newBalance = balance + depositAmount;

            UpdateBalance(newBalance);

            // Add transaction
            AddTransaction(depositAmount);

            MessageBox.Show("Deposit successful. New balance: " + newBalance);
        }

        private float GetDepositAmount()
        {
            float depositAmount = 0;
            if (float.TryParse(depositAmountTextBox.Text, out depositAmount))
            {
                return depositAmount;
            }
            else
            {
                MessageBox.Show("Please enter a valid amount.");
                return 0;
            }
        }

        private float GetBalance()
        {
            connection.Open();
            string query = "SELECT Balance FROM Account WHERE accountUser=@userId";
            
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@userId", this.userId);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            float balance = reader.GetFloat("Balance");
            reader.Close();
            connection.Close();

            return balance;
        }

        private void UpdateBalance(float newBalance)
        {
            connection.Open();
            string query = "UPDATE Account SET Balance=@newBalance WHERE accountUser=@userId";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@newBalance", newBalance);
            cmd.Parameters.AddWithValue("@userId", this.userId);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void AddTransaction(float depositAmount)
        {
            connection.Open();
            string query = "INSERT INTO Transaction (idAccount, transactionTime, transactionType, transactionAmount, transactionStatus) VALUES (@idAccount, @transactionTime, @transactionType, @transactionAmount, @transactionStatus)";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@idAccount", this.accountId);
            cmd.Parameters.AddWithValue("@transactionTime", DateTime.Now);
            cmd.Parameters.AddWithValue("@transactionType", "Deposit");
            cmd.Parameters.AddWithValue("@transactionAmount", depositAmount);
            cmd.Parameters.AddWithValue("@transactionStatus", "Success");
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private int GetAccountId()
        {
            connection.Open();
            string query = "SELECT idAccount FROM Account WHERE accountUser=@userId";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@userId", this.userId);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int accountId = reader.GetInt32("idAccount");
            reader.Close();
            connection.Close();

            return accountId;
        }
    }
}
