using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BankingApp
{
    public partial class LoginForm : Form
    {
        private DBService dbService;

        public LoginForm()
        {
            InitializeComponent();
            dbService = new DBService();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string pin = pinTextBox.Text;
            try
            {
                int userId = dbService.Login(username, pin);

                if (userId != 0)
                {
                    MainForm mainForm = new MainForm(userId);
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or PIN.");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}");
            }
            finally
            {

            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Signup signupForm = new Signup();
            signupForm.Show();
        }
    }
}
