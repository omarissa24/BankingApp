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
        private DBService dbService = new DBService();
        private int userId;
        private int accountId;

        public MiniStatementForm()
        {
            InitializeComponent();
        }

        public MiniStatementForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            this.accountId = dbService.GetAccountId(this.userId);
        }

        private void MiniStatementForm_Load(object sender, EventArgs e)
        {
            miniStatementDataGridView.DataSource = dbService.GetTransactionsAsDataTable(this.accountId);
        }
    }
}
