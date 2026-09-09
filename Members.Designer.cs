namespace KhayelitshaCommunityLibrary
{
    partial class Members
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
            lblMemberID = new Label();
            lblFullName = new Label();
            lblJoinDate = new Label();
            lblAddress = new Label();
            lblPhone = new Label();
            txtMemberID = new TextBox();
            txtName = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            btnClear = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            pnlLeft = new Panel();
            dtpDateJoined = new DateTimePicker();
            pnlRight = new Panel();
            txtSearch = new TextBox();
            dgvMembers = new DataGridView();
            lblSearch = new Label();
            btnSearch = new Button();
            pnlTitle.SuspendLayout();
            pnlLeft.SuspendLayout();
            pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
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
            pnlTitle.Size = new Size(832, 75);
            pnlTitle.TabIndex = 0;
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
            // lblMemberID
            // 
            lblMemberID.AutoSize = true;
            lblMemberID.Location = new Point(17, 11);
            lblMemberID.Name = "lblMemberID";
            lblMemberID.Size = new Size(84, 20);
            lblMemberID.TabIndex = 1;
            lblMemberID.Text = "Member ID";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(17, 52);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(76, 20);
            lblFullName.TabIndex = 2;
            lblFullName.Text = "Full Name";
            // 
            // lblJoinDate
            // 
            lblJoinDate.AutoSize = true;
            lblJoinDate.Location = new Point(17, 225);
            lblJoinDate.Name = "lblJoinDate";
            lblJoinDate.Size = new Size(71, 20);
            lblJoinDate.TabIndex = 3;
            lblJoinDate.Text = "Join Date";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(17, 89);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(62, 20);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(17, 187);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(50, 20);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "Phone";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(110, 11);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.ReadOnly = true;
            txtMemberID.Size = new Size(173, 27);
            txtMemberID.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(108, 49);
            txtName.Name = "txtName";
            txtName.Size = new Size(175, 27);
            txtName.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(108, 86);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(175, 85);
            txtAddress.TabIndex = 9;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(108, 184);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(175, 27);
            txtPhone.TabIndex = 10;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightSkyBlue;
            btnClear.Location = new Point(158, 332);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(125, 50);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.PaleGreen;
            btnAdd.Location = new Point(13, 266);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(125, 50);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Khaki;
            btnUpdate.Location = new Point(158, 266);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(125, 50);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightCoral;
            btnDelete.Location = new Point(13, 332);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(125, 50);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = SystemColors.ControlLight;
            pnlLeft.Controls.Add(dtpDateJoined);
            pnlLeft.Controls.Add(btnDelete);
            pnlLeft.Controls.Add(btnUpdate);
            pnlLeft.Controls.Add(lblMemberID);
            pnlLeft.Controls.Add(lblFullName);
            pnlLeft.Controls.Add(lblAddress);
            pnlLeft.Controls.Add(lblPhone);
            pnlLeft.Controls.Add(lblJoinDate);
            pnlLeft.Controls.Add(txtMemberID);
            pnlLeft.Controls.Add(txtName);
            pnlLeft.Controls.Add(txtAddress);
            pnlLeft.Controls.Add(txtPhone);
            pnlLeft.Controls.Add(btnClear);
            pnlLeft.Controls.Add(btnAdd);
            pnlLeft.Location = new Point(12, 93);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(298, 398);
            pnlLeft.TabIndex = 15;
            // 
            // dtpDateJoined
            // 
            dtpDateJoined.Location = new Point(108, 220);
            dtpDateJoined.Name = "dtpDateJoined";
            dtpDateJoined.Size = new Size(175, 27);
            dtpDateJoined.TabIndex = 15;
            // 
            // pnlRight
            // 
            pnlRight.BackColor = SystemColors.ControlLight;
            pnlRight.Controls.Add(txtSearch);
            pnlRight.Controls.Add(dgvMembers);
            pnlRight.Controls.Add(lblSearch);
            pnlRight.Controls.Add(btnSearch);
            pnlRight.Location = new Point(326, 93);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(494, 398);
            pnlRight.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(72, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(295, 27);
            txtSearch.TabIndex = 1;
            // 
            // dgvMembers
            // 
            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembers.Location = new Point(15, 52);
            dgvMembers.Name = "dgvMembers";
            dgvMembers.RowHeadersWidth = 51;
            dgvMembers.Size = new Size(463, 334);
            dgvMembers.TabIndex = 3;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(13, 15);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(53, 20);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Plum;
            btnSearch.ForeColor = SystemColors.ControlText;
            btnSearch.Location = new Point(378, 7);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 35);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // Members
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 503);
            Controls.Add(pnlRight);
            Controls.Add(pnlLeft);
            Controls.Add(pnlTitle);
            Name = "Members";
            Text = "Member Management";
            Load += Members_Load;
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            pnlRight.ResumeLayout(false);
            pnlRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitle;
        private Label lblMemberID;
        private Label lblFullName;
        private Label lblJoinDate;
        private Label lblAddress;
        private Label lblPhone;
        private TextBox txtMemberID;
        private TextBox txtName;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private Button btnClear;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Panel pnlLeft;
        private Panel pnlRight;
        private TextBox txtSearch;
        private DataGridView dgvMembers;
        private Label lblSearch;
        private Button btnSearch;
        private Label lblTitle;
        private Label lblLearner;
        private DateTimePicker dtpDateJoined;
        private Button btnBack;
    }
}