namespace BankingApp
{
    partial class MiniStatementForm
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
            button_back = new Button();
            dataGridView_transactions = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_transactions).BeginInit();
            SuspendLayout();
            // 
            // button_back
            // 
            button_back.BackColor = Color.Red;
            button_back.Location = new Point(25, 25);
            button_back.Name = "button_back";
            button_back.Size = new Size(75, 23);
            button_back.TabIndex = 0;
            button_back.Text = "Back";
            button_back.UseVisualStyleBackColor = false;
            button_back.Click += button1_Click;
            // 
            // dataGridView_transactions
            // 
            dataGridView_transactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_transactions.Location = new Point(25, 75);
            dataGridView_transactions.Name = "dataGridView_transactions";
            dataGridView_transactions.Size = new Size(553, 349);
            dataGridView_transactions.TabIndex = 1;
            // 
            // MiniStatementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 436);
            Controls.Add(dataGridView_transactions);
            Controls.Add(button_back);
            Name = "MiniStatementForm";
            Text = "MiniStatementForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView_transactions).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button_back;
        private DataGridView dataGridView_transactions;
    }
}