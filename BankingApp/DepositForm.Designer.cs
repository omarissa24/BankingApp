namespace BankingApp
{
    partial class DepositForm
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
            depositAmountLabel = new Label();
            depositAmountTextBox = new TextBox();
            depositButton = new Button();
            SuspendLayout();
            // 
            // depositAmountLabel
            // 
            depositAmountLabel.AutoSize = true;
            depositAmountLabel.Location = new Point(424, 216);
            depositAmountLabel.Name = "depositAmountLabel";
            depositAmountLabel.Size = new Size(236, 41);
            depositAmountLabel.TabIndex = 0;
            depositAmountLabel.Text = "Deposit Amount";
            // 
            // depositAmountTextBox
            // 
            depositAmountTextBox.Location = new Point(361, 331);
            depositAmountTextBox.Name = "depositAmountTextBox";
            depositAmountTextBox.Size = new Size(358, 47);
            depositAmountTextBox.TabIndex = 1;
            // 
            // depositButton
            // 
            depositButton.BackColor = Color.Blue;
            depositButton.ForeColor = Color.White;
            depositButton.Location = new Point(410, 470);
            depositButton.Name = "depositButton";
            depositButton.Size = new Size(250, 105);
            depositButton.TabIndex = 2;
            depositButton.Text = "Deposit";
            depositButton.UseVisualStyleBackColor = false;
            depositButton.Click += depositButton_Click;
            // 
            // DepositForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 784);
            Controls.Add(depositAmountLabel);
            Controls.Add(depositAmountTextBox);
            Controls.Add(depositButton);
            Name = "DepositForm";
            Text = "DepositForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label depositAmountLabel;
        private TextBox depositAmountTextBox;
        private Button depositButton;
    }
}