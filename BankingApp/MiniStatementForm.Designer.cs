using System.ComponentModel;

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
            textBox_search = new TextBox();
            button_search = new Button();
            dateTimePicker_transaction = new DateTimePicker();
            miniStatementLabel = new Label();
            miniStatementDataGridView = new DataGridView();
            ((ISupportInitialize)miniStatementDataGridView).BeginInit();
            SuspendLayout();
            // 
            // textBox_search
            // 
            textBox_search.Location = new Point(242, 65);
            textBox_search.Name = "textBox_search";
            textBox_search.PlaceholderText = "Search Transaction Type";
            textBox_search.Size = new Size(248, 23);
            textBox_search.TabIndex = 2;
            // 
            // button_search
            // 
            button_search.Location = new Point(499, 65);
            button_search.Name = "button_search";
            button_search.Size = new Size(82, 23);
            button_search.TabIndex = 3;
            button_search.Text = "Search";
            button_search.UseVisualStyleBackColor = true;
            button_search.Click += button_search_Click;
            // 
            // dateTimePicker_transaction
            // 
            dateTimePicker_transaction.Location = new Point(5, 66);
            dateTimePicker_transaction.Name = "dateTimePicker_transaction";
            dateTimePicker_transaction.Size = new Size(215, 23);
            dateTimePicker_transaction.TabIndex = 4;
            dateTimePicker_transaction.ValueChanged += dateTimePicker_transaction_ValueChanged;
            // 
            // miniStatementLabel
            // 
            miniStatementLabel.AutoSize = true;
            miniStatementLabel.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            miniStatementLabel.Location = new Point(174, 14);
            miniStatementLabel.Name = "miniStatementLabel";
            miniStatementLabel.Size = new Size(194, 31);
            miniStatementLabel.TabIndex = 0;
            miniStatementLabel.Text = "Mini Statement";
            // 
            // miniStatementDataGridView
            // 
            miniStatementDataGridView.AllowUserToAddRows = false;
            miniStatementDataGridView.AllowUserToDeleteRows = false;
            miniStatementDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            miniStatementDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            miniStatementDataGridView.Location = new Point(22, 107);
            miniStatementDataGridView.Name = "miniStatementDataGridView";
            miniStatementDataGridView.ReadOnly = true;
            miniStatementDataGridView.Size = new Size(547, 283);
            miniStatementDataGridView.TabIndex = 1;
            // 
            // MiniStatementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 404);
            Controls.Add(dateTimePicker_transaction);
            Controls.Add(button_search);
            Controls.Add(textBox_search);
            Controls.Add(miniStatementDataGridView);
            Controls.Add(miniStatementLabel);
            Name = "MiniStatementForm";
            Text = "MiniStatementForm";
            Load += MiniStatementForm_Load;
            ((ISupportInitialize)miniStatementDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_search;
        private Button button_search;
        private DateTimePicker dateTimePicker_transaction;
        private Label miniStatementLabel;
        private DataGridView miniStatementDataGridView;
    }
}