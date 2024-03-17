namespace BankingApp
{
    partial class Signup
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
            signupButton = new Button();
            SuspendLayout();

            // add Banking App Title
            Label bankingAppTitle = new Label();
            bankingAppTitle.AutoSize = true;
            bankingAppTitle.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bankingAppTitle.Location = new Point(350, 50);
            bankingAppTitle.Name = "bankingAppTitle";
            bankingAppTitle.Size = new Size(300, 31);
            bankingAppTitle.TabIndex = 0;
            bankingAppTitle.Text = "Banking App";
            Controls.Add(bankingAppTitle);

            //add usernameTextBox label

            Label usernameTextBoxLabel = new Label();
            Label pinTextBoxLabel = new Label();

            usernameTextBoxLabel.AutoSize = true;
            usernameTextBoxLabel.Location = new Point(200, 200);
            usernameTextBoxLabel.Name = "usernameTextBoxLabel";
            usernameTextBoxLabel.Size = new Size(100, 23);
            usernameTextBoxLabel.TabIndex = 0;
            usernameTextBoxLabel.Text = "Username";
            Controls.Add(usernameTextBoxLabel);
            //add pinTextBox label
            pinTextBoxLabel.AutoSize = true;
            pinTextBoxLabel.Location = new Point(200, 300);
            pinTextBoxLabel.Name = "pinTextBoxLabel";
            pinTextBoxLabel.Size = new Size(100, 23);
            pinTextBoxLabel.TabIndex = 1;
            pinTextBoxLabel.Text = "PIN";
            Controls.Add(pinTextBoxLabel);
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(400, 200);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(300, 47);
            usernameTextBox.TabIndex = 0;
            // 
            // pinTextBox
            // 
            pinTextBox.Location = new Point(400, 300);
            pinTextBox.Name = "pinTextBox";
            pinTextBox.Size = new Size(300, 47);
            pinTextBox.TabIndex = 1;
            pinTextBox.PasswordChar = '*';
            // 
            // loginButton
            // 

            signupButton.Location = new Point(400, 400);
            signupButton.Name = "signupButton";
            signupButton.Size = new Size(300, 70);
            signupButton.TabIndex = 2;
            signupButton.Text = "Sign Up";
            signupButton.UseVisualStyleBackColor = true;
            signupButton.Click += signupButton_Click;
            signupButton.BackColor = Color.Blue;
            signupButton.ForeColor = Color.White;

            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 647);
            Controls.Add(usernameTextBox);
            Controls.Add(pinTextBox);
            Controls.Add(signupButton);
            Name = "SignupForm";
            Text = "SignupForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTextBox;
        private TextBox pinTextBox;
        private Button signupButton;
    }
}