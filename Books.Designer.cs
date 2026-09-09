namespace KhayelitshaCommunityLibrary
{
    partial class Books
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
            lblTitle = new Label();
            lblLearner = new Label();
            pnlBookTitles = new Panel();
            pnlBookCopies = new Panel();
            lblBookTitles = new Label();
            lblTitles = new Label();
            lblAuthor = new Label();
            lblGenre = new Label();
            lblISBN = new Label();
            lblYear = new Label();
            txtAuthor = new TextBox();
            txtTitle = new TextBox();
            txtISBN = new TextBox();
            cmbGenre = new ComboBox();
            numYear = new NumericUpDown();
            btnClearTitle = new Button();
            btnAddTitle = new Button();
            btnUpdateTitle = new Button();
            dgvTitles = new DataGridView();
            txtSearchTitle = new TextBox();
            lblSearchTitle = new Label();
            btnSearchTitle = new Button();
            btnBack = new Button();
            lblCopies = new Label();
            lblCopyTitle = new Label();
            lblStatus = new Label();
            cmbTitle = new ComboBox();
            cmbStatus = new ComboBox();
            btnAddCopies = new Button();
            btnUpdateCopies = new Button();
            dgvCopies = new DataGridView();
            pnlTitle.SuspendLayout();
            pnlBookTitles.SuspendLayout();
            pnlBookCopies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTitles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCopies).BeginInit();
            SuspendLayout();
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.Teal;
            pnlTitle.Controls.Add(btnBack);
            pnlTitle.Controls.Add(lblTitle);
            pnlTitle.Controls.Add(lblLearner);
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(933, 75);
            pnlTitle.TabIndex = 1;
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
            // pnlBookTitles
            // 
            pnlBookTitles.BackColor = SystemColors.ControlLight;
            pnlBookTitles.Controls.Add(txtSearchTitle);
            pnlBookTitles.Controls.Add(lblSearchTitle);
            pnlBookTitles.Controls.Add(btnSearchTitle);
            pnlBookTitles.Controls.Add(dgvTitles);
            pnlBookTitles.Controls.Add(btnUpdateTitle);
            pnlBookTitles.Controls.Add(btnAddTitle);
            pnlBookTitles.Controls.Add(btnClearTitle);
            pnlBookTitles.Controls.Add(numYear);
            pnlBookTitles.Controls.Add(cmbGenre);
            pnlBookTitles.Controls.Add(txtISBN);
            pnlBookTitles.Controls.Add(txtTitle);
            pnlBookTitles.Controls.Add(txtAuthor);
            pnlBookTitles.Controls.Add(lblYear);
            pnlBookTitles.Controls.Add(lblISBN);
            pnlBookTitles.Controls.Add(lblGenre);
            pnlBookTitles.Controls.Add(lblAuthor);
            pnlBookTitles.Controls.Add(lblTitles);
            pnlBookTitles.Controls.Add(lblBookTitles);
            pnlBookTitles.Location = new Point(12, 90);
            pnlBookTitles.Name = "pnlBookTitles";
            pnlBookTitles.Size = new Size(908, 308);
            pnlBookTitles.TabIndex = 2;
            // 
            // pnlBookCopies
            // 
            pnlBookCopies.BackColor = SystemColors.ControlLight;
            pnlBookCopies.Controls.Add(dgvCopies);
            pnlBookCopies.Controls.Add(btnUpdateCopies);
            pnlBookCopies.Controls.Add(btnAddCopies);
            pnlBookCopies.Controls.Add(cmbStatus);
            pnlBookCopies.Controls.Add(cmbTitle);
            pnlBookCopies.Controls.Add(lblStatus);
            pnlBookCopies.Controls.Add(lblCopyTitle);
            pnlBookCopies.Controls.Add(lblCopies);
            pnlBookCopies.Location = new Point(12, 404);
            pnlBookCopies.Name = "pnlBookCopies";
            pnlBookCopies.Size = new Size(908, 187);
            pnlBookCopies.TabIndex = 0;
            // 
            // lblBookTitles
            // 
            lblBookTitles.AutoSize = true;
            lblBookTitles.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookTitles.Location = new Point(18, 9);
            lblBookTitles.Name = "lblBookTitles";
            lblBookTitles.Size = new Size(99, 23);
            lblBookTitles.TabIndex = 0;
            lblBookTitles.Text = "Book Titles";
            // 
            // lblTitles
            // 
            lblTitles.AutoSize = true;
            lblTitles.Location = new Point(18, 44);
            lblTitles.Name = "lblTitles";
            lblTitles.Size = new Size(38, 20);
            lblTitles.TabIndex = 1;
            lblTitles.Text = "Title";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(18, 86);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(54, 20);
            lblAuthor.TabIndex = 2;
            lblAuthor.Text = "Author";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Location = new Point(18, 128);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(48, 20);
            lblGenre.TabIndex = 3;
            lblGenre.Text = "Genre";
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Location = new Point(18, 174);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(41, 20);
            lblISBN.TabIndex = 4;
            lblISBN.Text = "ISBN";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(18, 215);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(37, 20);
            lblYear.TabIndex = 5;
            lblYear.Text = "Year";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(87, 83);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(243, 27);
            txtAuthor.TabIndex = 6;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(87, 41);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(243, 27);
            txtTitle.TabIndex = 7;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(87, 171);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(243, 27);
            txtISBN.TabIndex = 8;
            // 
            // cmbGenre
            // 
            cmbGenre.FormattingEnabled = true;
            cmbGenre.Location = new Point(87, 125);
            cmbGenre.Name = "cmbGenre";
            cmbGenre.Size = new Size(243, 28);
            cmbGenre.TabIndex = 10;
            // 
            // numYear
            // 
            numYear.Location = new Point(87, 213);
            numYear.Maximum = new decimal(new int[] { 2026, 0, 0, 0 });
            numYear.Minimum = new decimal(new int[] { 1899, 0, 0, 0 });
            numYear.Name = "numYear";
            numYear.Size = new Size(243, 27);
            numYear.TabIndex = 11;
            numYear.Value = new decimal(new int[] { 1899, 0, 0, 0 });
            numYear.ValueChanged += numYear_ValueChanged;
            // 
            // btnClearTitle
            // 
            btnClearTitle.BackColor = Color.LightSkyBlue;
            btnClearTitle.Location = new Point(233, 248);
            btnClearTitle.Name = "btnClearTitle";
            btnClearTitle.Size = new Size(100, 45);
            btnClearTitle.TabIndex = 12;
            btnClearTitle.Text = "Clear";
            btnClearTitle.UseVisualStyleBackColor = false;
            // 
            // btnAddTitle
            // 
            btnAddTitle.BackColor = Color.PaleGreen;
            btnAddTitle.Location = new Point(21, 248);
            btnAddTitle.Name = "btnAddTitle";
            btnAddTitle.Size = new Size(100, 45);
            btnAddTitle.TabIndex = 13;
            btnAddTitle.Text = "Add";
            btnAddTitle.UseVisualStyleBackColor = false;
            // 
            // btnUpdateTitle
            // 
            btnUpdateTitle.BackColor = Color.Khaki;
            btnUpdateTitle.Location = new Point(127, 248);
            btnUpdateTitle.Name = "btnUpdateTitle";
            btnUpdateTitle.Size = new Size(100, 45);
            btnUpdateTitle.TabIndex = 14;
            btnUpdateTitle.Text = "Update";
            btnUpdateTitle.UseVisualStyleBackColor = false;
            // 
            // dgvTitles
            // 
            dgvTitles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTitles.Location = new Point(349, 44);
            dgvTitles.Name = "dgvTitles";
            dgvTitles.RowHeadersWidth = 51;
            dgvTitles.Size = new Size(545, 249);
            dgvTitles.TabIndex = 15;
            // 
            // txtSearchTitle
            // 
            txtSearchTitle.Location = new Point(406, 8);
            txtSearchTitle.Name = "txtSearchTitle";
            txtSearchTitle.Size = new Size(382, 27);
            txtSearchTitle.TabIndex = 17;
            // 
            // lblSearchTitle
            // 
            lblSearchTitle.AutoSize = true;
            lblSearchTitle.Location = new Point(347, 11);
            lblSearchTitle.Name = "lblSearchTitle";
            lblSearchTitle.Size = new Size(53, 20);
            lblSearchTitle.TabIndex = 16;
            lblSearchTitle.Text = "Search";
            // 
            // btnSearchTitle
            // 
            btnSearchTitle.BackColor = Color.Plum;
            btnSearchTitle.Location = new Point(794, 8);
            btnSearchTitle.Name = "btnSearchTitle";
            btnSearchTitle.Size = new Size(100, 30);
            btnSearchTitle.TabIndex = 18;
            btnSearchTitle.Text = "Search";
            btnSearchTitle.UseVisualStyleBackColor = false;
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
            // lblCopies
            // 
            lblCopies.AutoSize = true;
            lblCopies.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCopies.Location = new Point(18, 12);
            lblCopies.Name = "lblCopies";
            lblCopies.Size = new Size(109, 23);
            lblCopies.TabIndex = 0;
            lblCopies.Text = "Book Copies";
            // 
            // lblCopyTitle
            // 
            lblCopyTitle.AutoSize = true;
            lblCopyTitle.Location = new Point(21, 45);
            lblCopyTitle.Name = "lblCopyTitle";
            lblCopyTitle.Size = new Size(38, 20);
            lblCopyTitle.TabIndex = 1;
            lblCopyTitle.Text = "Title";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(22, 89);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(49, 20);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Status";
            // 
            // cmbTitle
            // 
            cmbTitle.FormattingEnabled = true;
            cmbTitle.Location = new Point(87, 42);
            cmbTitle.Name = "cmbTitle";
            cmbTitle.Size = new Size(313, 28);
            cmbTitle.TabIndex = 3;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(87, 86);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(313, 28);
            cmbStatus.TabIndex = 4;
            // 
            // btnAddCopies
            // 
            btnAddCopies.BackColor = Color.PaleGreen;
            btnAddCopies.Location = new Point(43, 126);
            btnAddCopies.Name = "btnAddCopies";
            btnAddCopies.Size = new Size(150, 45);
            btnAddCopies.TabIndex = 5;
            btnAddCopies.Text = "Add";
            btnAddCopies.UseVisualStyleBackColor = false;
            // 
            // btnUpdateCopies
            // 
            btnUpdateCopies.BackColor = Color.Khaki;
            btnUpdateCopies.Location = new Point(224, 126);
            btnUpdateCopies.Name = "btnUpdateCopies";
            btnUpdateCopies.Size = new Size(150, 45);
            btnUpdateCopies.TabIndex = 6;
            btnUpdateCopies.Text = "Update";
            btnUpdateCopies.UseVisualStyleBackColor = false;
            btnUpdateCopies.Click += button2_Click;
            // 
            // dgvCopies
            // 
            dgvCopies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCopies.Location = new Point(418, 16);
            dgvCopies.Name = "dgvCopies";
            dgvCopies.RowHeadersWidth = 51;
            dgvCopies.Size = new Size(476, 155);
            dgvCopies.TabIndex = 7;
            // 
            // Books
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 603);
            Controls.Add(pnlBookCopies);
            Controls.Add(pnlBookTitles);
            Controls.Add(pnlTitle);
            Name = "Books";
            Text = "Book Titles and Copies";
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            pnlBookTitles.ResumeLayout(false);
            pnlBookTitles.PerformLayout();
            pnlBookCopies.ResumeLayout(false);
            pnlBookCopies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTitles).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCopies).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitle;
        private Label lblTitle;
        private Label lblLearner;
        private Panel pnlBookTitles;
        private ComboBox cmbGenre;
        private TextBox txtISBN;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private Label lblYear;
        private Label lblISBN;
        private Label lblGenre;
        private Label lblAuthor;
        private Label lblTitles;
        private Label lblBookTitles;
        private Panel pnlBookCopies;
        private Button btnUpdateTitle;
        private Button btnAddTitle;
        private Button btnClearTitle;
        private NumericUpDown numYear;
        private DataGridView dgvTitles;
        private TextBox txtSearchTitle;
        private Label lblSearchTitle;
        private Button btnSearchTitle;
        private Button btnBack;
        private DataGridView dgvCopies;
        private Button btnUpdateCopies;
        private Button btnAddCopies;
        private ComboBox cmbStatus;
        private ComboBox cmbTitle;
        private Label lblStatus;
        private Label lblCopyTitle;
        private Label lblCopies;
    }
}