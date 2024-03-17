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
