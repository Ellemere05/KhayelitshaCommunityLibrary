namespace KhayelitshaCommunityLibrary
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnMembers = new Button();
            btnLoans = new Button();
            btnExit = new Button();
            btnBooks = new Button();
            lblTitle = new Label();
            lblLearner = new Label();
            lblSubtitle = new Label();
            pnlTitle = new Panel();
            button1 = new Button();
            pnlTitle.SuspendLayout();
            SuspendLayout();
            // 
            // btnMembers
            // 
            btnMembers.Location = new Point(133, 150);
            btnMembers.Margin = new Padding(3, 4, 3, 4);
            btnMembers.Name = "btnMembers";
            btnMembers.Size = new Size(350, 60);
            btnMembers.TabIndex = 0;
            btnMembers.Text = "Manage Members";
            btnMembers.UseVisualStyleBackColor = true;
            // 
            // btnLoans
            // 
            btnLoans.Location = new Point(133, 305);
            btnLoans.Margin = new Padding(3, 4, 3, 4);
            btnLoans.Name = "btnLoans";
            btnLoans.Size = new Size(350, 60);
            btnLoans.TabIndex = 1;
            btnLoans.Text = "Loans And Returns";
            btnLoans.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.LightCoral;
            btnExit.ForeColor = SystemColors.ActiveCaptionText;
            btnExit.Location = new Point(236, 472);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(137, 47);
            btnExit.TabIndex = 2;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // btnBooks
            // 
            btnBooks.Location = new Point(133, 228);
            btnBooks.Margin = new Padding(3, 4, 3, 4);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(350, 60);
            btnBooks.TabIndex = 3;
            btnBooks.Text = "Manage Books";
            btnBooks.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.Control;
            lblTitle.Location = new Point(106, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(422, 37);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Khayelitsha Community Library";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblLearner
            // 
            lblLearner.AutoSize = true;
            lblLearner.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLearner.ForeColor = SystemColors.ScrollBar;
            lblLearner.Location = new Point(167, 86);
            lblLearner.Name = "lblLearner";
            lblLearner.Size = new Size(285, 20);
            lblLearner.TabIndex = 5;
            lblLearner.Text = "Amy-Lee Baker | 20240116 | FA2 | MDB622";
            lblLearner.Click += lblLearner_Click;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = SystemColors.Control;
            lblSubtitle.Location = new Point(189, 63);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(238, 23);
            lblSubtitle.TabIndex = 6;
            lblSubtitle.Text = "Desktop Management System";
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.Teal;
            pnlTitle.Controls.Add(lblTitle);
            pnlTitle.Controls.Add(lblLearner);
            pnlTitle.Controls.Add(lblSubtitle);
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(668, 127);
            pnlTitle.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(133, 385);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(350, 60);
            button1.TabIndex = 8;
            button1.Text = "Reports";
            button1.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 553);
            Controls.Add(button1);
            Controls.Add(pnlTitle);
            Controls.Add(btnBooks);
            Controls.Add(btnExit);
            Controls.Add(btnLoans);
            Controls.Add(btnMembers);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Khayelitsha Community Library";
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnMembers;
        private Button btnLoans;
        private Button btnExit;
        private Button btnBooks;
        private Label lblTitle;
        private Label lblLearner;
        private Label lblSubtitle;
        private Panel pnlTitle;
        private Button button1;
    }
}
