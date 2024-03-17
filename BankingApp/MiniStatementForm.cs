using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class MiniStatementForm : Form
    {
        int userId;
        BindingSource transactionBindingSource = new BindingSource();
        public MiniStatementForm()
        {
            InitializeComponent();
        }

        public MiniStatementForm(int userId)
        {
            this.userId = userId;
            InitializeComponent();
            // Load user data and transactions.


        }

        private void button1_Click(object sender, EventArgs e)
        {
            TransactionsDAO transactionDAO = new TransactionsDAO();

            // Connect the list to  the grid view 
            transactionBindingSource.DataSource = transactionDAO.getAllTransactions(userId);

            dataGridView_transactions.DataSource = transactionBindingSource;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            string searchTerm = textBox_search.Text;

            TransactionsDAO transactionDAO = new TransactionsDAO();

            // Connect the list to  the grid view 
            transactionBindingSource.DataSource = transactionDAO.getSearchedTransactions(userId, searchTerm);

            dataGridView_transactions.DataSource = transactionBindingSource;
        }

        private void dateTimePicker_transaction_ValueChanged(object sender, EventArgs e)
        {
            // Get filtered date
            DateTime filterTransactionDateTime = dateTimePicker_transaction.Value;

            // Format date to db date format
            string transactionDate = filterTransactionDateTime.ToString("yyyy-MM-dd");

            TransactionsDAO transactionDAO = new TransactionsDAO();

            // Connect the list to  the grid view 
            transactionBindingSource.DataSource = transactionDAO.getDateFilteredTransactions(userId, transactionDate);
        }
    }
}
