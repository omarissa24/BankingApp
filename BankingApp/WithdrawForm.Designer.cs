namespace BankingApp
{
    partial class WithdrawForm
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
            withdrawAmountLabel = new Label();
            withdrawAmountTextBox = new TextBox();
            withdrawButton = new Button();
            SuspendLayout();

            //
            // withdrawAmountLabel
            //

            withdrawAmountLabel.AutoSize = true;
            withdrawAmountLabel.Location = new Point(424, 216);
            withdrawAmountLabel.Name = "withdrawAmountLabel";
            withdrawAmountLabel.Size = new Size(236, 41);
            withdrawAmountLabel.TabIndex = 0;
            withdrawAmountLabel.Text = "Withdraw Amount";
            //
            // withdrawAmountTextBox
            //
            withdrawAmountTextBox.Location = new Point(361, 331);
            withdrawAmountTextBox.Name = "withdrawAmountTextBox";
            withdrawAmountTextBox.Size = new Size(358, 47);
            withdrawAmountTextBox.TabIndex = 1;

            //
            // withdrawButton
            //

            withdrawButton.BackColor = Color.Blue;
            withdrawButton.ForeColor = Color.White;
            withdrawButton.Location = new Point(410, 470);
            withdrawButton.Name = "withdrawButton";
            withdrawButton.Size = new Size(250, 105);
            withdrawButton.TabIndex = 2;
            withdrawButton.Text = "Withdraw";
            withdrawButton.UseVisualStyleBackColor = false;
            withdrawButton.Click += withdrawButton_Click;
            // 
            // WithdrawForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 784);
            Margin = new Padding(1, 1, 1, 1);
            Name = "WithdrawForm";
            Text = "WithdrawForm";
            Controls.Add(withdrawAmountLabel);
            Controls.Add(withdrawAmountTextBox);
            Controls.Add(withdrawButton);
            ResumeLayout(false);
            PerformLayout();
        }

        private Label withdrawAmountLabel;
        private TextBox withdrawAmountTextBox;
        private Button withdrawButton;

        #endregion
    }
}