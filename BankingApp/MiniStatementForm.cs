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
        BindingSource transactionBindingSource = new BindingSource();
        public MiniStatementForm()
        {
            InitializeComponent();
        }

        public MiniStatementForm(int userId)
        {
            InitializeComponent();
            // Load user data and transactions.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TransactionsDAO dao = new TransactionsDAO();
            Transaction transaction_one = new Transaction
            {
                transactionId = 1,
                accountId = 1,
                transactionTime = DateTime.Now,
                transactionType = "Transfer",
                transactionAmount = 250.00f,
                transactionStatus = "Success"
            };
            Transaction transaction_two = new Transaction
            {
                transactionId = 1,
                accountId = 1,
                transactionTime = DateTime.Now,
                transactionType = "Withdrawal",
                transactionAmount = 50.00f,
                transactionStatus = "Success"
            };
            
            Transaction transaction_three = new Transaction
            {
                transactionId = 1,
                accountId = 1,
                transactionTime = DateTime.Now,
                transactionType = "Transfer",
                transactionAmount = 20.00f,
                transactionStatus = "Success"
            };

            dao.transactions.Add(transaction_one);
            dao.transactions.Add(transaction_two);
            dao.transactions.Add(transaction_three);

            // Connect the list to  the grid view 
            transactionBindingSource.DataSource = dao.transactions;

            dataGridView_transactions.DataSource = transactionBindingSource;

        }
    }
}
