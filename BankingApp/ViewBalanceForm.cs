using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class ViewBalanceForm : Form
    {

        private int userId;
        private DBService dbService = new DBService();
        public ViewBalanceForm()
        {
            InitializeComponent();
        }

        public ViewBalanceForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            getBalance();
        }

        private void getBalance()
        {
            
            label1.Text = "Available Balance: " + dbService.GetBalance(this.userId);
            
        }
    }
}
