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
            textBox_search = new TextBox();
            button_search = new Button();
            dateTimePicker_transaction = new DateTimePicker();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_transactions).BeginInit();
            SuspendLayout();
            // 
            // button_back
            // 
            button_back.BackColor = Color.Red;
            button_back.Location = new Point(25, 26);
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
            // textBox_search
            // 
            textBox_search.Location = new Point(280, 26);
            textBox_search.Name = "textBox_search";
            textBox_search.PlaceholderText = "Search Transaction Type";
            textBox_search.Size = new Size(217, 23);
            textBox_search.TabIndex = 2;
            // 
            // button_search
            // 
            button_search.Location = new Point(503, 26);
            button_search.Name = "button_search";
            button_search.Size = new Size(75, 23);
            button_search.TabIndex = 3;
            button_search.Text = "Search";
            button_search.UseVisualStyleBackColor = true;
            button_search.Click += button_search_Click;
            // 
            // dateTimePicker_transaction
            // 
            dateTimePicker_transaction.Location = new Point(134, 26);
            dateTimePicker_transaction.Name = "dateTimePicker_transaction";
            dateTimePicker_transaction.Size = new Size(127, 23);
            dateTimePicker_transaction.TabIndex = 4;
            dateTimePicker_transaction.ValueChanged += dateTimePicker_transaction_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(346, 5);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // MiniStatementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 436);
            Controls.Add(label1);
            Controls.Add(dateTimePicker_transaction);
            Controls.Add(button_search);
            Controls.Add(textBox_search);
            Controls.Add(dataGridView_transactions);
            Controls.Add(button_back);
            Name = "MiniStatementForm";
            Text = "MiniStatementForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView_transactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_back;
        private DataGridView dataGridView_transactions;
        private TextBox textBox_search;
        private Button button_search;
        private DateTimePicker dateTimePicker_transaction;
        private Label label1;
    }
}