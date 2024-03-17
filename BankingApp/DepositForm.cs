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

        private DBService dbService = new DBService();
        private int userId;
        private int accountId;


        public DepositForm()
        {
            InitializeComponent();
        }

        public DepositForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            this.accountId = dbService.GetAccountId(this.userId);

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
            float balance = dbService.GetBalance(this.userId);

            // Update balance
            float newBalance = balance + depositAmount;

            dbService.UpdateBalance(this.userId, newBalance);

            // Add transaction
            dbService.AddTransaction(this.accountId, depositAmount, "Deposit", "Success");

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
    }
}
