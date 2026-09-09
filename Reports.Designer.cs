namespace KhayelitshaCommunityLibrary
{
    partial class Reports
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
            btnBack = new Button();
            lblTitle = new Label();
            lblLearner = new Label();
            pnlTitle = new Panel();
            gbxSelect = new GroupBox();
            gbxResults = new GroupBox();
            rbOverdue = new RadioButton();
            rbSummary = new RadioButton();
            rbPopular = new RadioButton();
            rbInventory = new RadioButton();
            dgvResults = new DataGridView();
            btnPrint = new Button();
            btnExport = new Button();
            btnGenerate = new Button();
            pnlTitle.SuspendLayout();
            gbxSelect.SuspendLayout();
            gbxResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.DarkSlateGray;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.Control;
            btnBack.Location = new Point(745, 26);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 30);
            btnBack.TabIndex = 19;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.Control;
            lblTitle.Location = new Point(12, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(430, 38);
            lblTitle.TabIndex = 16;
            lblTitle.Text = "Khayelitsha Community Library";
            // 
            // lblLearner
            // 
            lblLearner.AutoSize = true;
            lblLearner.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLearner.ForeColor = SystemColors.Control;
            lblLearner.Location = new Point(448, 36);
            lblLearner.Name = "lblLearner";
            lblLearner.Size = new Size(183, 20);
            lblLearner.TabIndex = 17;
            lblLearner.Text = "Amy-Lee Baker (20240116)";
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.Teal;
            pnlTitle.Controls.Add(btnBack);
            pnlTitle.Controls.Add(lblTitle);
            pnlTitle.Controls.Add(lblLearner);
            pnlTitle.Location = new Point(0, 1);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(832, 75);
            pnlTitle.TabIndex = 1;
            // 
            // gbxSelect
            // 
            gbxSelect.Controls.Add(btnGenerate);
            gbxSelect.Controls.Add(rbInventory);
            gbxSelect.Controls.Add(rbPopular);
            gbxSelect.Controls.Add(rbSummary);
            gbxSelect.Controls.Add(rbOverdue);
            gbxSelect.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxSelect.Location = new Point(12, 91);
            gbxSelect.Name = "gbxSelect";
            gbxSelect.Size = new Size(808, 125);
            gbxSelect.TabIndex = 20;
            gbxSelect.TabStop = false;
            gbxSelect.Text = "Select Report Type";
            // 
            // gbxResults
            // 
            gbxResults.Controls.Add(btnExport);
            gbxResults.Controls.Add(btnPrint);
            gbxResults.Controls.Add(dgvResults);
            gbxResults.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxResults.Location = new Point(12, 222);
            gbxResults.Name = "gbxResults";
            gbxResults.Size = new Size(808, 269);
            gbxResults.TabIndex = 21;
            gbxResults.TabStop = false;
            gbxResults.Text = "Report Results";
            // 
            // rbOverdue
            // 
            rbOverdue.AutoSize = true;
            rbOverdue.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbOverdue.Location = new Point(24, 29);
            rbOverdue.Name = "rbOverdue";
            rbOverdue.Size = new Size(166, 24);
            rbOverdue.TabIndex = 0;
            rbOverdue.TabStop = true;
            rbOverdue.Text = "Overdue Book Loans";
            rbOverdue.UseVisualStyleBackColor = true;
            // 
            // rbSummary
            // 
            rbSummary.AutoSize = true;
            rbSummary.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbSummary.Location = new Point(24, 59);
            rbSummary.Name = "rbSummary";
            rbSummary.Size = new Size(278, 24);
            rbSummary.TabIndex = 1;
            rbSummary.TabStop = true;
            rbSummary.Text = "Member Borrowing Activity Summary";
            rbSummary.UseVisualStyleBackColor = true;
            // 
            // rbPopular
            // 
            rbPopular.AutoSize = true;
            rbPopular.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbPopular.Location = new Point(372, 29);
            rbPopular.Name = "rbPopular";
            rbPopular.Size = new Size(245, 24);
            rbPopular.TabIndex = 2;
            rbPopular.TabStop = true;
            rbPopular.Text = "Most Popular Book Titles (Top 5)";
            rbPopular.UseVisualStyleBackColor = true;
            // 
            // rbInventory
            // 
            rbInventory.AutoSize = true;
            rbInventory.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbInventory.Location = new Point(372, 59);
            rbInventory.Name = "rbInventory";
            rbInventory.Size = new Size(187, 24);
            rbInventory.TabIndex = 3;
            rbInventory.TabStop = true;
            rbInventory.Text = "Current Inventory Status";
            rbInventory.UseVisualStyleBackColor = true;
            // 
            // dgvResults
            // 
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Location = new Point(24, 34);
            dgvResults.Name = "dgvResults";
            dgvResults.RowHeadersWidth = 51;
            dgvResults.Size = new Size(766, 173);
            dgvResults.TabIndex = 0;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.LightBlue;
            btnPrint.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrint.Location = new Point(567, 223);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(94, 29);
            btnPrint.TabIndex = 1;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.LightCoral;
            btnExport.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExport.Location = new Point(667, 223);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(123, 29);
            btnExport.TabIndex = 2;
            btnExport.Text = "Export to PDF";
            btnExport.UseVisualStyleBackColor = false;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.Khaki;
            btnGenerate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.Location = new Point(24, 89);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(766, 29);
            btnGenerate.TabIndex = 4;
            btnGenerate.Text = "Generate Report";
            btnGenerate.UseVisualStyleBackColor = false;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 503);
            Controls.Add(gbxResults);
            Controls.Add(gbxSelect);
            Controls.Add(pnlTitle);
            Name = "Reports";
            Text = "Reports";
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            gbxSelect.ResumeLayout(false);
            gbxSelect.PerformLayout();
            gbxResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBack;
        private Label lblTitle;
        private Label lblLearner;
        private Panel pnlTitle;
        private GroupBox gbxSelect;
        private RadioButton rbInventory;
        private RadioButton rbPopular;
        private RadioButton rbSummary;
        private RadioButton rbOverdue;
        private GroupBox gbxResults;
        private Button btnPrint;
        private DataGridView dgvResults;
        private Button btnExport;
        private Button btnGenerate;
    }
}