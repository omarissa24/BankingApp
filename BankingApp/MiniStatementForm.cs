using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.TimeZoneInfo;

namespace BankingApp
{
    public partial class MiniStatementForm : Form
    {
        private MySqlConnection connection;
        private string? server;
        private string? database;
        private string? uid;
        private string? password;
        private int userId;
        private int accountId;

        public MiniStatementForm()
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

        public MiniStatementForm(int userId)
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

        private void MiniStatementForm_Load(object sender, EventArgs e)
        {
            connection.Open();
            string query = "SELECT transactionType AS \"Transaction Type\", " +
                "transactionAmount AS \"Transaction Amount\", transactionTime AS \"Transaction Time\", " +
                "transactionStatus AS \"Transaction Status\" FROM Transaction " +
                "WHERE idAccount=@accountId " +
                "ORDER BY transactionTime DESC";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@accountId", this.accountId);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            miniStatementDataGridView.DataSource = table;
            connection.Close();
        }

        private List<string> GetMiniStatement()
        {
            connection.Open();
            string query = "SELECT * FROM Transaction WHERE idAccount=@accountId";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@accountId", this.accountId);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<string> miniStatement = new List<string>();
            while (reader.Read())
            {
                string transaction = reader.GetString("transactionType") + " " + reader.GetFloat("transactionAmount") + " " + reader.GetDateTime("transactionDate") + " " + reader.GetString("transactionStatus");
                miniStatement.Add(transaction.Trim());
            }
            reader.Close();
            connection.Close();
            return miniStatement;
        }
    }
}
