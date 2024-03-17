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
    public partial class WithdrawForm : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private int userId;
        private int accountId;

        public WithdrawForm()
        {
            InitializeComponent();
            server = "13.39.79.161";
            database = "bankapp";
            uid = "epita";
            password = "Secret@123";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }

        public WithdrawForm(int userId)
        {
            InitializeComponent();
            server = "13.39.79.161";
            database = "bankapp";
            uid = "epita";
            password = "Secret@123";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
            this.userId = userId;
            this.accountId = GetAccountId();
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            float withdrawAmount = GetWithdrawAmount();
            if (withdrawAmount == 0)
            {
                return;
            }
            float balance = GetBalance();
            if (withdrawAmount > balance)
            {
                MessageBox.Show("Insufficient balance, your current balance is " + balance);
                AddTransaction(withdrawAmount, "Failed");
                return;
            }
            float newBalance = balance - withdrawAmount;
            UpdateBalance(newBalance);
            AddTransaction(withdrawAmount, "Success");
            MessageBox.Show("Withdrawal successful, your new balance is " + newBalance);
            
        }

        private float GetWithdrawAmount()
        {
            float withdrawAmount;
            if (!float.TryParse(withdrawAmountTextBox.Text, out withdrawAmount))
            {
                MessageBox.Show("Please enter a valid amount");
                return 0;
            }
            return withdrawAmount;
        }

        private float GetBalance()
        {
            connection.Open();
            string query = "SELECT balance FROM Account WHERE idAccount=@accountId";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@accountId", this.accountId);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            float balance = reader.GetFloat("balance");
            reader.Close();
            connection.Close();

            return balance;
        }

        private void UpdateBalance(float newBalance)
        {
            connection.Open();
            string query = "UPDATE Account SET balance=@newBalance WHERE idAccount=@accountId";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@newBalance", newBalance);
            cmd.Parameters.AddWithValue("@accountId", this.accountId);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void AddTransaction(float withdrawAmount, string status)
        {
            connection.Open();
            string query = "INSERT INTO Transaction (idAccount, transactionTime, transactionType, transactionAmount, transactionStatus) VALUES (@accountId, @transactionTime, @transactionType, @transactionAmount, @transactionStatus)";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@accountId", this.accountId);
            cmd.Parameters.AddWithValue("@transactionTime", DateTime.Now);
            cmd.Parameters.AddWithValue("@transactionType", "Withdraw");
            cmd.Parameters.AddWithValue("@transactionAmount", withdrawAmount);
            //status = "Success" or "Failed"
            cmd.Parameters.AddWithValue("@transactionStatus", status);
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
