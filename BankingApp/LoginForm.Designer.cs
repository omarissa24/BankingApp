namespace BankingApp
{
    partial class LoginForm
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
            usernameTextBox = new TextBox();
            pinTextBox = new TextBox();
            loginButton = new Button();
            bankingAppTitle = new Label();
            usernameTextBoxLabel = new Label();
            pinTextBoxLabel = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(400, 200);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(300, 47);
            usernameTextBox.TabIndex = 0;
            usernameTextBox.TextChanged += usernameTextBox_TextChanged;
            // 
            // pinTextBox
            // 
            pinTextBox.Location = new Point(400, 300);
            pinTextBox.Name = "pinTextBox";
            pinTextBox.PasswordChar = '*';
            pinTextBox.Size = new Size(300, 47);
            pinTextBox.TabIndex = 1;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.Blue;
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(400, 400);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(300, 70);
            loginButton.TabIndex = 2;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // bankingAppTitle
            // 
            bankingAppTitle.AutoSize = true;
            bankingAppTitle.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bankingAppTitle.Location = new Point(350, 50);
            bankingAppTitle.Name = "bankingAppTitle";
            bankingAppTitle.Size = new Size(410, 76);
            bankingAppTitle.TabIndex = 0;
            bankingAppTitle.Text = "Banking App";
            // 
            // usernameTextBoxLabel
            // 
            usernameTextBoxLabel.AutoSize = true;
            usernameTextBoxLabel.Location = new Point(200, 200);
            usernameTextBoxLabel.Name = "usernameTextBoxLabel";
            usernameTextBoxLabel.Size = new Size(152, 41);
            usernameTextBoxLabel.TabIndex = 0;
            usernameTextBoxLabel.Text = "Username";
            // 
            // pinTextBoxLabel
            // 
            pinTextBoxLabel.AutoSize = true;
            pinTextBoxLabel.Location = new Point(200, 300);
            pinTextBoxLabel.Name = "pinTextBoxLabel";
            pinTextBoxLabel.Size = new Size(65, 41);
            pinTextBoxLabel.TabIndex = 1;
            pinTextBoxLabel.Text = "PIN";
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.ForeColor = Color.White;
            button1.Location = new Point(400, 505);
            button1.Name = "button1";
            button1.Size = new Size(300, 58);
            button1.TabIndex = 3;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 647);
            Controls.Add(button1);
            Controls.Add(bankingAppTitle);
            Controls.Add(usernameTextBoxLabel);
            Controls.Add(pinTextBoxLabel);
            Controls.Add(usernameTextBox);
            Controls.Add(pinTextBox);
            Controls.Add(loginButton);
            Name = "LoginForm";
            Text = "Form1";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTextBox;
        private TextBox pinTextBox;
        private Button loginButton;
        private Label bankingAppTitle;
        private Label usernameTextBoxLabel;
        private Label pinTextBoxLabel;
        private Button button1;
    }
}