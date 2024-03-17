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
        private DBService dbService = new DBService();
        private int userId;
        private int accountId;

        public WithdrawForm()
        {
            InitializeComponent();
        }

        public WithdrawForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            this.accountId = dbService.GetAccountId(this.userId);
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            float withdrawAmount = GetWithdrawAmount();
            if (withdrawAmount == 0)
            {
                return;
            }
            float balance = dbService.GetBalance(this.userId);
            if (withdrawAmount > balance)
            {
                MessageBox.Show("Insufficient balance, your current balance is " + balance);
                dbService.AddTransaction(this.accountId, withdrawAmount, "Withdraw", "Failed");
                return;
            }
            float newBalance = balance - withdrawAmount;
            dbService.UpdateBalance(this.userId, newBalance);
            dbService.AddTransaction(this.accountId, withdrawAmount, "Withdraw", "Success");
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
    }
}
