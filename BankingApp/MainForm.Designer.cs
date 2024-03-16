using System.Windows.Forms;

namespace BankingApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            withdrawButton = new Button();
            depositButton = new Button();
            viewBalanceButton = new Button();
            miniStatementButton = new Button();
            logoutButton = new Button();
            SuspendLayout();
            // 
            // withdrawButton
            // 
            withdrawButton.Location = new Point(622, 320);
            withdrawButton.Name = "withdrawButton";
            withdrawButton.Size = new Size(394, 134);
            withdrawButton.TabIndex = 0;
            withdrawButton.Text = "Withdraw";
            withdrawButton.UseVisualStyleBackColor = true;
            withdrawButton.Click += withdrawButton_Click;
            // 
            // depositButton
            // 
            depositButton.Location = new Point(80, 320);
            depositButton.Name = "depositButton";
            depositButton.Size = new Size(445, 134);
            depositButton.TabIndex = 1;
            depositButton.Text = "Deposit";
            depositButton.UseVisualStyleBackColor = true;
            depositButton.Click += depositButton_Click;
            // 
            // viewBalanceButton
            // 
            viewBalanceButton.Location = new Point(80, 134);
            viewBalanceButton.Name = "viewBalanceButton";
            viewBalanceButton.Size = new Size(445, 129);
            viewBalanceButton.TabIndex = 2;
            viewBalanceButton.Text = "View Balance";
            viewBalanceButton.UseVisualStyleBackColor = true;
            viewBalanceButton.Click += viewBalanceButton_Click;
            // 
            // miniStatementButton
            // 
            miniStatementButton.Location = new Point(622, 134);
            miniStatementButton.Name = "miniStatementButton";
            miniStatementButton.Size = new Size(394, 129);
            miniStatementButton.TabIndex = 3;
            miniStatementButton.Text = "Mini Statement";
            miniStatementButton.UseVisualStyleBackColor = true;
            miniStatementButton.Click += miniStatementButton_Click;
            // 
            // logoutButton
            // 
            logoutButton.BackColor = Color.Red;
            logoutButton.ForeColor = Color.White;
            logoutButton.Location = new Point(405, 541);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(254, 92);
            logoutButton.TabIndex = 4;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += logoutButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 671);
            Controls.Add(logoutButton);
            Controls.Add(miniStatementButton);
            Controls.Add(viewBalanceButton);
            Controls.Add(depositButton);
            Controls.Add(withdrawButton);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }
        #endregion

        private Button withdrawButton;
        private Button depositButton;
        private Button viewBalanceButton;
        private Button miniStatementButton;
        private Button logoutButton;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}