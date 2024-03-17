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
            miniStatementLabel = new Label();
            miniStatementDataGridView = new DataGridView();
            ((ISupportInitialize)miniStatementDataGridView).BeginInit();
            SuspendLayout();
            // 
            // miniStatementLabel
            // 
            miniStatementLabel.AutoSize = true;
            miniStatementLabel.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            miniStatementLabel.Location = new Point(424, 216);
            miniStatementLabel.Name = "miniStatementLabel";
            miniStatementLabel.Size = new Size(194, 31);
            miniStatementLabel.TabIndex = 0;
            miniStatementLabel.Text = "Mini Statement";
            // 
            // miniStatementDataGridView
            // 
            miniStatementDataGridView.Location = new Point(197, 310);
            miniStatementDataGridView.Name = "miniStatementDataGridView";
            miniStatementDataGridView.TabIndex = 1;
            miniStatementDataGridView.ReadOnly = true;
            miniStatementDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            miniStatementDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            miniStatementDataGridView.AllowUserToAddRows = false;
            miniStatementDataGridView.AllowUserToDeleteRows = false;
            miniStatementDataGridView.Size = new Size(800, 500);

            // 
            // MiniStatementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 1061);
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

        private Label miniStatementLabel;
        private DataGridView miniStatementDataGridView;
    }
}