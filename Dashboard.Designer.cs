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
            SuspendLayout();
            // 
            // btnMembers
            // 
            btnMembers.Location = new Point(158, 151);
            btnMembers.Name = "btnMembers";
            btnMembers.Size = new Size(260, 45);
            btnMembers.TabIndex = 0;
            btnMembers.Text = "Manage Members";
            btnMembers.UseVisualStyleBackColor = true;
            // 
            // btnLoans
            // 
            btnLoans.Location = new Point(158, 270);
            btnLoans.Name = "btnLoans";
            btnLoans.Size = new Size(260, 45);
            btnLoans.TabIndex = 1;
            btnLoans.Text = "Loans And Returns";
            btnLoans.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(192, 0, 0);
            btnExit.ForeColor = SystemColors.ControlLightLight;
            btnExit.Location = new Point(220, 330);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(120, 35);
            btnExit.TabIndex = 2;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // btnBooks
            // 
            btnBooks.Location = new Point(158, 212);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(260, 45);
            btnBooks.TabIndex = 3;
            btnBooks.Text = "Manage Books";
            btnBooks.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(131, 46);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(322, 30);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Khayelitsha Community Library";
            // 
            // lblLearner
            // 
            lblLearner.AutoSize = true;
            lblLearner.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLearner.ForeColor = SystemColors.ControlDarkDark;
            lblLearner.Location = new Point(172, 95);
            lblLearner.Name = "lblLearner";
            lblLearner.Size = new Size(232, 15);
            lblLearner.TabIndex = 5;
            lblLearner.Text = "Student: Amy-Lee Baker | Module: MDB622";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.Location = new Point(193, 76);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(194, 19);
            lblSubtitle.TabIndex = 6;
            lblSubtitle.Text = "Desktop Management System";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 411);
            Controls.Add(lblSubtitle);
            Controls.Add(lblLearner);
            Controls.Add(lblTitle);
            Controls.Add(btnBooks);
            Controls.Add(btnExit);
            Controls.Add(btnLoans);
            Controls.Add(btnMembers);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Khayelitsha Community Library";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMembers;
        private Button btnLoans;
        private Button btnExit;
        private Button btnBooks;
        private Label lblTitle;
        private Label lblLearner;
        private Label lblSubtitle;
    }
}
