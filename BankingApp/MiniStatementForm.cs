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
            TransactionsDAO transactionDAO = new TransactionsDAO();
            

            // Connect the list to  the grid view 
            transactionBindingSource.DataSource = transactionDAO.getAllTransactions();

            dataGridView_transactions.DataSource = transactionBindingSource;

        }
    }
}
