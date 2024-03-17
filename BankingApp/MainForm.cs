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
    public partial class MainForm : Form
    {
        private int userId;
        public static float balance = 0;

        public MainForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        // Event handlers for the buttons
        private void withdrawButton_Click(object sender, EventArgs e)
        {
            WithdrawForm withdrawForm = new WithdrawForm(userId);
            withdrawForm.Show();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            DepositForm depositForm = new DepositForm(userId);
            depositForm.Show();
        }

        private void viewBalanceButton_Click(object sender, EventArgs e)
        {
            ViewBalanceForm viewBalanceForm = new ViewBalanceForm(userId);
            viewBalanceForm.Show();

        }

        private void miniStatementButton_Click(object sender, EventArgs e)
        {
            MiniStatementForm miniStatementForm = new MiniStatementForm(userId);
            
            miniStatementForm.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
