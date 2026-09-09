using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhayelitshaCommunityLibrary
{
    public partial class Loans : Form
    {
        private int selectedReturnCopyId = -1;

        public Loans()
        {
            InitializeComponent();
        }

        private void Loans_Load(object sender, EventArgs e)
        {
            dgvLoanHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLoanHistory.MultiSelect = false;
            dgvLoanHistory.ReadOnly = true;
            dgvLoanHistory.AutoGenerateColumns = true;
            dgvLoanHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtpLoanDate.Value = DateTime.Now;
            dtpDueDate.Value = DateTime.Now.AddDays(14);
            dtpReturnDate.Value = DateTime.Now;

            if (cmbFilter.Items.Count == 0)
            {
                cmbFilter.Items.Add("All Loans");
                cmbFilter.Items.Add("Active Loans");
                cmbFilter.Items.Add("Overdue Loans");
                cmbFilter.Items.Add("Returned Loans");
                cmbFilter.SelectedIndex = 0;
            }

            RefreshForm();
        }

        private void RefreshForm()
        {
            LoadDropdowns();
            LoadLoans();
        }

        // POPULATE DROPDOWNS

        private void LoadDropdowns()
        {
            DataTable dtMembers = DatabaseHelper.ExecuteQuery("SELECT MemberId, (FullName + '  (ID: ' + CAST(MemberID AS VARCHAR) + ')') " +
                "AS DisplayText FROM Member ORDER BY FullName");
            cmbMember.DataSource = dtMembers;
            cmbMember.DisplayMember = "DisplayText";
            cmbMember.ValueMember = "MemberId";
            cmbMember.SelectedIndex = -1;

            DataTable dtStaff = DatabaseHelper.ExecuteQuery("SELECT StaffId, (FullName + '  (' + Role + ')')" +
                "AS DisplayText FROM Staff ORDER BY FullName");
            cmbStaff.DataSource = dtStaff;
            cmbStaff.DisplayMember = "DisplayText";
            cmbStaff.ValueMember = "StaffId";
            cmbStaff.SelectedIndex = -1;

            string copyQuery = @"SELECT BC.CopyId, ('Copy #' + CAST(BC.CopyID AS VARCHAR) + ' - ' + BT.Title) AS DisplayText " +
                "FROM BookCopy BC JOIN BookTitle BT ON BC.TitleID = BT.TitleID WHERE BC.Status = 'Available' ORDER BY BT.Title";
            DataTable dtCopies = DatabaseHelper.ExecuteQuery(copyQuery);
            cmbBookCopy.DataSource = dtCopies;
            cmbBookCopy.DisplayMember = "DisplayText";
            cmbBookCopy.ValueMember = "CopyId";
            cmbBookCopy.SelectedIndex = -1;
        }

        // LOAD LOANS AND FILTER

        private void LoadLoans()
        {
            string query = @"SELECT L.LoanId, M.FullName AS [Member Name], L.CopyID, BT.Title AS [Book Title], 
                            S.FullName AS [Issued By Staff], L.LoanDate AS [Loan Date], L.DueDate AS [Due Date],
                            L.ReturnDate AS [Return Date], CASE WHEN L.ReturnDate IS NOT NULL THEN 'Returned'
                            WHEN L.DueDate < CAST(GETDATE() AS DATE) THEN 'Overdue' ELSE 'Active' END AS [Loan Status]
                            FROM Loan L JOIN Member M ON L.MemberID = M.MemberID JOIN BookCopy BC ON L.CopyID = BC.CopyID
                            JOIN BookTitle BT ON BC.TitleID = BT.TitleID JOIN Staff S ON L.StaffID = S.StaffID WHERE 1=1";

            if (cmbFilter.SelectedIndex == 1)
            {
                query += " AND L.ReturnDate IS NULL";
            }
            else if (cmbFilter.SelectedIndex == 2)
            {
                query += " AND L.ReturnDate IS NULL AND L.DueDate < CAST(GETDATE() AS DATE)";
            }
            else if (cmbFilter.SelectedIndex == 3)
            {
                query += " AND L.ReturnDate IS NOT NULL";
            }

            SqlParameter[] parameters = null;
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                query += " AND (M.FullName LIKE '%' + @Search + '%' OR BT.Title LIKE '%' + @Search + '%'" +
                    "OR CAST(L.CopyID AS VARCHAR) LIKE @Search)";
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@Search", txtSearch.Text.Trim())
                };
            }

            query += " ORDER BY L.LoanDate DESC";

            dgvLoanHistory.DataSource = DatabaseHelper.ExecuteQuery(query, parameters);
        }

        // ISSUE LOANS

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            if (cmbMember.SelectedValue == null)
            {
                MessageBox.Show("Please select a member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbMember.Focus();
                return;
            }

            if (cmbBookCopy.SelectedValue == null)
            {
                MessageBox.Show("Please select a book copy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbBookCopy.Focus();
                return;
            }

            if (cmbStaff.SelectedValue == null)
            {
                MessageBox.Show("Please select a staff member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbStaff.Focus();
                return;
            }

            int memberId = Convert.ToInt32(cmbMember.SelectedValue);
            int copyId = Convert.ToInt32(cmbBookCopy.SelectedValue);
            int staffId = Convert.ToInt32(cmbStaff.SelectedValue);

            string insertQuery = @"INSERT INTO Loan (MemberID, CopyID, StaffID, LoanDate, DueDate, ReturnDate) 
                                   VALUES (@MemberID, @CopyID, @StaffID, @LoanDate, @DueDate, NULL);";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MemberID", memberId),
                new SqlParameter("@CopyID", copyId),
                new SqlParameter("@StaffID", staffId),
                new SqlParameter("@LoanDate", dtpLoanDate.Value.Date),
                new SqlParameter("@DueDate", dtpDueDate.Value.Date)
            };

            int inserted = DatabaseHelper.ExecuteNonQuery(insertQuery, parameters);

            if (inserted > 0)
            {
                string updateCopyQuery = "UPDATE BookCopy SET Status = 'On Loan' WHERE CopyID = @CopyID";
                SqlParameter[] updateParameters = { new SqlParameter("@CopyID", copyId) };

                DatabaseHelper.ExecuteNonQuery(updateCopyQuery, updateParameters);

                MessageBox.Show("Book issued successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshForm();
            }
        }

        // RETURN LOANS

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLoanID.Text))
            {
                MessageBox.Show("Please select a loan to return.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int loanId = Convert.ToInt32(txtLoanID.Text);

            string updateQuery = @"UPDATE Loan SET ReturnDate = @ReturnDate WHERE LoanID = @LoanID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ReturnDate", dtpReturnDate.Value.Date),
                new SqlParameter("@LoanID", loanId)
            };

            int rows = DatabaseHelper.ExecuteNonQuery(updateQuery, parameters);

            if (rows > 0)
            {
                if (selectedReturnCopyId > 0)
                {
                    string updateCopyQuery = "UPDATE BookCopy SET Status = 'Available' WHERE CopyID = @CopyID";
                    SqlParameter[] updateParameters = { new SqlParameter("@CopyID", selectedReturnCopyId) };
                    DatabaseHelper.ExecuteNonQuery(updateCopyQuery, updateParameters);
                }

                MessageBox.Show("Book returned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLoanID.Clear();
                selectedReturnCopyId = -1;
                RefreshForm();
            }
        }

        private void dgvLoans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLoanHistory.Rows[e.RowIndex];

                if (row.Cells["Return Date"].Value != DBNull.Value && !string.IsNullOrEmpty(row.Cells["Return Date"].Value?.ToString()))
                {
                    MessageBox.Show("This loan has already been returned.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtLoanID.Clear();
                    selectedReturnCopyId = -1;
                    return;
                }

                txtLoanID.Text = row.Cells["LoanId"].Value.ToString();
                selectedReturnCopyId = Convert.ToInt32(row.Cells["CopyID"].Value);
                dtpReturnDate.Value = DateTime.Now;
            }
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLoans();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadLoans();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
