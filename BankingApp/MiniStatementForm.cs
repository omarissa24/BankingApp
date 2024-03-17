using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
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
        private DBService dbService = new DBService();
        private int userId;
        private int accountId;

        public MiniStatementForm(int userId)
        {
            this.userId = userId;
            this.accountId = dbService.GetAccountId(this.userId);
            InitializeComponent();
        }

        private void MiniStatementForm_Load(object sender, EventArgs e)
        {
            miniStatementDataGridView.DataSource = dbService.GetTransactionsAsDataTable(this.accountId);
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            string searchTerm = textBox_search.Text;

            miniStatementDataGridView.DataSource = dbService.GetSearchedTransactionsAsDataTable(this.accountId, searchTerm);
        }

        private void dateTimePicker_transaction_ValueChanged(object sender, EventArgs e)
        {
            // Get filtered date
            DateTime filterTransactionDateTime = dateTimePicker_transaction.Value;

            // Format date to db date format
            string transactionDate = filterTransactionDateTime.ToString("yyyy-MM-dd");

            miniStatementDataGridView.DataSource = dbService.GetDateFilteredTransactionsAsDataTable(this.accountId, transactionDate);
        }
    }
}
