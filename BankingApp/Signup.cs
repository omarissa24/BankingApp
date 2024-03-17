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
    public partial class Signup : Form
    {
        private DBService dbService;
        public Signup()
        {
            InitializeComponent();
            dbService = new DBService();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string pin = pinTextBox.Text;
            try
            {
                int userId = dbService.CreateUser(username, pin);
                if (userId != 0)
                {
                    dbService.CreateAccount(userId);
                    MessageBox.Show("Signup successful");
                }
                else
                {
                    MessageBox.Show("Signup failed");
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
    }
}
