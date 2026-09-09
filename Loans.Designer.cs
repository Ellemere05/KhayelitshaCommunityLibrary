namespace KhayelitshaCommunityLibrary
{
    partial class Loans
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
            pnlTitle = new Panel();
            btnBack = new Button();
            lblTitle = new Label();
            lblLearner = new Label();
            pnlLoans = new Panel();
            lblLoanTitle = new Label();
            btnIssueBook = new Button();
            dtpDueDate = new DateTimePicker();
            dtpLoanDate = new DateTimePicker();
            cmbStaff = new ComboBox();
            cmbBookCopy = new ComboBox();
            cmbMember = new ComboBox();
            lblDueDate = new Label();
            lblLoanDate = new Label();
            lblStaff = new Label();
            lblBookCopy = new Label();
            lblMember = new Label();
            pnlResults = new Panel();
            dgvLoanHistory = new DataGridView();
            cmbFilter = new ComboBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            lblFilter = new Label();
            lblLoanHistory = new Label();
            pnlReturns = new Panel();
            lblReturn = new Label();
            btnReturnBook = new Button();
            dtpReturnDate = new DateTimePicker();
            textBox2 = new TextBox();
            lblReturnDate = new Label();
            lblLoanID = new Label();
            pnlTitle.SuspendLayout();
            pnlLoans.SuspendLayout();
            pnlResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoanHistory).BeginInit();
            pnlReturns.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.Teal;
            pnlTitle.Controls.Add(btnBack);
            pnlTitle.Controls.Add(lblTitle);
            pnlTitle.Controls.Add(lblLearner);
            pnlTitle.Location = new Point(-3, 1);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(938, 75);
            pnlTitle.TabIndex = 2;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.DarkSlateGray;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.Control;
            btnBack.Location = new Point(845, 26);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 30);
            btnBack.TabIndex = 18;
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
            lblLearner.Location = new Point(439, 32);
            lblLearner.Name = "lblLearner";
            lblLearner.Size = new Size(183, 20);
            lblLearner.TabIndex = 17;
            lblLearner.Text = "Amy-Lee Baker (20240116)";
            // 
            // pnlLoans
            // 
            pnlLoans.Controls.Add(lblLoanTitle);
            pnlLoans.Controls.Add(btnIssueBook);
            pnlLoans.Controls.Add(dtpDueDate);
            pnlLoans.Controls.Add(dtpLoanDate);
            pnlLoans.Controls.Add(cmbStaff);
            pnlLoans.Controls.Add(cmbBookCopy);
            pnlLoans.Controls.Add(cmbMember);
            pnlLoans.Controls.Add(lblDueDate);
            pnlLoans.Controls.Add(lblLoanDate);
            pnlLoans.Controls.Add(lblStaff);
            pnlLoans.Controls.Add(lblBookCopy);
            pnlLoans.Controls.Add(lblMember);
            pnlLoans.Location = new Point(12, 91);
            pnlLoans.Name = "pnlLoans";
            pnlLoans.Size = new Size(544, 249);
            pnlLoans.TabIndex = 3;
            // 
            // lblLoanTitle
            // 
            lblLoanTitle.AutoSize = true;
            lblLoanTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoanTitle.Location = new Point(16, 12);
            lblLoanTitle.Name = "lblLoanTitle";
            lblLoanTitle.Size = new Size(91, 23);
            lblLoanTitle.TabIndex = 11;
            lblLoanTitle.Text = "Issue Loan";
            // 
            // btnIssueBook
            // 
            btnIssueBook.BackColor = Color.PaleGreen;
            btnIssueBook.Location = new Point(386, 186);
            btnIssueBook.Name = "btnIssueBook";
            btnIssueBook.Size = new Size(125, 40);
            btnIssueBook.TabIndex = 10;
            btnIssueBook.Text = "Issue Book";
            btnIssueBook.UseVisualStyleBackColor = false;
            // 
            // dtpDueDate
            // 
            dtpDueDate.Location = new Point(109, 205);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(252, 27);
            dtpDueDate.TabIndex = 9;
            // 
            // dtpLoanDate
            // 
            dtpLoanDate.Location = new Point(109, 172);
            dtpLoanDate.Name = "dtpLoanDate";
            dtpLoanDate.Size = new Size(252, 27);
            dtpLoanDate.TabIndex = 8;
            // 
            // cmbStaff
            // 
            cmbStaff.FormattingEnabled = true;
            cmbStaff.Location = new Point(112, 130);
            cmbStaff.Name = "cmbStaff";
            cmbStaff.Size = new Size(414, 28);
            cmbStaff.TabIndex = 7;
            // 
            // cmbBookCopy
            // 
            cmbBookCopy.FormattingEnabled = true;
            cmbBookCopy.Location = new Point(112, 87);
            cmbBookCopy.Name = "cmbBookCopy";
            cmbBookCopy.Size = new Size(414, 28);
            cmbBookCopy.TabIndex = 6;
            // 
            // cmbMember
            // 
            cmbMember.FormattingEnabled = true;
            cmbMember.Location = new Point(112, 46);
            cmbMember.Name = "cmbMember";
            cmbMember.Size = new Size(414, 28);
            cmbMember.TabIndex = 5;
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(16, 210);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(72, 20);
            lblDueDate.TabIndex = 4;
            lblDueDate.Text = "Due Date";
            // 
            // lblLoanDate
            // 
            lblLoanDate.AutoSize = true;
            lblLoanDate.Location = new Point(16, 177);
            lblLoanDate.Name = "lblLoanDate";
            lblLoanDate.Size = new Size(77, 20);
            lblLoanDate.TabIndex = 3;
            lblLoanDate.Text = "Loan Date";
            // 
            // lblStaff
            // 
            lblStaff.AutoSize = true;
            lblStaff.Location = new Point(16, 133);
            lblStaff.Name = "lblStaff";
            lblStaff.Size = new Size(40, 20);
            lblStaff.TabIndex = 2;
            lblStaff.Text = "Staff";
            // 
            // lblBookCopy
            // 
            lblBookCopy.AutoSize = true;
            lblBookCopy.Location = new Point(16, 90);
            lblBookCopy.Name = "lblBookCopy";
            lblBookCopy.Size = new Size(81, 20);
            lblBookCopy.TabIndex = 1;
            lblBookCopy.Text = "Book Copy";
            // 
            // lblMember
            // 
            lblMember.AutoSize = true;
            lblMember.Location = new Point(16, 49);
            lblMember.Name = "lblMember";
            lblMember.Size = new Size(65, 20);
            lblMember.TabIndex = 0;
            lblMember.Text = "Member";
            // 
            // pnlResults
            // 
            pnlResults.Controls.Add(dgvLoanHistory);
            pnlResults.Controls.Add(cmbFilter);
            pnlResults.Controls.Add(btnSearch);
            pnlResults.Controls.Add(txtSearch);
            pnlResults.Controls.Add(lblFilter);
            pnlResults.Controls.Add(lblLoanHistory);
            pnlResults.Location = new Point(12, 346);
            pnlResults.Name = "pnlResults";
            pnlResults.Size = new Size(908, 245);
            pnlResults.TabIndex = 0;
            // 
            // dgvLoanHistory
            // 
            dgvLoanHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoanHistory.Location = new Point(16, 54);
            dgvLoanHistory.Name = "dgvLoanHistory";
            dgvLoanHistory.RowHeadersWidth = 51;
            dgvLoanHistory.Size = new Size(880, 174);
            dgvLoanHistory.TabIndex = 6;
            // 
            // cmbFilter
            // 
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Location = new Point(745, 13);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(151, 28);
            cmbFilter.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Plum;
            btnSearch.Location = new Point(595, 14);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(364, 14);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(225, 27);
            txtSearch.TabIndex = 3;
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Location = new Point(697, 16);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(42, 20);
            lblFilter.TabIndex = 2;
            lblFilter.Text = "Filter";
            // 
            // lblLoanHistory
            // 
            lblLoanHistory.AutoSize = true;
            lblLoanHistory.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoanHistory.Location = new Point(16, 14);
            lblLoanHistory.Name = "lblLoanHistory";
            lblLoanHistory.Size = new Size(226, 23);
            lblLoanHistory.TabIndex = 0;
            lblLoanHistory.Text = "Active and Historical Loans";
            // 
            // pnlReturns
            // 
            pnlReturns.Controls.Add(lblReturn);
            pnlReturns.Controls.Add(btnReturnBook);
            pnlReturns.Controls.Add(dtpReturnDate);
            pnlReturns.Controls.Add(textBox2);
            pnlReturns.Controls.Add(lblReturnDate);
            pnlReturns.Controls.Add(lblLoanID);
            pnlReturns.Location = new Point(562, 91);
            pnlReturns.Name = "pnlReturns";
            pnlReturns.Size = new Size(355, 249);
            pnlReturns.TabIndex = 4;
            // 
            // lblReturn
            // 
            lblReturn.AutoSize = true;
            lblReturn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReturn.Location = new Point(22, 12);
            lblReturn.Name = "lblReturn";
            lblReturn.Size = new Size(110, 23);
            lblReturn.TabIndex = 5;
            lblReturn.Text = "Return Book";
            // 
            // btnReturnBook
            // 
            btnReturnBook.BackColor = Color.Khaki;
            btnReturnBook.Location = new Point(116, 186);
            btnReturnBook.Name = "btnReturnBook";
            btnReturnBook.Size = new Size(125, 40);
            btnReturnBook.TabIndex = 4;
            btnReturnBook.Text = "Return Book";
            btnReturnBook.UseVisualStyleBackColor = false;
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.Location = new Point(116, 116);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(218, 27);
            dtpReturnDate.TabIndex = 3;
            dtpReturnDate.ValueChanged += dateTimePicker3_ValueChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(116, 58);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(218, 27);
            textBox2.TabIndex = 2;
            // 
            // lblReturnDate
            // 
            lblReturnDate.AutoSize = true;
            lblReturnDate.Location = new Point(22, 118);
            lblReturnDate.Name = "lblReturnDate";
            lblReturnDate.Size = new Size(88, 20);
            lblReturnDate.TabIndex = 1;
            lblReturnDate.Text = "Return Date";
            // 
            // lblLoanID
            // 
            lblLoanID.AutoSize = true;
            lblLoanID.Location = new Point(22, 61);
            lblLoanID.Name = "lblLoanID";
            lblLoanID.Size = new Size(60, 20);
            lblLoanID.TabIndex = 0;
            lblLoanID.Text = "Loan ID";
            // 
            // Loans
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 603);
            Controls.Add(pnlReturns);
            Controls.Add(pnlResults);
            Controls.Add(pnlLoans);
            Controls.Add(pnlTitle);
            Name = "Loans";
            Text = "Loans and Returns";
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            pnlLoans.ResumeLayout(false);
            pnlLoans.PerformLayout();
            pnlResults.ResumeLayout(false);
            pnlResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoanHistory).EndInit();
            pnlReturns.ResumeLayout(false);
            pnlReturns.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitle;
        private Button btnBack;
        private Label lblTitle;
        private Label lblLearner;
        private Panel pnlLoans;
        private Button btnIssueBook;
        private DateTimePicker dtpDueDate;
        private DateTimePicker dtpLoanDate;
        private ComboBox cmbStaff;
        private ComboBox cmbBookCopy;
        private ComboBox cmbMember;
        private Label lblDueDate;
        private Label lblLoanDate;
        private Label lblStaff;
        private Label lblBookCopy;
        private Label lblMember;
        private Panel pnlResults;
        private Label lblFilter;
        private Label lblLoanHistory;
        private Label lblLoanTitle;
        private DataGridView dgvLoanHistory;
        private ComboBox cmbFilter;
        private Button btnSearch;
        private TextBox txtSearch;
        private Panel pnlReturns;
        private Label lblReturn;
        private Button btnReturnBook;
        private DateTimePicker dtpReturnDate;
        private TextBox textBox2;
        private Label lblReturnDate;
        private Label lblLoanID;
    }
}